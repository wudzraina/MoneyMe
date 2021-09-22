using Dapper;
using Microsoft.Extensions.Configuration;
using MoneyMe.Application.Interface;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyMe.Insfrastracture.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConfiguration _configuration;

        public OrderRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> Add(Core.Entities.Order entity)
        {



            var sql = "INSERT INTO Order (Amount, Term, Title, FirstName, LastName, DateOfBirth, Mobile, Email) Values (@Amount, @Term, @Title, @FirstName, @LastName, @DateOfBirth, @Mobile, @Email);";



            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }

        }


        public async Task<int> Delete(int id)
        {
            var sql = "DELETE FROM Order WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Core.Entities.Order> Get(int id)
        {
            var sql = "SELECT * FROM Order WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Core.Entities.Order>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Core.Entities.Order>> GetAll()
        {
            var sql = "SELECT * FROM Order;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Core.Entities.Order>(sql);
                return result;
            }
        }

        public async Task<int> Update(Core.Entities.Order entity)
        {
            //entity.DateModified = DateTime.Now;
            var sql = "UPDATE Order SET Name = @Name, Description = @Description, Status = @Status, DueDate = @DueDate, DateModified = @DateModified WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}

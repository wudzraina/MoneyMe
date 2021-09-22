using MoneyMe.Application.Interface;

namespace MoneyMe.Insfrastracture.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IOrderRepository taskRepository)
        {
            Orders = taskRepository;
        }
        public IOrderRepository Orders { get; }
    }
}

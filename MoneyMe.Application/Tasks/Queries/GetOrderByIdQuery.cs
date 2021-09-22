using MediatR;
using MoneyMe.Application.Tasks.Dto;
 

namespace MoneyMe.Application.Tasks.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderDto>
    {
        public int Id { get; set; }
    }
}

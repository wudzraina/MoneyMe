using AutoMapper;
using MediatR;
using MoneyMe.Application.Interface;
using MoneyMe.Application.Tasks.Dto;
using MoneyMe.Application.Tasks.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace MoneyMe.Application.Tasks.Handlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, OrderDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetOrderByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Orders.Get(request.Id);
            return _mapper.Map<OrderDto>(result);
        }
    }
}

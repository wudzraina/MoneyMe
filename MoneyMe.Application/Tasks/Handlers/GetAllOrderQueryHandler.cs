using AutoMapper;
using MediatR;
using MoneyMe.Application.Interface;
using MoneyMe.Application.Tasks.Dto;
using MoneyMe.Application.Tasks.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MoneyMe.Application.Tasks.Handlers
{
    public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQuery, List<OrderDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllOrderQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<OrderDto>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Orders.GetAll();
            return _mapper.Map<List<OrderDto>>(result.ToList());
        }
    }
}

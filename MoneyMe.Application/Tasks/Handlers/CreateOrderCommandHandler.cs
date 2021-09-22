using AutoMapper;
using MediatR;
using MoneyMe.Application.Interface;
using MoneyMe.Application.Tasks.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MoneyMe.Application.Tasks.Handlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Orders.Add(_mapper.Map<Core.Entities.Order>(request));
            return result;
        }
    }
}

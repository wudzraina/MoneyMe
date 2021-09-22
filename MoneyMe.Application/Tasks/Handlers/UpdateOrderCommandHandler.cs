using AutoMapper;
using MediatR;
using MoneyMe.Application.Interface;
using MoneyMe.Application.Tasks.Command;
using MoneyMe.Core.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MoneyMe.Application.Tasks.Handlers
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Orders.Update(_mapper.Map<Core.Entities.Order>(request));
            return result;
        }

    }
}

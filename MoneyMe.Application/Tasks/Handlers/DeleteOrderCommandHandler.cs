using MediatR;
using MoneyMe.Application.Interface;
using MoneyMe.Application.Tasks.Command;
using System.Threading;
using System.Threading.Tasks;

namespace MoneyMe.Application.Tasks.Handlers
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Orders.Delete(request.Id);
            return result;
        }
    }
}

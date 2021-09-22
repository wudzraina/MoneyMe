using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyMe.Application.Tasks.Command
{
    public class DeleteOrderCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}

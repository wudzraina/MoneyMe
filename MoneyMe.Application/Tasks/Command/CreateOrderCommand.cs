using MediatR;
using MoneyMe.Core.Entities;
using MoneyMe.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyMe.Application.Tasks.Command
{
    public class CreateOrderCommand : Customer, IRequest<int>
    {

        public double Amount { get; set; }
        public Term Term { get; set; }


    }
}

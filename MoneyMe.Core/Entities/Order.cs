using MoneyMe.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyMe.Core.Entities
{
    public class Order : Customer
    {

        public int Id { get; set; }

        public double Amount { get; set; }

        public Term Term { get; set; }

    }
}

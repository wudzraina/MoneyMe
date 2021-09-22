using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyMe.Core.Entities
{
    public class Product
    {

        public double RequeredAmount { get; set; }
        public virtual double Amount()
        {
            return 0;
        }
    }

    public class ProductA : Product
    {

        public double requiredAmount { get; set; }
        public override double Amount()
        {
            return 0;
        }

    }
    public class ProductB : Product
    {
        double interest = 0.30;

        public int Duration { get; set; }
        public int MyProperty { get; set; }
        public override double Amount()
        {

            return RequeredAmount + (RequeredAmount * interest);
        }
    }
    public class ProductC : Product
    {

        public override double Amount()
        {
            return 0;
        }
    }
}

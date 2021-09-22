using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyMe.Application.Interface
{
    public interface IUnitOfWork
    {
        IOrderRepository Orders { get; }
    }
}

using MediatR;
using MoneyMe.Application.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyMe.Application.Tasks.Queries
{
    public class GetAllOrderQuery : IRequest<List<OrderDto>>
    {
    }
}

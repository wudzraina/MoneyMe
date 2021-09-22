using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoneyMe.Application.Tasks.Command;
using MoneyMe.Application.Tasks.Dto;
using MoneyMe.Application.Tasks.Queries;

namespace Money.Api.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : ApiController
    {

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateOrderCommand command)
        {

            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> GetAll()
        {
            return await Mediator.Send(new GetAllOrderQuery());
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<OrderDto>> Get(int id)
        {
            return await Mediator.Send(new GetOrderByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateOrderCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteOrderCommand { Id = id });
        }

    }
}
using AutoMapper;
using MoneyMe.Application.Tasks.Command;
using MoneyMe.Application.Tasks.Dto;
using MoneyMe.Core.Entities;

namespace MoneyMe.Application.Tasks.MappingProfiles
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<CreateOrderCommand, Core.Entities.Order>();
            CreateMap<Order, OrderDto>();
        }
    }
}

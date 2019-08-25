using AutoMapper;
using Inventory.API.Domain.Models;
using Inventory.API.Domain.Models.Queries;
using Inventory.API.Resources;

namespace Inventory.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<SaveProductResource, Product>()
                .ForMember(src => src.UnitOfMeasurement, opt => opt.MapFrom(src => (EUnitOfMeasurement)src.UnitOfMeasurement));

            CreateMap<ProductsQueryResource, ProductsQuery>();
        }
    }
}
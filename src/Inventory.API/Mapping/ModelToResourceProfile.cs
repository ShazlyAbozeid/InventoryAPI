using AutoMapper;
using Inventory.API.Domain.Models;
using Inventory.API.Domain.Models.Queries;
using Inventory.API.Extensions;
using Inventory.API.Resources;

namespace Inventory.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));

            CreateMap<QueryResult<Product>, QueryResultResource<Product>>();
        }
    }
}
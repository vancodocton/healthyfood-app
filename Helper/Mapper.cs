using asp_dotnet_core_healthyfood_app.Data;
using asp_dotnet_core_healthyfood_app.Models;
using AutoMapper;

namespace asp_dotnet_core_healthyfood_app.Helper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Category, CategoryModel>().ReverseMap();
            CreateMap<CategoryType,  CategoryTypeModel>().ReverseMap();
        }
    }
}

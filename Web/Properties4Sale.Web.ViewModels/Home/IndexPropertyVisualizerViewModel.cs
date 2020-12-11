namespace Properties4Sale.Web.ViewModels.Home
{
    using System.Linq;

    using AutoMapper;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Mapping;

    public class IndexPropertyVisualizerViewModel : IMapFrom<Property>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Location { get; set; }

        public string ImageUrl { get; set; }

        public string TypeOfPropertyName { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Property, IndexPropertyVisualizerViewModel>()
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x =>
                        x.Images.FirstOrDefault().RemoteImageUrl ?? "/images/properties/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}

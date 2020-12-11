namespace Properties4Sale.Web.ViewModels.Property
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Mapping;

    public class PropertiesDetailsViewModel : IMapFrom<Property>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string ImageUrl { get; set; }

        public int Price { get; set; }

        public string Area { get; set; }

        public int Beds { get; set; }

        public int Baths { get; set; }

        public int Garages { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public int TypeOfPropertyId { get; set; }

        public virtual TypeOfProperty TypeOfProperty { get; set; }

        public virtual ICollection<PropertyFeaturesViewModel> Features { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Property, PropertiesDetailsViewModel>()
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x =>
                        x.Images.FirstOrDefault().RemoteImageUrl ?? "/images/properties/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}

namespace Properties4Sale.Web.ViewModels.Blog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Mapping;

    public class VisualizeBlogViewModel : IMapFrom<Blog>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Category { get; set; }

        public DateTime Date { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ICollection<BlogImage> BlogImage { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Blog, VisualizeBlogViewModel>()
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x =>
                        x.BlogImages.FirstOrDefault().RemoteImageUrl ?? "/images/blogs/" + x.BlogImages.FirstOrDefault().Id + "." + x.BlogImages.FirstOrDefault().Extension));
        }
    }
}

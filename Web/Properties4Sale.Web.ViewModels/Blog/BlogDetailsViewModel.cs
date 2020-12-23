namespace Properties4Sale.Web.ViewModels.Blog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AutoMapper;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Mapping;

    public class BlogDetailsViewModel : IMapFrom<Blog>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SubName { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public string ImageUrl { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string AddedByUserId { get; set; }

        public double AverageVote { get; set; }

        public string Email { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<BlogImage> BlogImages { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Blog, BlogDetailsViewModel>()
                .ForMember(x => x.AverageVote, opt =>
                    opt.MapFrom(x => x.Votes.Count() == 0 ? 0 : x.Votes.Average(v => v.Value)))
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x =>
                        x.BlogImages.FirstOrDefault().RemoteImageUrl ?? "/images/blogs/" + x.BlogImages.FirstOrDefault().Id + "." + x.BlogImages.FirstOrDefault().Extension));
        }
    }
}

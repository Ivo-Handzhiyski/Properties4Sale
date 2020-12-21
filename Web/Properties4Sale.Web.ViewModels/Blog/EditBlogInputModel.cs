namespace Properties4Sale.Web.ViewModels.Blog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Properties4Sale.Services.Mapping;
    using Properties4Sale.Data.Models;

    public class EditBlogInputModel : IMapFrom<Blog>
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]

        public string SubName { get; set; }

        [Required]
        [MinLength(3)]

        public string Author { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MinLength(10)]

        public string Description { get; set; }
    }
}

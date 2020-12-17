namespace Properties4Sale.Web.ViewModels.Blog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;
    using Properties4Sale.Data.Models;

    public class CreateBlogInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string SubName { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Comment> Comment { get; set; }
    }
}

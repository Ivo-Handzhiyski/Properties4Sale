namespace Properties4Sale.Web.ViewModels.Blog
{
    using System;

    public class BlogCommentViewModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string AddedByUserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Email { get; set; }
    }
}

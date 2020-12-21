namespace Properties4Sale.Web.ViewModels.Blog
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BlogListViewModel
    {
        public IEnumerable<VisualizeBlogViewModel> Blogs { get; set; }

        public int PageNumber { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public bool HasNextPage => this.PagesCount < this.PagesCount;

        public int PagesCount => (int)Math.Ceiling((double)this.BlogsCount / this.ItemsPerPage);

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public int BlogsCount { get; set; }

        public int ItemsPerPage { get; set; }
    }
}

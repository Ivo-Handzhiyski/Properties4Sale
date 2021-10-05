namespace Properties4Sale.Web.ViewModels.Property
{
    using System;
    using System.Collections.Generic;

    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;

    public class PropertiesListViewModel
    {
        public IEnumerable<VisualisePropertiesViewModel> Properties { get; set; }

        private readonly IDeletableEntityRepository<Property> propertiesRepository;

        public int PageNumber { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public bool HasNextPage => this.PagesCount < this.PagesCount;

        public int PagesCount => (int)Math.Ceiling((double)this.PropertiesCount / this.ItemsPerPage);

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public int PropertiesCount { get; set; }

        public int ItemsPerPage { get; set; }

        public string SearchTerm { get; set; }
    }
}

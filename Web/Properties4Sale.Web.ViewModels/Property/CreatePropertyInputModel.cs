namespace Properties4Sale.Web.ViewModels.Property
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Http;

    public class CreatePropertyInputModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        [MinLength(20)]
        public string Description { get; set; }

        [Required]
        [MinLength(3)]
        public string Location { get; set; }

        public int Price { get; set; }

        public int TypeOfPropertyId { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }

        public IEnumerable<PropertyFeatureInputModel> Features { get; set; }

        public IEnumerable<KeyValuePair<string, string>> TypeOfPropertiesItems { get; set; }
    }
}

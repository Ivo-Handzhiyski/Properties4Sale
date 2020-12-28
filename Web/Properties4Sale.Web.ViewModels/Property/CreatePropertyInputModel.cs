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

        [Required]
        [MinLength(5)]
        public string Address { get; set; }

        public int Price { get; set; }

        [Required]
        public string Area { get; set; }

        [Required]
        public int Beds { get; set; }

        [Required]
        public int Baths { get; set; }

        [Required]
        public int Garages { get; set; }

        public int TypeOfPropertyId { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }


        public IEnumerable<KeyValuePair<string, string>> TypeOfPropertiesItems { get; set; }
    }
}

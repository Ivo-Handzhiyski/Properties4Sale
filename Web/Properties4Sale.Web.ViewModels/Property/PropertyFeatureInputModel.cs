namespace Properties4Sale.Web.ViewModels.Property
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class PropertyFeatureInputModel
    {
        public int Bedrooms { get; set; }

        public int Floors { get; set; }

        [MinLength(5)]
        public string HeatingSystem { get; set; }

        [MinLength(2)]
        public string Garden { get; set; }

        public int Area { get; set; }

        [MinLength(3)]
        public string Condition { get; set; }

        [MinLength(3)]
        public string Furnishing { get; set; }

        public int YearOfConstruction { get; set; }
    }
}

namespace Properties4Sale.Data.Models
{
    using System.Collections.Generic;

    public class Feature
    {
        public Feature()
        {
            this.Properties = new HashSet<PropertyFeature>();
        }

        public int Id { get; set; }

        public int Bedrooms { get; set; }

        public int Floors { get; set; }

        public string HeatingSystem { get; set; }

        public string Garden { get; set; }

        public int Area { get; set; }

        public string Condition { get; set; }

        public string Furnishing { get; set; }

        public int YearOfConstruction { get; set; }

        public virtual ICollection<PropertyFeature> Properties { get; set; }
    }
}

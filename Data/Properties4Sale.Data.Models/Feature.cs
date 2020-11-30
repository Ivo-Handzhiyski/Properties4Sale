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

        public bool HeatingSystem { get; set; }

        public bool Garden { get; set; }

        public bool Furnishing { get; set; }

        public bool Basement { get; set; }

        public bool Balcony { get; set; }

        public bool CarGarage { get; set; }

        public bool Parking { get; set; }

        public bool StunningView { get; set; }

        public virtual ICollection<PropertyFeature> Properties { get; set; }
    }
}

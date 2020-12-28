namespace Properties4Sale.Data.Models
{
    using System.Collections.Generic;

    using Properties4Sale.Data.Common.Models;

    public class Property : BaseDeletableModel<int>
    {
        public Property()
        {
            this.Images = new HashSet<Image>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Address { get; set; }

        public int Price { get; set; }

        public string Area { get; set; }

        public int Beds { get; set; }

        public int Baths { get; set; }

        public int Garages { get; set; }

        public bool IsSold { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public int TypeOfPropertyId { get; set; }

        public virtual TypeOfProperty TypeOfProperty { get; set; }


        public virtual ICollection<Image> Images { get; set; }
    }
}

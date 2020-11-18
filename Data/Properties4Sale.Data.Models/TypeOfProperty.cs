namespace Properties4Sale.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Properties4Sale.Data.Common.Models;

    public class TypeOfProperty : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}

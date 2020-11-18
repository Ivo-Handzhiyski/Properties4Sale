namespace Properties4Sale.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Properties4Sale.Data.Common.Models;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int PropertyId { get; set; }

        public virtual Property Property { get; set; }

        public string AddedByUserid { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public string Extension { get; set; }
    }
}

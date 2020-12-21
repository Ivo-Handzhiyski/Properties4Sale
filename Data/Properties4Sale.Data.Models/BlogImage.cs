namespace Properties4Sale.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Properties4Sale.Data.Common.Models;

    public class BlogImage : BaseModel<string>
    {
        public BlogImage()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }

        public string RemoteImageUrl { get; set; }

        public string AddedByUserid { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public string Extension { get; set; }
    }
}

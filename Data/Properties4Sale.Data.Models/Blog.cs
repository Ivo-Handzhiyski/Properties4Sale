namespace Properties4Sale.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Properties4Sale.Data.Common.Models;

    public class Blog : BaseDeletableModel<int>
    {
        public Blog()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Name { get; set; }

        public string SubName { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}

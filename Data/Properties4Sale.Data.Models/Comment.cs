namespace Properties4Sale.Data.Models
{
    using Properties4Sale.Data.Common.Models;
    using System;

    public class Comment : BaseDeletableModel<int>
    {
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }
    }
}

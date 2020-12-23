namespace Properties4Sale.Data.Models
{
    using Properties4Sale.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public virtual Blog Blog { get; set; }

        public int BlogId { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public byte Value { get; set; }
    }
}

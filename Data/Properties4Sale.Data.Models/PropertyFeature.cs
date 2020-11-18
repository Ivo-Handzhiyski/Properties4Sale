namespace Properties4Sale.Data.Models
{
    using Properties4Sale.Data.Common.Models;

    public class PropertyFeature
    {
        public int Id { get; set; }

        public int PropertyId { get; set; }

        public virtual Property Property { get; set; }

        public int FeatureId { get; set; }

        public virtual Feature Feature { get; set; }
    }
}

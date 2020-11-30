namespace Properties4Sale.Web.ViewModels.Property
{
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Mapping;

    public class PropertyFeaturesViewModel : IMapFrom<PropertyFeature>
    {
        public bool HeatingSystem { get; set; }

        public bool Garden { get; set; }

        public bool Furnishing { get; set; }

        public bool Basement { get; set; }

        public bool Balcony { get; set; }

        public bool CarGarage { get; set; }

        public bool Parking { get; set; }

        public bool StunningView { get; set; }
    }
}

namespace Properties4Sale.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using Properties4Sale.Web.ViewModels.Property;

    public class IndexViewModel
    {
        public int PropertiesCount { get; set; }

        public int TypesOfPropertiesCount { get; set; }

        public IEnumerable<IndexPropertyVisualizerViewModel> VisualiseProperties { get; set; }

        public IEnumerable<IndexPropertyVisualizerViewModel> VisualisePropertiesRandom { get; set; }
    }
}

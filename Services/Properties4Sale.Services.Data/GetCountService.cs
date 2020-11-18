namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Data.Models;
    using Properties4Sale.Web.ViewModels.Home;

    public class GetCountService : IGetCountService
    {
        private readonly IDeletableEntityRepository<TypeOfProperty> typeOfPropertiesRepository;
        private readonly IRepository<Feature> featuresRepository;
        private readonly IRepository<Image> imagesRepository;
        private readonly IDeletableEntityRepository<Property> propertiesRepository;

        public GetCountService(
            IDeletableEntityRepository<TypeOfProperty> typeOfPropertiesRepository,
            IRepository<Feature> featuresRepository,
            IRepository<Image> imagesRepository,
            IDeletableEntityRepository<Property> propertiesRepository)
        {
            this.typeOfPropertiesRepository = typeOfPropertiesRepository;
            this.featuresRepository = featuresRepository;
            this.imagesRepository = imagesRepository;
            this.propertiesRepository = propertiesRepository;
        }

        public CountsDto GetCounts()
        {
            var data = new CountsDto
            {
                PropertiesCount = this.propertiesRepository.All().Count(),
                TypesOfPropertiesCount = this.typeOfPropertiesRepository.All().Count(),
            };

            return data;
        }
    }
}

namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Web.ViewModels.Property;

    public class PropertiesService : IPropertiesService
    {
        private readonly IDeletableEntityRepository<Property> propertiesRepository;
        private readonly IRepository<Feature> featuresRepository;

        public PropertiesService(
            IDeletableEntityRepository<Property> propertiesRepository,
            IRepository<Feature> featuresRepository)
        {
            this.propertiesRepository = propertiesRepository;
            this.featuresRepository = featuresRepository;
        }

        public async Task CreateAsync(CreatePropertyInputModel input, string userId)
        {
            var property = new Property
            {
                TypeOfPropertyId = input.TypeOfPropertyId,
                Name = input.Name,
                Description = input.Description,
                Location = input.Location,
                Price = input.Price,
                AddedByUserId = userId,
            };

            await this.propertiesRepository.AddAsync(property);
            await this.propertiesRepository.SaveChangesAsync();
        }
    }
}

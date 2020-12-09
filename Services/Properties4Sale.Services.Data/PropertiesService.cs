namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Hosting;

    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Mapping;
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

        public async Task CreateAsync(CreatePropertyInputModel input, string userId, string imagePath)
        {
            var property = new Property
            {
                TypeOfPropertyId = input.TypeOfPropertyId,
                Name = input.Name,
                Description = input.Description,
                Location = input.Location,
                Price = input.Price,
                Area = input.Area,
                Baths = input.Baths,
                Beds = input.Beds,
                Garages = input.Garages,
                AddedByUserId = userId,
            };

            foreach (var propertyFeature in input.Features)
            {
               
            }

            var allowedExtensions = new[] { "jpg", "png", "gif" };

            Directory.CreateDirectory($"{imagePath}/properties");

            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');

                if (!allowedExtensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid Image Extension {extension}");
                }

                var dbImage = new Image
                {
                    AddedByUserid = userId,
                    Extension = extension,
                };
                property.Images.Add(dbImage);

                var phycicalPath = $"{imagePath}/properties/{dbImage.Id}.{extension}";

                using Stream fileStream = new FileStream(phycicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            await this.propertiesRepository.AddAsync(property);
            await this.propertiesRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            var recipes = this.propertiesRepository.AllAsNoTracking()
             .OrderByDescending(x => x.Id)
             .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
             .To<T>()
             .ToList();

            return recipes;
        }

        public T GetById<T>(int id)
        {
            var property = this.propertiesRepository.AllAsNoTracking().Where(x => x.Id == id)
            .To<T>().FirstOrDefault();

            return property;
        }

        public int GetCount()
        {
            return this.propertiesRepository.All().Count();
        }
    }
}

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

        public PropertiesService(
            IDeletableEntityRepository<Property> propertiesRepository)
        {
            this.propertiesRepository = propertiesRepository;
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
                Address = input.Address,
            };

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

        public async Task DeleteAsync(int id)
        {
            var property = this.propertiesRepository.All().FirstOrDefault(x => x.Id == id);
            this.propertiesRepository.Delete(property);
            await this.propertiesRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 6)
        {
            var properties = this.propertiesRepository.AllAsNoTracking()
             .OrderByDescending(x => x.Id)
             .Skip((page - 1) * itemsPerPage)
             .Take(itemsPerPage)
             .To<T>()
             .ToList();

            return properties;
        }

        public IEnumerable<T> GetAllBySearch<T>(int page, int itemsPerPage = 6)
        {
            var properties = this.propertiesRepository.AllAsNoTracking()
            .OrderByDescending(x => x.Id)
            .Skip((page - 1) * itemsPerPage)
            .Take(itemsPerPage)
            .To<T>()
            .ToList();

            return properties;
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

        public IEnumerable<T> GetProperties<T>(int count)
        {
            var property = this.propertiesRepository.All().OrderByDescending(x => x.Id).Take(count).To<T>().ToList();

            return property;
        }

        public IEnumerable<T> GetAllBySearch<T>(string SearchTerm, int page, int itemsPerPage = 12)
        {
            if (string.IsNullOrEmpty(SearchTerm))
            {
                return this.propertiesRepository.All().To<T>().ToList();
            }

            return this.propertiesRepository.All().Where(x => x.Name.Contains(SearchTerm)).To<T>().ToList();
        }

        public IEnumerable<T> GetPropertiesRandom<T>(int count)
        {
            var property = this.propertiesRepository.All().OrderBy(x => Guid.NewGuid()).Take(count).To<T>().ToList();

            return property;
        }

        public IEnumerable<T> GetPropertiesForUser<T>(string userId, int page, int itemsPerPage = 12)
        {
            var property = this.propertiesRepository
              .AllAsNoTracking()
              .Where(x => x.AddedByUserId == userId)
              .OrderByDescending(x => x.Id)
              .Skip((page - 1) * itemsPerPage)
              .Take(itemsPerPage)
              .To<T>()
              .ToList();

            return property;
        }

        public async Task UpdateAsync(int id, EditPropertyInputModel input)
        {
            var property = this.propertiesRepository.All().FirstOrDefault(x => x.Id == id);
            property.Name = input.Name;
            property.Description = input.Description;
            property.Location = input.Location;
            property.Price = input.Price;
            property.Area = input.Area;
            property.Baths = input.Baths;
            property.Beds = input.Beds;
            property.Garages = input.Garages;
            property.TypeOfPropertyId = input.TypeOfPropertyId;
            property.Address = input.Address;

            await this.propertiesRepository.SaveChangesAsync();
        }

       
    }
}

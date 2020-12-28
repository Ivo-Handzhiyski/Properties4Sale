namespace Properties4Sale.Services.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Moq;
    using Properties4Sale.Data;
    using Properties4Sale.Data.Common;
    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Data.Repositories;
    using Properties4Sale.Services.Data;
    using Properties4Sale.Services.Data.Tests;
    using Properties4Sale.Services.Mapping;
    using Properties4Sale.Web.ViewModels.Property;
    using Xunit;

    public class PropertiesServiceTests : TestBase
    {
        private readonly Mock<IDeletableEntityRepository<Property>> propertiesRepository;


        public PropertiesServiceTests()
        {
            this.propertiesRepository = new Mock<IDeletableEntityRepository<Property>>();

        }

        [Fact]
        public async Task AddPropertiesShouldWorkCorrectly()
        {

            var db = GetDatabase();
            var property = new CreatePropertyInputModel()
            {
                Name = "Name",
            };
            var propertiesRepository = new EfDeletableEntityRepository<Property>(db);

            var service = new PropertiesService(propertiesRepository);

            await db.SaveChangesAsync();

            Assert.Equal(1, db.Properties.Count());
        }

        [Fact]
        public async Task GetCountShouldReturnTheCorrectAmountOfProperties()
        {
            var db = GetDatabase();
            var property = new Property()
            {
                Name = "Name",
            };
            var propertiesRepository = new EfDeletableEntityRepository<Property>(db);

            var service = new PropertiesService(propertiesRepository);

            await db.Properties.AddAsync(property);
            await db.SaveChangesAsync();

            Assert.Equal(1, service.GetCount());
        }

        [Fact]
        public async Task GetByIdShouldWorkCorretly()
        {
            AutoMapperConfig.RegisterMappings(typeof(VisualisePropertiesViewModel).Assembly);

            var db = GetDatabase();
            var property = new Property()
            {
                Id = 1,
                Name = "Name",
            }; 
            var property2 = new Property()
            {
                Id = 2,
                Name = "Name",
            };

            var propertiesRepository = new EfDeletableEntityRepository<Property>(db);

            var service = new PropertiesService(propertiesRepository);

            await db.Properties.AddAsync(property);
            await db.SaveChangesAsync();

            var lol = service.GetById<VisualisePropertiesViewModel>(1);
            Assert.Equal(1, lol.Id);
        }

        [Fact]
        public async Task DeleteShouldWorkCorretly()
        {
            var db = GetDatabase();
            var property = new Property()
            {
                Id = 1,
                Name = "Name",
            };

            var propertiesRepository = new EfDeletableEntityRepository<Property>(db);

            var service = new PropertiesService(propertiesRepository);

            await db.Properties.AddAsync(property);
            await db.SaveChangesAsync();

            var lol = service.DeleteAsync(1);

            Assert.Equal(0, propertiesRepository.All().Count());
        }

        [Fact]
        public async Task GetAllShouldWorkProperly()
        {
            var db = GetDatabase();
            AutoMapperConfig.RegisterMappings(typeof(VisualisePropertiesViewModel).Assembly);
            var property = new Property()
            {
                Id = 2,
                Name = "Name",
            };
            var property2 = new Property()
            {
                Id = 1,
                Name = "Name",
            };
            var propertiesRepository = new EfDeletableEntityRepository<Property>(db);

            var service = new PropertiesService(propertiesRepository);

            await db.Properties.AddAsync(property);
            await db.Properties.AddAsync(property2);
            await db.SaveChangesAsync();

            var lol = service.GetAll<VisualisePropertiesViewModel>(1);

            Assert.Equal(property.Id, lol.FirstOrDefault().Id);
        }

        [Fact]
        public async Task GetPropertiesForUserShouldReturnOnlyPropertiesThatBelongsToTheUser()
        {

            var db = GetDatabase();
            AutoMapperConfig.RegisterMappings(typeof(VisualisePropertiesViewModel).Assembly);
            var property = new Property()
            {
                Id = 1,
                Name = "Name",
            };
            var property2 = new Property()
            {
                Id = 2,
                Name = "Name",
            };
            var property3 = new Property()
            {
                Id = 3,
                Name = "Name",
            };
            var propertiesRepository = new EfDeletableEntityRepository<Property>(db);

            var service = new PropertiesService(propertiesRepository);
            await db.Properties.AddRangeAsync(property, property2, property3);
            await db.SaveChangesAsync();

            var lol = service.GetProperties<VisualisePropertiesViewModel>(2);

            Assert.Equal(2, lol.Count());
        }

        [Fact]
        public async Task EditPropertiesShouldEditCorretly()
        {
            var db = GetDatabase();
            var propertyRepository = new EfDeletableEntityRepository<Property>(db);

            var service = new PropertiesService(propertyRepository);

            var property = new Property()
            {
                Id = 1,
                Name = "Name",
                Description = "Description",
                Location = "Location",
                Address = "Address",
                Area = "Area",
                Price = 1,
                Baths = 1,
                Beds = 1,
                Garages = 1,

            };
            AutoMapperConfig.RegisterMappings(typeof(EditPropertyInputModel).Assembly);

            var propertyEdit = new Web.ViewModels.Property.EditPropertyInputModel()
            {
                Id = 1,
                Name = "Name2",
                Description = "Description2",
                Location = "Location2",
                Address = "Address2",
                Area = "Area2",
                Price = 2,
                Baths = 2,
                Beds = 2,
                Garages = 2,

            };

            await db.Properties.AddAsync(property);
            await db.SaveChangesAsync();

            await service.UpdateAsync(1, propertyEdit);

            Assert.Equal("Name2", property.Name);
            Assert.Equal("Description2", property.Description);
            Assert.Equal("Location2", property.Location);
            Assert.Equal("Address2", property.Address);
            Assert.Equal("Area2", property.Area);
            Assert.Equal(2, property.Price);
            Assert.Equal(2, property.Baths);
            Assert.Equal(2, property.Beds);
            Assert.Equal(2, property.Garages);
        }

        public class VisualisePropertiesViewModel: IMapFrom<Property>
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        public class EditPropertyInputModel : IMapFrom<Property>
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string Location { get; set; }

            public string Address { get; set; }

            public int Price { get; set; }

            public string Area { get; set; }

            public int Beds { get; set; }

            public int Baths { get; set; }

            public int Garages { get; set; }
        }
    }
}

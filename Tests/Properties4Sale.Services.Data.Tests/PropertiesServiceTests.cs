namespace Properties4Sale.Services.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Moq;
    using Properties4Sale.Data.Common;
    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Data.Repositories;
    using Properties4Sale.Services.Data;
    using Properties4Sale.Web.ViewModels.Property;
    using Xunit;

    public class PropertiesServiceTests
    {
        private readonly IDeletableEntityRepository<Property> propertyRepository;

        public PropertiesServiceTests()
        {
        }

        [Fact]
        public async Task AddPropertiesAsyncShouldWorkCorrectly()
        {
            var mock = new Mock<IDeletableEntityRepository<Property>>();

            var propertiesService = new PropertiesService((IDeletableEntityRepository<Property>)this.propertyRepository);
            var property = new Property();
            var propertyModel = new CreatePropertyInputModel()
            {
              Name = "Name",
              Description = "Description",
              Location = "Location",
              Price = 1000,
              Area = "Area",
              Baths = 1,
              Garages = 1,
              Beds = 1,
              Address = "Address",
            };

            await propertiesService.CreateAsync(propertyModel, "511f7e5a-cec9-40d1-8fc7-1378a4fac3c6", "511f7e5a-cec9-40d1-8fc7-1378a4fac3c6");

            Assert.Equal("Name", propertyModel.Name);

            Assert.Equal("Description", propertyModel.Description);

            Assert.Equal("Location", propertyModel.Location);

            Assert.Equal(1000, propertyModel.Price);

            Assert.Equal("Area", propertyModel.Area);

            Assert.Equal(1, propertyModel.Baths);

            Assert.Equal(1, propertyModel.Garages);

            Assert.Equal(1, propertyModel.Beds);

            Assert.Equal("Address", propertyModel.Address);
        }
    }
}

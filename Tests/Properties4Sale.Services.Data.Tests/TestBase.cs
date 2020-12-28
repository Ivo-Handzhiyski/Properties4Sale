namespace Properties4Sale.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Properties4Sale.Data;
    using Properties4Sale.Services.Mapping;
    using Properties4Sale.Web.ViewModels.Property;

    public class TestBase
    {
        public TestBase()
        {
            new MapperInitializationProfile();
        }

        public static ApplicationDbContext GetDatabase()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var db = new ApplicationDbContext(options);

            return db;
        }
    }
}

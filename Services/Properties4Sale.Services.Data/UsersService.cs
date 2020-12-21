namespace Properties4Sale.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Mapping;

    public class UsersService : IUsersServices
    {
        private readonly IDeletableEntityRepository<Property> propertiesRepository;

        public UsersService(IDeletableEntityRepository<Property> propertiesRepository)
        {
            this.propertiesRepository = propertiesRepository;
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
    }
}

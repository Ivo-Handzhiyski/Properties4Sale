namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;

    public class TypeOfPropertiesService : ITypeOfPropertiesService
    {
        private readonly IDeletableEntityRepository<TypeOfProperty> typeOfPropertiesRepository;

        public TypeOfPropertiesService(IDeletableEntityRepository<TypeOfProperty> typeOfPropertiesRepository)
        {
            this.typeOfPropertiesRepository = typeOfPropertiesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllKeyValuePairs()
        {
            return this.typeOfPropertiesRepository.All().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}

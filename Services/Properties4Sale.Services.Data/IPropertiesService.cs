namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using Properties4Sale.Web.ViewModels.Property;

    public interface IPropertiesService
    {
        Task CreateAsync(CreatePropertyInputModel input, string userId, string imagePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        IEnumerable<T> GetProperties<T>(int count);

        int GetCount();

        T GetById<T>(int id);
    }
}

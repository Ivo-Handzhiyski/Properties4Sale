namespace Properties4Sale.Services.Data
{
    using Properties4Sale.Web.ViewModels.Property;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBlogsService
    {
        Task CreateAsync(CreatePropertyInputModel input, string userId, string imagePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        IEnumerable<T> GetProperties<T>(int count);

        IEnumerable<T> GetPropertiesRandom<T>(int count);

        int GetCount();

        T GetById<T>(int id);

        Task UpdateAsync(int id, EditPropertyInputModel input);
    }
}

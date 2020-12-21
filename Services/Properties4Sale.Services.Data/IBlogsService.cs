namespace Properties4Sale.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Properties4Sale.Web.ViewModels.Blog;
    using Properties4Sale.Web.ViewModels.Property;

    public interface IBlogsService
    {
        Task CreateAsync(CreateBlogInputModel input, string userId, string imagePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        IEnumerable<T> GetBlogs<T>(int count);

        T GetById<T>(int id);

        Task DeleteAsync(int id);

        int GetCount();

        Task UpdateAsync(int id, EditBlogInputModel input);
    }
}

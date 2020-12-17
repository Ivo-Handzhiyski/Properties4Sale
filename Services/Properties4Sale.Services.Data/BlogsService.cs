namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Web.ViewModels.Blog;
    using Properties4Sale.Web.ViewModels.Property;

    public class BlogsService : IBlogsService
    {
        private readonly IBlogsService blogsService;
        private readonly IDeletableEntityRepository<Blog> blogRepository;

        public BlogsService(IDeletableEntityRepository<Blog> blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        public async Task CreateAsync(CreateBlogInputModel input, string userId)
        {
            var blog = new Blog
            {
                Name = input.Name,
                SubName = input.SubName,
                Author = input.Author,
                Category = input.Category,
                Date = input.Date,
                Description = input.Description,
                AddedByUserId = userId,
            };

            await this.blogRepository.AddAsync(blog);
            await this.blogRepository.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetBlogs<T>(int count)
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, EditPropertyInputModel input)
        {
            throw new NotImplementedException();
        }
    }
}

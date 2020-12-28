namespace Properties4Sale.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Moq;
    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Data.Repositories;
    using Properties4Sale.Services.Mapping;
    using Properties4Sale.Web.ViewModels.Blog;
    using Xunit;

    public class BlogServiceTests : TestBase
    {
        private readonly Mock<IDeletableEntityRepository<Blog>> blogsRepository;

        public BlogServiceTests()
        {
            this.blogsRepository = new Mock<IDeletableEntityRepository<Blog>>();
        }

        [Fact]
        public async Task DeleteShouldWorkCorretly()
        {
            var db = GetDatabase();

            var blogsRepository = new EfDeletableEntityRepository<Blog>(db);

            var service = new BlogsService(blogsRepository);
            var blog = new Blog()
            {
                Id = 1,
                Name = "Name",
            };

            await db.Blogs.AddAsync(blog);
            await db.SaveChangesAsync();

            await service.DeleteAsync(1);

            Assert.Equal(0, db.Blogs.Count());
        }

        [Fact]
        public async Task GetCountShouldWorkCorretly()
        {
            var db = GetDatabase();
            var blogsRepository = new EfDeletableEntityRepository<Blog>(db);

            var service = new BlogsService(blogsRepository);

            var blog = new Blog()
            {
                Id = 1,
                Name = "Name",
            };
            var blog2 = new Blog()
            {
                Id = 2,
                Name = "Name",
            };
            var blog3 = new Blog()
            {
                Id = 3,
                Name = "Name",
            };

            await db.Blogs.AddRangeAsync(blog, blog2, blog3);
            await db.SaveChangesAsync();
            Assert.Equal(3, service.GetCount());
        }

        [Fact]
        public async Task GetByIdShouldWorkCorrectly()
        {
            var db = GetDatabase();
            var blogsRepository = new EfDeletableEntityRepository<Blog>(db);

            var service = new BlogsService(blogsRepository);

            var blog2 = new Blog()
            {
                Id = 2,
                Name = "Name",
            };

            await db.Blogs.AddAsync(blog2);
            await db.SaveChangesAsync();

            AutoMapperConfig.RegisterMappings(typeof(BlogDetailsViewModel).Assembly);

            var lol = service.GetById<BlogDetailsViewModel>(2);

            Assert.Equal(2, lol.Id);
        }

        [Fact]

        public async Task EditBlogShouldEditProperly()
        {
            var db = GetDatabase();
            var blogsRepository = new EfDeletableEntityRepository<Blog>(db);

            var service = new BlogsService(blogsRepository);

            var blog = new Blog()
            {
                Id = 1,
                Name = "Name",
                Description = "Description",
                SubName = "SubName",
                Category = "Category",
                Author = "Author",
            };
            AutoMapperConfig.RegisterMappings(typeof(EditBlogInputModel).Assembly);

            var blogEdit = new Web.ViewModels.Blog.EditBlogInputModel()
            {
                Id = 1,
                Name = "Name2",
                Description = "Description2",
                SubName = "SubName2",
                Category = "Category2",
                Author = "Author2",
            };

            await db.Blogs.AddAsync(blog);
            await db.SaveChangesAsync();

            await service.UpdateAsync(1, blogEdit);

            Assert.Equal("Name2", blog.Name);
            Assert.Equal("Description2", blog.Description);
            Assert.Equal("SubName2", blog.SubName);
            Assert.Equal("Category2", blog.Category);
            Assert.Equal("Author2", blog.Author);
        }

        [Fact]
        public async Task GetAllBlogsShouldReturnEveryBlog()
        {
            var db = GetDatabase();
            var blogsRepository = new EfDeletableEntityRepository<Blog>(db);

            var service = new BlogsService(blogsRepository);

            var blog = new Blog()
            {
                Id = 1,
                Name = "Name",
                Description = "Description",
                SubName = "SubName",
                Category = "Category",
                Author = "Author",
            };
            var blog2 = new Blog()
            {
                Id = 2,
                Name = "Name",
                Description = "Description",
                SubName = "SubName",
                Category = "Category",
                Author = "Author",
            };
            var blog3 = new Blog()
            {
                Id = 3,
                Name = "Name",
                Description = "Description",
                SubName = "SubName",
                Category = "Category",
                Author = "Author",
            };

            await db.Blogs.AddRangeAsync(blog, blog2, blog3);
            await db.SaveChangesAsync();

            var getAll = service.GetAll<BlogDetailsViewModel>(1);

            Assert.Equal(3, getAll.Count());
        }

        [Fact]
        public async Task GetBlogsShouldReturnTheExactNumberOfBlogs()
        {
            var db = GetDatabase();
            var blogsRepository = new EfDeletableEntityRepository<Blog>(db);

            var service = new BlogsService(blogsRepository);

            var blog = new Blog()
            {
                Id = 1,
                Name = "Name",
                Description = "Description",
                SubName = "SubName",
                Category = "Category",
                Author = "Author",
            };
            var blog2 = new Blog()
            {
                Id = 2,
                Name = "Name",
                Description = "Description",
                SubName = "SubName",
                Category = "Category",
                Author = "Author",
            };
            var blog3 = new Blog()
            {
                Id = 3,
                Name = "Name",
                Description = "Description",
                SubName = "SubName",
                Category = "Category",
                Author = "Author",
            };

            await db.Blogs.AddRangeAsync(blog, blog2, blog3);
            await db.SaveChangesAsync();

            var getBlogs = service.GetBlogs<BlogDetailsViewModel>(2);

            Assert.Equal(2, getBlogs.Count());
            Assert.Equal(1, getBlogs.FirstOrDefault().Id);
        }

        public class BlogDetailsViewModel : IMapFrom<Blog>
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        public class EditBlogInputModel : IMapFrom<Blog>
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string SubName { get; set; }

            public string Category { get; set; }

            public string Author { get; set; }
        }

    }
}

namespace Properties4Sale.Services.Data
{
    using System;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;
    using Properties4Sale.Services.Data;
    using Properties4Sale.Web.ViewModels.Blog;

    public class CommentService : ICommentService
    {
        private readonly IDeletableEntityRepository<Comment> commentsRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public CommentService(IDeletableEntityRepository<Comment> commentsRepository, UserManager<ApplicationUser> userManager)
        {
            this.commentsRepository = commentsRepository;
            this.userManager = userManager;
        }

        public async Task AddCommentAsync(string content, int blogId, string userId, string email)
        {
            var comment = new Comment
            {
                Content = content,
                BlogId = blogId,
                AddedByUserId = userId,
                Name = email,
            };

            await this.commentsRepository.AddAsync(comment);
            await this.commentsRepository.SaveChangesAsync();
        }

        public async Task<bool> DeleteCommentAsync(int id, string userId)
        {
            var comment = this.commentsRepository.All().FirstOrDefault(x => x.Id == id);

            if (userId != comment.AddedByUserId)
            {
                return false;
            }

            this.commentsRepository.Delete(comment);
            await this.commentsRepository.SaveChangesAsync();
            return true;
        }
    }
}

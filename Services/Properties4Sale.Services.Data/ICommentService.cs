namespace Properties4Sale.Services.Data
{
    using System.Threading.Tasks;

    public interface ICommentService
    {
        Task AddCommentAsync(string content, int blogId, string userId, string email);

        Task<bool> DeleteCommentAsync(int id, string userId);
    }
}

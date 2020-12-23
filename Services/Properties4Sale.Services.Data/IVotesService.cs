namespace Properties4Sale.Services.Data
{
    using System.Threading.Tasks;

    public interface IVotesService
    {
        Task SetVoteAsync(int blogId, string userId, byte value);

        double GetAverageVotes(int blogId);
    }
}

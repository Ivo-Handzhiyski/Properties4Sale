namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Properties4Sale.Data.Common.Repositories;
    using Properties4Sale.Data.Models;

    public class VotesService : IVotesService
    {
        private readonly IRepository<Vote> votesRepository;

        public VotesService(IRepository<Vote> votesRepository)
        {
            this.votesRepository = votesRepository;
        }

        public double GetAverageVotes(int blogId)
        {
            var averageVotes = this.votesRepository.All().Where(x => x.BlogId == blogId).Average(x => x.Value);

            return averageVotes;
        }

        public async Task SetVoteAsync(int blogId, string userId, byte value)
        {
            var vote = this.votesRepository.All().FirstOrDefault(x => x.BlogId == blogId && x.UserId == userId);
            if (vote == null)
            {
                vote = new Vote
                {
                    UserId = userId,
                    BlogId = blogId,
                };

                await this.votesRepository.AddAsync(vote);
            }
            vote.Value = value;
            await this.votesRepository.SaveChangesAsync();
        }
    }
}

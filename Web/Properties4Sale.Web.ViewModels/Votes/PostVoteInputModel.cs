namespace Properties4Sale.Web.ViewModels.Votes
{
    using System.ComponentModel.DataAnnotations;

    public class PostVoteInputModel
    {
        public int BlogId { get; set; }

        [Range(1, 5)]
        public byte Value { get; set; }
    }
}

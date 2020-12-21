namespace Properties4Sale.Services.Data
{
    using System.Collections.Generic;

    public interface IUsersServices
    {
        IEnumerable<T> GetPropertiesForUser<T>(string userId, int page, int itemsPerPage = 12);
    }
}

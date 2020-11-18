namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Properties4Sale.Services.Data.Models;
    using Properties4Sale.Web.ViewModels.Home;

    public interface IGetCountService
    {
        CountsDto GetCounts();
    }
}

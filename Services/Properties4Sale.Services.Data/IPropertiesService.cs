namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using Properties4Sale.Web.ViewModels.Property;

    public interface IPropertiesService
    {
        Task CreateAsync(CreatePropertyInputModel input);
    }
}

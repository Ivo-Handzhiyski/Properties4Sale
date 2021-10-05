﻿namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using Properties4Sale.Web.ViewModels.Property;

    public interface IPropertiesService
    {
        Task CreateAsync(CreatePropertyInputModel input, string userId, string imagePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        IEnumerable<T> GetAllBySearch<T>(string SearchTerm, int page, int itemsPerPage = 12);

        IEnumerable<T> GetProperties<T>(int count);

        IEnumerable<T> GetPropertiesRandom<T>(int count);

        IEnumerable<T> GetPropertiesForUser<T>(string userId, int page, int itemsPerPage = 12);

        int GetCount();

        T GetById<T>(int id);

        Task UpdateAsync(int id, EditPropertyInputModel input);

        Task DeleteAsync(int id);
    }
}

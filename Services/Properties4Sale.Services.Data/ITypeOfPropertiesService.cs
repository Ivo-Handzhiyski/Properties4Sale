namespace Properties4Sale.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ITypeOfPropertiesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllKeyValuePairs();
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace XamarinClient_ApiAzure.Services
{
    using System.Threading.Tasks;
    public interface IDataUser<T>
    {
        Task<IEnumerable<T>> GetUserAsync(bool forceRefresh = false);
    }
}

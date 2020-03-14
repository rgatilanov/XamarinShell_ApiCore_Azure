using System;
using System.Collections.Generic;
using System.Text;


namespace XamarinClient_ApiAzure.Services
{
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Threading.Tasks;
    using XamarinClient_ApiAzure.Models;
    public class UserData : IDataUser<User>
    {
        HttpClient client; 
        public string WebAPUrl { get; private set; }
        List<User> items;

        public UserData()
        {
            client = new HttpClient();
        }

        public async Task<IEnumerable<User>> GetUserAsync(bool forceRefresh = false)
        {
            WebAPUrl = "https://loquesea.azurewebsites.net/api/control";

            var uri = new Uri(WebAPUrl);
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<List<User>>(content);
                }
            }
            catch (Exception)
            {
            }
            
            return await Task.FromResult(items);
        }
    }
}

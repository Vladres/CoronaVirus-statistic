using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NovodApp.ViewModel;

namespace NovodApp
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<SearchVM> GetInfoData(string uri)
        {
            SearchVM itemData = null;
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    itemData = JsonConvert.DeserializeObject<SearchVM>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }
            return itemData;
        }
        public async Task<MainPageVM> GetInfo(string uri)
        {
            MainPageVM itemData = null;
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    itemData = JsonConvert.DeserializeObject<MainPageVM>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }
            return itemData;
        }
    }
}
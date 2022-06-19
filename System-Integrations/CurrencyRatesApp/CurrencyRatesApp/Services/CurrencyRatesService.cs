using CurrencyRatesApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRatesApp.Services
{
    public class CurrencyRatesService
    {
        private HttpClient _httpClient;

        public CurrencyRatesService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<TestModel>> GetExchangeRates(string date)
        {
            //string url = "http://www.lb.lt/webservices/ExchangeRates/ExchangeRates.asmx/getExchangeRatesByDate?Date=" + date;

            //var httpResponse = await _httpClient.GetAsync(url);

            //var contents = await httpResponse.Content.ReadAsStringAsync();

            //// How to parse xml??
            //var data = JsonConvert.DeserializeObject<ExchangeRates>(contents);

            //return data.Items;
            // We could use a List in deserialize, without a new model?


            // With JSON. Example. 
            var testUrl = "https://jsonplaceholder.typicode.com/posts";

            var httpResponseTest = await _httpClient.GetAsync(testUrl);

            var contentsTest = await httpResponseTest.Content.ReadAsStringAsync();

            var dataTest = JsonConvert.DeserializeObject<List<TestModel>>(contentsTest);

            return dataTest;
        }
    }
}

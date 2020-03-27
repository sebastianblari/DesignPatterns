using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class StarWarsApi
    {
        internal async Task<List<Person>> GetCharacters()
        {
            using (var client = new HttpClient())
            {
                string url = "https://swapi.co/api/people";
                string result = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ApiResult<Person>>(result).Results;
            }
        }
    }
}

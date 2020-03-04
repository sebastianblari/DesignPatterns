using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class CharacterFileSource
    {
        public async Task<List<Person>> GetCharactersFromFile(string filePath)
        {
            return JsonConvert.DeserializeObject<List<Person>>(await File.ReadAllTextAsync(filePath));
        }
    }
}

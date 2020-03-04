
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace AdapterPattern.Adapter
{
    public class StarWarsCharacterDisplayService
    {
        public async Task<string> ListCharacters()
        {
            string filePath = "C:/Users/sblancoa/Documents/GitHub/CSharpLearning/DesignPatterns/AdapterPattern/AdapterPattern/Adapter/People.json";
            var people = JsonConvert.DeserializeObject<List<Person>>(await File.ReadAllTextAsync(filePath));
            var sb = new StringBuilder();
            int nameWidth = 30;
            sb.AppendLine($"{"NAME".PadRight(nameWidth)}   {"HAIR"}");
            foreach (var person in people)
            {
                sb.Append($"{person.Name.PadRight(nameWidth)}   {person.HairColor}");
            }

            return sb.ToString();
        }
    }
}

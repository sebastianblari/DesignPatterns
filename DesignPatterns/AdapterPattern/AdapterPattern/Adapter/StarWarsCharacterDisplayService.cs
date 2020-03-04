using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class StarWarsCharacterDisplayService
    {
        ICharacterSourceAdapter _characterSourceAdapter;
        public StarWarsCharacterDisplayService(ICharacterSourceAdapter characterSourceAdapter)
        {
            _characterSourceAdapter = characterSourceAdapter;
        }
        public async Task<string> ListCharacters()
        {
            var people = await _characterSourceAdapter.GetCharacters();

            var sb = new StringBuilder();
            int nameWidth = 30;
            sb.AppendLine($"{"NAME".PadRight(nameWidth)}   {"HAIR"}");
            foreach (var person in people)
            {
                sb.AppendLine($"{person.Name.PadRight(nameWidth)}   {person.HairColor}");
            }

            return sb.ToString();
        }
    }
}

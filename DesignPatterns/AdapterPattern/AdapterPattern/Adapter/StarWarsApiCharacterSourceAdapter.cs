using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class StarWarsApiCharacterSourceAdapter : ICharacterSourceAdapter
    {
        private StarWarsApi _starWarsApi;
        public StarWarsApiCharacterSourceAdapter(StarWarsApi starWarsApi)
        {
            _starWarsApi = starWarsApi;
        }
        public async Task<IEnumerable<Person>> GetCharacters()
        {
            return await _starWarsApi.GetCharacters();
        }
    }
}
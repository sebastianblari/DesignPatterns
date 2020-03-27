using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace AdapterPattern.Adapter
{
    public class CharacterFileSourceAdapter : ICharacterSourceAdapter
    {
        private readonly string _filePath;
        private readonly CharacterFileSource _characterFileSource;

        public CharacterFileSourceAdapter(string filePath, CharacterFileSource characterFileSource)
        {
            _filePath = filePath;
            _characterFileSource = characterFileSource;
        }

        public async Task<IEnumerable<Person>> GetCharacters()
        {
            return (await _characterFileSource.GetCharactersFromFile(_filePath)).Select(character => new CharacterToPersonAdapter(character));
        }
    }
}
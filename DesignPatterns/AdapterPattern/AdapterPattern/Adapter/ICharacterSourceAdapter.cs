using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;


namespace AdapterPattern.Adapter
{
    public interface ICharacterSourceAdapter
    {
        Task<IEnumerable<Person>> GetCharacters();
    }
}

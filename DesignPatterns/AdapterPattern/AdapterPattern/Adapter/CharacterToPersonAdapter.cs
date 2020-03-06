using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapter
{
    public class CharacterToPersonAdapter : Person
    {
        private readonly Character _character;
        public CharacterToPersonAdapter(Character character)
        {
            _character = character ?? throw new ArgumentNullException(nameof(character));
        }

        public override string Name { get => _character.FullName; set => _character.FullName = value; }
        public override string HairColor { get => _character.FullName; set => _character.FullName = value; }
    }
}

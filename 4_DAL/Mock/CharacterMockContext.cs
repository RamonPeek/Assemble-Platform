using _4_DAL.Interfaces;
using _5_Models;
using _5_Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _4_DAL.Mock
{
    public class CharacterMockContext : ICharacterContext
    {

        private List<Character> memory = new List<Character>() {
            new Character("Ironman", "Ironman desc", ""),
            new Character("Thor", "Thor desc", ""),
            new Character("Hulk", "Hulk desc", ""),
            new Character("Black widow", "Black widow desc", ""),
            new Character("Captain America", "Captain America desc", ""),
        };

        public async Task<Character> GetCharacterByName(String name)
        {
            return await Task.FromResult(memory.Find(character => character.Name == name));
        }
    }
}

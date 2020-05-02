using _2_Managers.Interfaces;
using _3_Repositories.Interfaces;
using _5_Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _2_Managers
{
    public class CharacterManager : ICharacterManager
    {

        private ICharacterRepo Repository;

        public CharacterManager(ICharacterRepo repository)
        {
            this.Repository = repository;
        }

        public async Task<Character> GetCharacterByName(string name)
        {
            return await Repository.GetCharacterByName(name);
        }
    }
}

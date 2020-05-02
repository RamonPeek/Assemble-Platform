using _3_Repositories.Interfaces;
using _4_DAL.Interfaces;
using _5_Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories
{
    public class CharacterRepo : ICharacterRepo
    {

        private ICharacterContext Context;

        public CharacterRepo(ICharacterContext context)
        {
            this.Context = context;
        }

        public async Task<Character> GetCharacterByName(string name)
        {
            return await Context.GetCharacterByName(name);
        }
    }
}

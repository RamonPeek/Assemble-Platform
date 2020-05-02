using _3_Repositories.Interfaces;
using _4_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Repositories
{
    public class CharacterRepo : ICharacterRepo
    {

        private ICharacterContext Context;

        public CharacterRepo(ICharacterContext context)
        {
            this.Context = context;
        }

    }
}

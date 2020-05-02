using _2_Managers.Interfaces;
using _3_Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Managers
{
    public class CharacterManager : ICharacterManager
    {

        private ICharacterRepo Repository;

        public CharacterManager(ICharacterRepo repository)
        {
            this.Repository = repository;
        }

    }
}

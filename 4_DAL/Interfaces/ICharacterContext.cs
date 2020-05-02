using _5_Models;
using _5_Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _4_DAL.Interfaces
{
    public interface ICharacterContext
    {

        public Task<Character> GetCharacterByName(String name);

    }
}

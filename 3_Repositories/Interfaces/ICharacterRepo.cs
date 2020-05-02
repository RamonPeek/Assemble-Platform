using _5_Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repositories.Interfaces
{
    public interface ICharacterRepo
    {
        public Task<Character> GetCharacterByName(String name);

    }
}

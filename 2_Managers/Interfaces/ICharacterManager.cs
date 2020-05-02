using _5_Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _2_Managers.Interfaces
{
    public interface ICharacterManager
    {
        public Task<Character> GetCharacterByName(String name);

    }
}

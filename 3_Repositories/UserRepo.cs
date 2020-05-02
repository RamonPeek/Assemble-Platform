using _3_Repositories.Interfaces;
using _4_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Repositories
{
    public class UserRepo : IUserRepo
    {

        private IUserContext Context;

        public UserRepo(IUserContext context)
        {
            this.Context = context;
        }


    }
}

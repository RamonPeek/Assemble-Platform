using _2_Managers.Interfaces;
using _3_Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Managers
{
    public class UserManager : IUserManager
    {

        private IUserRepo Repository;

        public UserManager(IUserRepo repository)
        {
            this.Repository = repository;
        }

    }
}

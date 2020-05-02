using _2_Managers.Interfaces;
using _3_Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Managers
{
    public class AccountManager : IAccountManager
    {

        private IAccountRepo Repository;

        public AccountManager(IAccountRepo repository)
        {
            this.Repository = repository;
        }

    }
}

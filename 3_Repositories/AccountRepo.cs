using _3_Repositories.Interfaces;
using _4_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Repositories
{
    public class AccountRepo : IAccountRepo
    {

        private IAccountContext Context;

        public AccountRepo(IAccountContext context)
        {
            this.Context = context;
        }
    }
}

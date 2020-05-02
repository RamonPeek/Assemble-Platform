using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Models
{
    public class User
    {

        public int Id { get; set; }
        public LinkedAccount LinkedAccount { get; set; }
        public Character Character { get; set; }
        public DateTime LastLogin { get; set; }

        public User() { }

        public User(int id, LinkedAccount linkedAccount, Character character, DateTime lastLogin)
        {
            this.Id = id;
            this.LinkedAccount = LinkedAccount;
            this.Character = character;
            this.LastLogin = lastLogin;
        }

    }
}

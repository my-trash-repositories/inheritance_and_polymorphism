using System;
using System.Collections.Generic;
using System.Text;

namespace UserNameSpace
{
    abstract class User
    {
        private string user_id;
        protected string password;

        public User() { }

        public User(string id, string pass)
        {
            this.user_id = id;
            this.password = pass;
        }

        public bool verifyLogin(string id, string pass) => this.user_id.Equals(id) && this.password.Equals(pass);

        abstract public void updatePassword(string newPassword);
    }
}

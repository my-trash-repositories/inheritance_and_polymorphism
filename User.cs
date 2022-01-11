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
        // the UML in the Handout from ELMS didn't specify what to do with this function so I'll just leave this here like this

        abstract public void updatePassword(string newPassword);
    }
}

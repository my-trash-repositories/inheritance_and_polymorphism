using System;
using System.Collections.Generic;
using System.Text;

namespace UserNameSpace
{
    class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass)
        {
            this.admin_name = name;
            this.password = pass;
            Console.WriteLine("Admin Successfully created! ");
            Console.WriteLine("Name: " + this.admin_name);
            Console.WriteLine("Password: " + this.password);
        }

        public void updateAdminName(string newAdminName)
        {
            Console.WriteLine("Setting Admin Name to " + newAdminName);

            if (newAdminName.Equals(this.admin_name))
                Console.WriteLine("That's the same Admin name, nothing changed");
            else
            {
                this.admin_name = newAdminName;
                Console.WriteLine("Admin name successfully updated!");
            }
        }

        public override void updatePassword(string newPassword)
        {
            Console.WriteLine("Setting password to " + newPassword);

            if (newPassword.Equals(this.password))
                Console.WriteLine("That's the same password, nothing changed");
            else
            {
                this.password = newPassword;
                Console.WriteLine("Pasword successfully updated!");
            }
        }

        public void showDetails()
        {
            Console.WriteLine("\nADMIN DETAILS");
            Console.WriteLine("Name: " + this.admin_name);
            Console.WriteLine("Password: " + this.password);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password { get; set; }
        public bool IsLoggedIn { get; set; }
        // made confirmation a property so it can be used in testing password creation
        public string confirmation { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            IsLoggedIn = false;
        } 
        // switched order of CreatePassword and IsSetupComplete
        public void CreatePassword(string email, string password)
        {
            if (email == Email)
            {
                Password = password;
            }

            if (Password != null)
            {
                confirmation = "Password Created";
            }
        }
        public bool IsSetupComplete()
        {
            if (Name != null && Email != null && Password != null)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        public string LogIn(string password)
        {
            if (password == Password)
            {
                IsLoggedIn = true;
                return "Logged In";
            }
            return "Not Logged In";
        }

        public void LogOut()
        {
            IsLoggedIn = false;
        }
    }
}

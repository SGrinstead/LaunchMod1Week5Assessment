using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password { get; set; }
        public bool IsLoggedIn { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            IsLoggedIn = false;
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

        //rearranged if statements to avoid edge case of already having a password and using the method again with wrong email
        //added writeline to use confirmation variable
        //added else statement for wrong email
        public void CreatePassword(string email, string password)
        {
            if (email == Email)
            {
                Password = password;

                if (Password != null)
                {
                    var confirmation = "Password Created";
                    Console.WriteLine(confirmation);
                }
            }
            else
            {
                Console.WriteLine("Incorrect Email");
            }
        }

        //changed to void method that writes confirmations to console instead of returning a string
        //This better adheres to the single responsibility principle as it no longer returns a value in addition to changing a property
        public void LogIn(string password)
        {
            if (password == Password)
            {
                IsLoggedIn = true;
                Console.WriteLine("Logged In");
            }
            Console.WriteLine("Not Logged In");
        }

        public void LogOut()
        {
            IsLoggedIn = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces_Q02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
        public BasicAuthenticationService(string _username, string _password,string _role)
        {
            this.Username = _username;
            this.Password = _password;
        }
        public bool AuthenticateUser(string username, string password)
        {
            if (username == this.Username && password == this.Password)
                return true;
            else
                return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == this.Username && role == this.Role)
                return true;
            else
                return false;
        }
    }
}

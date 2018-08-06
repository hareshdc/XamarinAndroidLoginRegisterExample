using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XALR
{
    public class Admin
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public Admin() { }
        public Admin(string Id, string username, string fullName, string email, string password, string mobile)
        {
            ID = Id;
            Username = username;
            FullName = fullName;
            Email = email;
            Password = password;
            Mobile = mobile;
        }
        public Admin(string Password)
        {
            this.Password = Password;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.Domain.Entities
{
    public class User
    {
        protected User() { }

        public User(string username, string password, string confirmPassword)
        {
            Username = username;
            Password = password;
            Active = true;

        }

        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }


        public void Activate() => Active = true;
        public void Deactivate() => Active = false;

        private string EncryptPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass)) return "";
            var password = (pass += "|2d331cca-f6c0-40c0-bb43-6e32989c2881");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }
    }
}

﻿using System;

namespace Entity
{
    public class User
    {
        public User(string name,int password)
        {
            _name = name;
            _password = password;
        }
        public string InvitedBy { get; set; }
        public int InvitationCode { get; set; }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "admin")
                {
                    value = "系统管理员";
                }
                _name = value;
            }
        }

        private int _password;
        public int Password { private get; set; }


        private int _verificationCode;
        public int VerificationCode { get; set; }

        public void Register()
        {

        }
        public void Login()
        {

        }
        public void Forget()
        {

        }
    }
}

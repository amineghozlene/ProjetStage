﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetStage.Models
{
    public class User
    {
        private string firstName;
        public virtual string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private String lastName;
        public virtual String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int age;
        public virtual int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string email;
        public virtual string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string numTel;
        public virtual string NumTel
        {
            get { return numTel; }
            set { numTel = value; }
        }
        private String iduser;
        public virtual String Iduser
        {
            get { return iduser; }
            set { iduser = value; }
        }
        private string password;
        public virtual string Password
        {
            get { return password; }
            set { password = value; }
        }
        private String adress;
        public virtual String Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        private String role;
        public virtual String Role
        {
            get { return role; }
            set { role = value; }
        }
        private University university;
        public virtual University University
        {
            get { return university; }
            set { university = value; }
        }
    }
}
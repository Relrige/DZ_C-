using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class User
    {
        private string pasw;
        private string login;
        private int[] points;
        private DateTime birth;
        public int[] Score
        {
            get => points;
            set => points = value;
        }
        public DateTime Birthday
        {
            get => birth;
            set => birth = value;
        }
        public string Password
        {
            get => pasw;
            set => pasw = value;
        }
        public string Login
        {
            get => login;
            set => login = value;
        }


        public User(string l, string pw, DateTime birth)
        {
            Login = l;
            Password = pw;
            Birthday = birth;
            points = new int[3];
        }
        public override string ToString()
        {
            return $"Login : {Login},  Password : {Password}, Birthday : {Birthday}, Score : /20,";
        }
    }
}

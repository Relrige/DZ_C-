using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    interface ILogin
    {
        void Login(string login, string pass);
        void Register(string login, string pass, DateTime date);
        void Change(string pass);
        void Change(DateTime birth);
        void GetResults(IQuiz.Type type);
        void Exit();
    }
    class Users : ILogin
    {
        public User curUser;
        private List<User> List;
        public Users()
        {
            List = new List<User>();
        }
        public List<User> AllUsers
        {
            get => List;
        }
        public void Login(string l, string p)
        {
            foreach (var i in List)
            {
                if (i.Password == p && i.Login == l)
                {
                    curUser = i;
                    return;
                }
            }
            throw new Exception("Error");
        }
        public void Register(string login, string pW, DateTime date)
        {
            foreach (var a in List)
            {
                if (a.Login == login)
                {
                    throw new Exception("Login already exists.");
                }
            }
            List.Add(new User(login, pW, date));
        }
        public void Change(DateTime birth)
        {
            if (curUser != null)
            {
                curUser.Birthday = birth;
            }
            else
            {
                throw new Exception("Error Sign in");
            }
        }
        public void Change(string pw)
        {
            if (curUser != null)
            {
                curUser.Password = pw;
            }
            else
            {
                throw new Exception("Error, sign in");
            }
        }

        public void GetResults(IQuiz.Type type)
        {
            if (curUser != null)
            {
                if (curUser.Score[(int)type] < 20)
                {
                    Console.WriteLine($" {curUser.Score[(int)type]}/20");
                }
                if (curUser.Score[(int)type] == 20)
                {
                    Console.WriteLine($"You won ({curUser.Score[(int)type]}/20)!");
                }

                AllUsers.OrderByDescending(x => x.Score[(int)type]);
                int i = 0;
                foreach (User item in AllUsers)
                {
                    if (item == curUser)
                    {
                        Console.WriteLine($"Your position in rating is - {i}.");
                    }
                    ++i;
                }

                Console.ReadKey();
            }
            else
            {
                throw new Exception("Error sign in");
            }
        }
        public void Exit()
        {
            if (curUser != null)
            {
                curUser = null;
            }
            else
            {
                throw new Exception("Error sign in ");
            }
        }
    }
}

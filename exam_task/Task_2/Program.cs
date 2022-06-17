using System;
using System.Collections;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            TmpQuiz t = new TmpQuiz();
            GeneralQuiz[] generalQuiz = new GeneralQuiz[3];
            generalQuiz[0] = new GeneralQuiz();
            generalQuiz[1] = new GeneralQuiz();
            generalQuiz[2] = new GeneralQuiz();

            generalQuiz[0].Type = IQuiz.Type.Geography;
            generalQuiz[1].Type = IQuiz.Type.History;
            generalQuiz[2].Type = IQuiz.Type.Rnd;

            Login(ref generalQuiz, t);

            Console.Clear();

            char h = ' ';
            while (true)
            {
                Console.WriteLine($"+ - Start quiz");
                Console.WriteLine($"- - Top 20");
                Console.WriteLine($"* - Change data");
                Console.WriteLine($". - Log Out");
                Console.WriteLine($"& - Exit");
                h = Console.ReadLine()[0];

                switch (h)
                {
                    case '+':
                        {
                            Console.Clear();

                            Console.WriteLine($"Types :");
                            Console.WriteLine($" 0 - Geography");
                            Console.WriteLine($" 1 - History");
                            Console.WriteLine($" 2 - Random");
                            int type = int.Parse(Console.ReadLine());

                            generalQuiz[type].Type = (IQuiz.Type)type;
                            //FillQuiz.Fill(ref generalQuiz[type], generalQuiz[type].Type);
                            t.questionService.Add(generalQuiz[type]);

                            Console.Clear();

                            t.Start();
                            t.usersService.GetResults((IQuiz.Type)type);
                        } break;
                    case '-':
                        {
                            Console.Clear();

                            Console.WriteLine($"Choose type :");
                            Console.WriteLine($" 0 - Geography");
                            Console.WriteLine($" 1 - History");
                            Console.WriteLine($" 2 - Random");
                            int type = int.Parse(Console.ReadLine());

                            t.Top20((IQuiz.Type)type);
                        } break;
                    case '*':
                        {
                            Console.Clear();

                            Console.WriteLine($"Choose :");
                            Console.WriteLine($" 1 - Password");
                            Console.WriteLine($" 2 - Birthday");
                            int type = int.Parse(Console.ReadLine());

                            switch (type)
                            {
                                case 1:
                                    {
                                        Console.Write("Enter password : "); 
                                        string pw= Console.ReadLine();
                                        t.usersService.Change(pw);
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.Write("Enter birthday : "); 
                                        string birth = Console.ReadLine();
                                        t.usersService.Change(DateTime.Parse(birth));
                                    }
                                    break;
                                default:
                                    break;
                            }
                        } break;
                    case '.':
                        {
                            t.usersService.Exit();
                            Login( ref generalQuiz,t);
                        } break;
                    case '&':
                        {
                            Environment.Exit(0);
                        } break;
                }

                Console.Clear();
            }
        }

        private static void Login(ref GeneralQuiz[] generalQuiz,TmpQuiz t)
        {
            char a = ' ';
            Console.WriteLine($"l - Login");
            Console.WriteLine($"r - Register");
            Console.WriteLine($"f - Fill");
            Console.WriteLine($"e - Edit");
            a = Console.ReadLine()[0];

            switch (a)
            {
                case 'l':
                    {
                        Console.Write("Enter login : "); 
                        string l = Console.ReadLine();
                        Console.Write("Enter password : "); 
                        string pw = Console.ReadLine();

                        t.usersService.Login(l, pw);
                    }
                    break;
                case 'r':
                    {
                        Console.Write("Enter login : "); 
                        string l = Console.ReadLine();
                        Console.Write("Enter password : ");
                        string pw = Console.ReadLine();
                        Console.Write("Enter birth date (1/1/2000): "); 
                        string date = Console.ReadLine();

                        t.usersService.Register(l, pw, DateTime.Parse(date));

                        Console.Clear();

                        Console.WriteLine("_____________Login_____________");
                        Console.Write("Enter login : "); 
                        string login = Console.ReadLine();
                        Console.Write("Enter password : "); 
                        string password = Console.ReadLine();

                        t.usersService.Login(login, password);
                    }
                    break;
                case 'e':
                    {
                        char tmp = ' ';
                        Console.WriteLine($"l - Login");
                        Console.WriteLine($"r - Register");
                        tmp = Console.ReadLine()[0];

                        switch (tmp)
                        {
                            case 'l':
                                {
                                    Console.Write("Enter login : "); 
                                    string l= Console.ReadLine();
                                    Console.Write("Enter password : "); 
                                    string pw = Console.ReadLine();

                                    t.usersService.Login(l, pw);
                                }
                                break;
                            case 'r':
                                {
                                    Console.Write("Enter login : "); 
                                    string l= Console.ReadLine();
                                    Console.Write("Enter password : "); 
                                    string pw = Console.ReadLine();
                                    Console.Write("Enter birth date (1/1/2000): "); 
                                    string date = Console.ReadLine();

                                    t.usersService.Register(l, pw, DateTime.Parse(date));

                                    Console.Clear();

                                    Console.WriteLine("_____________Login_____________");
                                    Console.Write("Enter login : ");
                                    string login = Console.ReadLine();
                                    Console.Write("Enter password : ");
                                    string password = Console.ReadLine();

                                    t.usersService.Login(login, password);
                                }
                                break;
                        }

                        Console.WriteLine($"Types :");
                        Console.WriteLine($" 0 - Geography");
                        Console.WriteLine($" 1 - History");
                        Console.WriteLine($" 2 - Random");
                        int type = int.Parse(Console.ReadLine());

                        Console.Write($"Enter index : ");
                        int index = int.Parse(Console.ReadLine());
                        FillQuiz.Edit(ref generalQuiz[type], index, (IQuiz.Type)type);
                    } break;
                case 'f':
                    {
                        char tmp = ' ';
                        Console.WriteLine($"l - Login");
                        Console.WriteLine($"r - Register");
                        tmp = Console.ReadLine()[0];

                        switch (tmp)
                        {
                            case 'l':
                                {
                                    Console.Write("Enter login : ");
                                    string l = Console.ReadLine();
                                    Console.Write("Enter password : ");
                                    string pw = Console.ReadLine();

                                    t.usersService.Login(l, pw);
                                }
                                break;
                            case 'r':
                                {
                                    Console.Write("Enter login : ");
                                    string l = Console.ReadLine();
                                    Console.Write("Enter password : ");
                                    string pw = Console.ReadLine();
                                    Console.Write("Enter birth date (1/1/2000): ");
                                    string date = Console.ReadLine();

                                    t.usersService.Register(l, pw, DateTime.Parse(date));

                                    Console.Clear();

                                    Console.WriteLine("_____________Login_____________");
                                    Console.Write("Enter login : ");
                                    string login = Console.ReadLine();
                                    Console.Write("Enter password : ");
                                    string password = Console.ReadLine();

                                    t.usersService.Login(login, password);
                                }
                                break;
                        }

                        Console.WriteLine($"Types :");
                        Console.WriteLine($" 0 - Geography");
                        Console.WriteLine($" 1 - History");
                        Console.WriteLine($" 2 - Random");
                        int type = int.Parse(Console.ReadLine());

                        FillQuiz.Fill(ref generalQuiz[type], (IQuiz.Type)type);
                    }
                    break;
                default: Login( ref generalQuiz,t);
                    break;
            }
        }
    }
}

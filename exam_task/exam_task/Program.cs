using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.Json;
using System.IO;

namespace Exam
{
    class Program
    {
        class Dict
        {
            public void Export(Dictionary<string, List<string>> d)
            //public void Export(Dict d)
            {

                //string jsonStr = JsonConvert.SerializeObject(this);
                //string jsonStr1 = JsonSerializer.Serialize<Dict>(d);
                string jsonStr1 = JsonSerializer.Serialize<Dictionary<string,List<string>>>(d);

                File.WriteAllText("data.json", jsonStr1);
            }
            public void Import()
            {
                string json = File.ReadAllText(Path);
                //var d = JsonSerializer.Deserialize<Dict>(json);
                var d = JsonSerializer.Deserialize<Dictionary<string, List<string>> > (json);

                Console.WriteLine("____All words");
                foreach (var item in d)
                {
                    Console.WriteLine(item.Key + " " + item.Value[0]);
                }
                string s = Console.ReadLine();
            }
            //public void Import()
            //{
            //    this = JsonConvert.DeserializeObject(Path);
            //}
            public string Name { get; set; }
            public string Path { get; set; }
            public Dictionary<string, List<string>> dc = new Dictionary<string, List<string>>();
            public Dict(string name, string path)
            {
                Name = name;
                Path = path;
                //Import();
            }
            public void WordToFile(string word, string path)
            {
                if (dc.ContainsKey(word))
                {
                    File.WriteAllText(path, $"{word} : {String.Join(' ', dc[word])}");
                }

            }
            public void AddWord(string one, List<string> two)
            {
                dc.Add(one, two);
            }
            public void ReplaceWord(string from, string to)
            {
                if (dc.ContainsKey(from))
                {
                    List<string> tmp = new List<string>(dc[from]);
                    dc.Remove(from);
                    dc.Add(from, tmp);
                }
            }
            public void FindTranslate(string word)
            {
                if (dc.ContainsKey(word))
                {
                    Console.WriteLine($"{word} : ");
                    foreach (var item in dc[word])
                    {
                        Console.WriteLine($"{item}");
                    }
                }
            }
            public void DeleteWord(string word)
            {
                if (dc.ContainsKey(word))
                {
                    dc.Remove(word);
                }
            }
            public void AddWord(string one, string two)
            {
                if (dc.ContainsKey(one))
                {
                    dc[one].Add(two);
                }
                else
                {
                    dc.Add(one, new List<string> { two });
                }
            }
        }
        static void Main(string[] args)
        {

            char h = ' ';
            while (true)
            {
                Console.WriteLine($"+ - Create dictionary");
                Console.WriteLine($"& - Exit");
                h = Console.ReadLine()[0];

                switch (h)
                {
                    case '+':
                        {
                            Console.Clear();
                            Console.WriteLine("Enter name :");
                            string str = Console.ReadLine();
                            Dict dict = new Dict(str, "data.json");
                            char a = ' ';
                            while (true)
                            {
                                Console.WriteLine($"+ - Add word");
                                Console.WriteLine($"- - Delete word");
                                Console.WriteLine($"f - Find translate");
                                Console.WriteLine($"r - Replace word");
                                Console.WriteLine($"s - Show");
                                Console.WriteLine($"1 - Serialize");
                                Console.WriteLine($"2 - Deserialize");
                                Console.WriteLine($"& - Exit");
                                a = Console.ReadLine()[0];

                                switch (a)
                                {
                                    case '+':
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter Word :");
                                            string str1 = Console.ReadLine();
                                            Console.WriteLine("Enter Translation:");
                                            string str2 = Console.ReadLine();
                                            dict.AddWord(str1, str2);
                                        }
                                        break;
                                    case '-':
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter Word :");
                                            string str1 = Console.ReadLine();
                                            dict.DeleteWord(str1);
                                        }
                                        break;
                                    case 'f':
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter Word :");
                                            string str1 = Console.ReadLine();
                                            dict.FindTranslate(str1);
                                        }
                                        break;
                                    case 'r':
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter Word :");
                                            string str1 = Console.ReadLine();
                                            Console.WriteLine("Enter Word2:");
                                            string str2 = Console.ReadLine();
                                            dict.ReplaceWord(str1, str2);
                                        }
                                        break;
                                    case 's':
                                        {

                                        }
                                        break;
                                    case '1':
                                        {
                                            Console.WriteLine("Demo");
                                            dict.Export(dict.dc);
                                            //Console.WriteLine();
                                            string s = Console.ReadLine();
                                        }
                                        break;
                                    case '2':
                                        {
                                            Console.WriteLine("Demo");
                                            dict.Import();

                                            string s = Console.ReadLine();
                                        }
                                        break;
                                    case '&':
                                        {
                                            

                                            Console.WriteLine("Exit");
                                            return;
                                        }
                                        
                                }

                                Console.Clear();
                            }

                        }
                        break;
                    case '&':
                        {
                            Console.WriteLine("exit");
                            return;
                        }
                        
                }

                Console.Clear();
            }
             

        }
    }
}
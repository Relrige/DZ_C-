using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CMD
{
    class CmdLine
    {
        public void CMDOpen()
        {
            string a;
            Console.WriteLine("______CMD");
            Console.WriteLine("Enter [help] for instruction");
            do
            {
                a = Console.ReadLine();

                if (a.ToLowerInvariant() == "md")
                {
                    Console.Write("\nEnter name for directory : ");
                    string name = Console.ReadLine();
                    AddDir(name);
                }
                if (a.ToLowerInvariant() == "rd")
                {
                    Console.Write("Enter path :");
                    string path = Console.ReadLine();
                    RemoveDir(path);
                }
                if (a.ToLowerInvariant() == "cd")
                {
                    Console.Write("Enter path :");
                    string path = Console.ReadLine();
                    ChangeDir(path);
                }
                if (a.ToLowerInvariant() == "dir")
                {
                    Dir();
                }
                if (a.ToLowerInvariant() == "create")
                {
                    Console.Write("Enter file name  :");
                    string fname = Console.ReadLine();
                    Console.Write("Enter text for file : ");
                    string txt = Console.ReadLine();
                    CreateFile(fname, txt);
                }
                if (a.ToLowerInvariant() == "type")
                {
                    Console.Write("Enter name file : ");
                    string fname = Console.ReadLine();
                    InfoFile(fname);
                }
                if (a.ToLowerInvariant() == "copy")
                {
                    Console.Write("Enter path: ");
                    string path = Console.ReadLine();
                    Console.Write("Enter new path: ");
                    string newPath = Console.ReadLine();
                    CopyFile(path, newPath);
                }
                if (a.ToLowerInvariant() == "del")
                {
                    Console.Write("Enter name:");
                    string n = Console.ReadLine();
                    RemoveFile(n);
                }
                if (a.ToLowerInvariant() == "append")
                {
                    Console.Write("Enter name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter text: ");
                    string txt = Console.ReadLine();
                    ApendFile(n, txt);
                }
                if (a.ToLowerInvariant() == "help")
                {
                    Help();
                }
            } while (true);


        }
        public void Help()
        {
            Console.WriteLine("___________All comands_______________");
            Console.WriteLine("\tDIRECTORY\n");
            Console.WriteLine("[md + name] - create new directory");
            Console.WriteLine("[rd + name] - remove directory");
            Console.WriteLine("[cd + name] - change directory");
            Console.WriteLine("[dir] - info directory");
            Console.WriteLine("\n");
            Console.WriteLine("[create + name + text] - create new file and write text");
            Console.WriteLine("[type + name] - show info file");
            Console.WriteLine("[copy + name + new name] - copy file");
            Console.WriteLine("[del + name] - remove file");
            Console.WriteLine("[append + name] - append file");
            Console.WriteLine("-------------------------");
        }

        public void Dir()
        {
            Console.WriteLine("\n_______DIR");
            string[] a = Directory.GetFileSystemEntries(".");
            foreach (var item in a)
            {
                string info;
                if (File.GetAttributes(item) != FileAttributes.Directory)
                {
                    FileInfo fi = new FileInfo(item);
                    info = $"{fi.Length}";
                    Console.WriteLine($"{Path.GetFileName(item),-10},{File.GetCreationTime(item),-10},{fi.Length,-10}");
                }
                else
                {
                    info = "<DIR>";
                }
                Console.WriteLine($" {info,-10}{Path.GetFileName(item),-35}{File.GetCreationTime(item),-15}");
            }
        }
        public void ChangeDir(string path)
        {
            Directory.SetCurrentDirectory(path);
        }
        public void RemoveDir(string path)
        {
            if (Directory.Exists(path))
                Directory.Delete(path);
            else
                Console.WriteLine("Folder doesn't exist!");
        }
        public void AddDir(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            else
                Console.WriteLine("Folder is exists!");
        }
        public void CreateFile(string path, string message)
        {
            if (!File.Exists(path))
                File.WriteAllText(path, message);
            else
                Console.WriteLine($"Error! Path {path} is exists!");
        }
        public void InfoFile(string path)
        {
            Console.WriteLine("__________-FILE______________-");
            string[] files = Directory.GetFiles(".");
            foreach (var item in files)
            {
                FileInfo fi = new FileInfo(item);
                Console.WriteLine($"{Path.GetFileName(item),-10},{File.GetCreationTime(item),-10},{fi.Length,-10}");
            }
        }
        public void CopyFile(string path, string newP)
        {
            FileInfo fi = new FileInfo(path);
            fi.CopyTo(newP);
        }
        public void RemoveFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            else
                Console.WriteLine($"Error! Path {path} doesn't exists!");
        }
        public void ApendFile(string path, string str)
        {
            if (File.Exists(path))
                File.AppendAllText(path, str);
            else
                Console.WriteLine("File doesn't exists!");
        }

    }
}

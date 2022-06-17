using System;
using System.Collections.Generic;

namespace LinkedList_Task
{
    class Program
    {
        class LinkedListDemo
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        class Persona
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return $"Name : {Name}, Age: {Age}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("_________Linked List_1");
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("house");
            list.AddLast("computer");
            list.AddLast("tea");
            list.AddLast("Pan");
            list.AddFirst("mouse");
            list.AddAfter(list.Last,"house");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("_________Linked List_2");
            LinkedList<Persona> persone = new LinkedList<Persona>();
            
            persone.AddFirst(new Persona() { Name = "Dima", Age = 41 });
            persone.AddAfter(persone.Last, new Persona() { Name = "Anna", Age = 28 });
            persone.AddLast(new Persona() { Name = "Vlad", Age = 18 });
            persone.AddLast(new Persona() { Name = "Mark", Age = 38 });
            persone.RemoveLast();
            foreach (var item in persone)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Age);
            }
            Console.WriteLine("_________SortedSet<>_2");
            SortedSet<int> set = new SortedSet<int>();

            set.Add(1);
            set.Add(123);
            set.Add(2);
            set.Add(31);
            set.Add(14);
            set.Add(4);
            set.Add(60);
            set.Add(55);
            set.Add(5);

            set.Remove(123);
            set.Remove(5);
            int a = 3;
            if (set.Contains(a) == true)
            {
                Console.WriteLine($"Element {a} is exist!");
            }
            else
            {
                Console.WriteLine($"Element {a} don't exist!");
            }


            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine($"Count : { set.Count}");
            Console.WriteLine($"Max: { set.Max}");
            Console.WriteLine($"Min: { set.Min}");
            



            //Task 3
            HashSet<Persona> hs_person = new HashSet<Persona>();
            HashSet<Persona> hs_person1 = new HashSet<Persona>();
            hs_person.Add(new Persona() { Name = "Masha", Age = 43 });
            hs_person.Add(new Persona() { Name = "Dasha", Age = 13 });
            hs_person.Add(new Persona() { Name = "Serhii", Age = 27 });

            hs_person1.Add(new Persona() { Name = "Oleksandr", Age = 36 });
            hs_person1.Add(new Persona() { Name = "Oleh", Age = 18 });

            hs_person.UnionWith(hs_person1);
            Console.WriteLine("_________HashSet<>_Union");
            foreach (var item in hs_person)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_________HashSet<>_InteractWith");
            hs_person.IntersectWith(hs_person1);
            foreach (var item in hs_person)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_________HashSet<>_ExeptWith");
            hs_person1.ExceptWith(hs_person);
            foreach (var item in hs_person)
            {
                Console.WriteLine(item);
            }

        }
    }
}
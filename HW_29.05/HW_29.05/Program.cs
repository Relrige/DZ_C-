
using System;
using System.Text;
using System.Collections.Generic;

namespace Std_Collections
{
    /*Завдання 1.
    Підрахувати, скільки разів кожне слово зустрічається в заданому тексті. Результат записати в колекцію Dictionary <TKey, TValue>. Текст використовувати з додатка 1. Вивести статистику по тексту у вигляді таблиці (рисунок 1).
    Додаток 1.
    Ось будинок, який побудував Джек. А це пшениця, Яка в темній комірці зберігається У будинку, Який побудував Джек. А це весела птиця-синиця, Яка часто краде пшеницю, Яка в темній комірці
    зберігається У будинку, Який побудував Джек.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string text = "Ось будинок, який побудував Джек. А це пшениця, Яка в темній комірці зберігається У будинку, Який побудував Джек. А це весела птиця-синиця, Яка часто краде пшеницю, Яка в темній комірці зберігається У будинку, Який побудував Джек.";

            int counter = 0, unique_counter = 0;
            Dictionary<string, int> dictionary = new Dictionary<string, int>(50);
            string tmp = null;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==' ')
                {
                    int value = 0;
                    foreach (var item in dictionary)
                    {
                        if (item.Key == tmp)
                        {
                            value = item.Value;
                            ++value;
                        }
                    }
                    if (value != 0)
                    {
                        dictionary[tmp] = value;
                    }
                    else
                    {
                        dictionary.Add(tmp, 1);
                        ++unique_counter;
                    }
                    tmp = null;
                }
                else
                {
                    tmp += text[i];
                }
            }

            foreach (var item in dictionary)
            {
                counter += item.Value;
            }
            int nums = 1;
            Console.WriteLine($"{"Слово : ",20} {"Кільк. : ",20}");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{nums}. {item.Key,20} {item.Value,20}");
                ++nums;
            }
            Console.WriteLine($"Всього слів : {counter}.\t\tВсього унікальних слів : {unique_counter}.");



        }
    }
}
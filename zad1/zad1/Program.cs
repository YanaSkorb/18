using System;
using System.Collections.Generic;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> str = new Stack<char>();
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                str.Push(s[i]);
            }
            s = "";
            char ch;
            int count = str.Count;
            for (int i = 0; i < count; i++)
            {
                ch = str.Pop();
                if (ch == '#')
                {
                    str.Pop();
                    i++;
                }
                else
                {
                    s += ch;
                }
            }
            Console.WriteLine("Результат работы : {0}", s);
            Console.ReadLine();

        }
    }
}


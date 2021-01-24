﻿using System;

namespace Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey(true);
        }

        static void Echo(string phrase, int deep)
        {
            var modif = phrase;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.WriteLine(modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}

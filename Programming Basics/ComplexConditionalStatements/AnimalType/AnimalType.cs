﻿using System;

namespace AnimalType
{
    public class AnimalType
    {
        public static void Main()
        {
            var animal = Console.ReadLine();


            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}

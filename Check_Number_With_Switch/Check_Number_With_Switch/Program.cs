﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Number_With_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("Not 10, 20, or 30"); break;
            }
        }
    }
}

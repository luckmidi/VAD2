﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            Point p3 = new Point(4, 6, '#');
            p3.Draw();
            Point p4 = new Point(5, 6, '#');
            p4.Draw();
            Point p5 = new Point(6, 6, '#');
            p5.Draw();


            Console.ReadLine();
        }
    }
}

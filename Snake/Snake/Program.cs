﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 50);

            HorizontalLine upLine = new HorizontalLine(0, 118, 0, '+', true);
            HorizontalLine downLine= new HorizontalLine(0, 118, 49, '+', true);
            VerticalLine leftLine = new VerticalLine(0, 0, 49, '+', true);
            VerticalLine rightLine = new VerticalLine(118, 0, 49, '+', true);

            Console.ReadLine();
        }
        
    }
}

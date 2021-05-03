﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixAdder
{
    class Program
    {
        static void Main()
        {
            var adder = new MatrixAdder();
            adder.SumMatrix();

            var generator = new MatrixGenerator();
            generator.RunOperation(4, 6);
        }
    }
}
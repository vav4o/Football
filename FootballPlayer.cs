﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class FootballPlayer : Person
    {
        public int Number { get; private set; }
        public double Height { get; private set; }

        public FootballPlayer(string name, int age, int number, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}

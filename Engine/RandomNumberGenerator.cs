﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static Random _randomNumber = new Random();

        public static int NumberBetween(int minValue, int maxValue)
        {
            return _randomNumber.Next(minValue, maxValue + 1);
        }
    }
}

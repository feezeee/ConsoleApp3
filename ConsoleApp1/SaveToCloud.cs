﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SaveToCloud : ISave
    {
        public void Save<T>(T obj)
        {
            Console.WriteLine($"Сохраняю {obj}");
        }
    }
}

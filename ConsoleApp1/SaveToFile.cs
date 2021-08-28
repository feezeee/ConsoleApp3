using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SaveToFile : ISave
    {
        public void Save <T> (T obj)
        {
            Console.WriteLine($"Сохраняем в файл {obj.ToString()}");
        }
    }
}

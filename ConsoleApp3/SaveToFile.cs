using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SaveToFile <T> : ISaver <T>
    {
        void ISaver<T>.Save(T obj)
        {
            Console.WriteLine("Сохраняю в файл...");
            Console.WriteLine("Сохранено!");
        }
    }
}

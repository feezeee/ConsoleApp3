using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SaveToDB<T> : ISaver <T>
    {
        void ISaver<T>.Save(T obj)
        {
            Console.WriteLine("Сохраняю в бд...");
            Console.WriteLine("Сохранено!");
        }
    }
}

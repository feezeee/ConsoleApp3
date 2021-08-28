using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ak47 : Gun
    {   
        public override void Fire()
        {
            Console.WriteLine("Стреляю очередью");
        }
    }
}

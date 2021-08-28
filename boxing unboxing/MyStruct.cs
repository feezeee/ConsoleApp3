using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxing_unboxing
{
    struct MyStruct : IInterface1
    {
        public void Say()
        {
            Console.WriteLine("Hello world");
        }
    }
}

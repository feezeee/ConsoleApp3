using System;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct mS = new MyStruct();
            // Тип 1.
            object boxed1 = mS;
            MyStruct unboxed1 = (MyStruct)boxed1;
            unboxed1.Say();

            // тип 2.
            ValueType boxed2 = mS;
            MyStruct unboxed2 = (MyStruct)boxed2;
            unboxed2.Say();

            // Тип 3.
            IInterface1 boxed3 = mS;
            MyStruct unboxed3 = (MyStruct)boxed3;

            unboxed3.Say();

            //int i = 5;
            //object obj = i;
            //long k = (long)(int)obj;

        }
    }
}

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal { Height = 1 };
            Person maks = new Person { Height = 100 };

            
            maks.Save(new SaveToFile<Person>());
            maks.Save(new SaveToDB<Person>());

            dog.Save(new SaveToFile<Animal>());
            dog.Save(new SaveToDB<Animal>());

        }
    }
}

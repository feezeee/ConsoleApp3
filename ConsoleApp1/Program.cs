using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person maksim = new Person();
            maksim.Name = "Максим";

            ISave savePerson = new SaveToFile();
            savePerson.Save(maksim);
        }
    }

    
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person maksim = new Person();
            maksim.Name = "Максим";
            maksim.gun1 = new ak47();
            maksim.gun2 = new AWP();

            maksim.gun1.Fire();
            maksim.gun2.Fire();

            ISave savePerson = new SaveToFile();
            savePerson.Save(maksim);

            ISave saveGuns = new SaveToDB();
            saveGuns.Save(maksim.gun1);
        }
    }

    
}

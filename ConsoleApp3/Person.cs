using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person : ISave<Person>
    {
        private int height;

        public int Height { get => height; set => height = value; }

        public void Save(ISaver<Person> saver)
        {   
            // Saver - способ сохранения
            saver.Save(this);
        }
    }
}

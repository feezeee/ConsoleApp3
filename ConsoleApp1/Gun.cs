using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Gun : IFire
    {
        private int ammo;

        public int Ammo 
        { 
              get => ammo; 
            set => ammo = value;
        }

        private int spread;

        public int Spread
        {
            get => spread;
            set => spread = value;
        }


        public virtual void Fire()
        {
            Console.WriteLine("Стреляю");
        }
    }
}

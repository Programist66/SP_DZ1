using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLib
{
    internal class Rifle : IWeapon
    {
        public string Name => "Винтовка";

        public float Firerate => 5f;

        public float Damage => 80;

        public float Shot()
        {
            return Damage;
        }
    }
}

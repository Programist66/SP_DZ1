using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLib
{
    internal class Pistol : IWeapon
    {
        public string Name => "Пистолет";
        public float Firerate => 0.5f;
        public float Damage => 10;

        public float Shot()
        {
            return Damage;
        }
    }
}

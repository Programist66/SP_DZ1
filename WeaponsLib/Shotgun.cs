using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLib
{
    internal class Shotgun : IWeapon
    {
        public string Name => "Дробовик";

        public float Firerate => 1.5f;

        public float Damage => 50;

        public float Shot()
        {
            return Damage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLib
{
    public class Weapons
    {
        public static IWeapon Create(WeaponType weaponType) 
        {
            switch (weaponType) 
            {
                case WeaponType.Pistol:
                    return new Pistol();
                case WeaponType.Shotgun:
                    return new Shotgun();
                case WeaponType.Rifle:
                    return new Rifle();
                default:
                    throw new ArgumentException("Unknown weapon type");
            }
        }
    }
}

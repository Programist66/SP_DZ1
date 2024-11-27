using WeaponsLib;

public class Program
{
    private static void Main(string[] args)
    {
        Test(Weapons.Create(WeaponType.Pistol), 100f);
    }

    static void Test(IWeapon weapon, float health) 
    {
        int shotsFired = 0;
        DateTime startTime = DateTime.Now;

        while (health > 0)
        {
            weapon.Shot();
            Console.WriteLine($"{weapon.Name} выстрелил");
            health -= weapon.Damage;
            shotsFired++;
            if (health > 0)
            {
                Thread.Sleep((int)(weapon.Firerate * 1000));
            }            
        }

        DateTime endTime = DateTime.Now;
        double totalTimeInSeconds = (endTime - startTime).TotalSeconds;
        double actualDamagePerSecond = shotsFired * weapon.Damage / totalTimeInSeconds;

        Console.WriteLine($"Выстрелов сделано: {shotsFired}");
        Console.WriteLine($"Урона в секунду: {actualDamagePerSecond}");
    }
}
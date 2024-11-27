namespace WeaponsLib
{
    public interface IWeapon
    {
        public string Name { get; }
        public float Firerate { get; }
        public float Damage { get; }

        public float Shot();
    }
}

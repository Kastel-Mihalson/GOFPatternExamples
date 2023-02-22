namespace DecoratorPattern
{
    public class FireWeaponForGun : GunDecorator
    {
        public FireWeaponForGun(Gun gun) : base(gun.Name, gun)
        {
            Console.WriteLine($"{gun.Name} modified -> {gun.Name} FG-500.");
        }

        public override float GetDamage()
        {
            Console.WriteLine("- Добавлены огенные пули. Увеличен урон.");
            return gun.GetDamage() + 40;
        }

        public override float GetWeight()
        {
            Console.WriteLine("- Вес у оружия снижен.");
            return gun.GetWeight() - 3;
        }
    }
}

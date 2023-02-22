namespace DecoratorPattern
{
    public class ExpansiveWeaponsForGun : GunDecorator
    {
        public ExpansiveWeaponsForGun(Gun gun) : base(gun.Name, gun) 
        {
            Console.WriteLine($"{gun.Name} modified -> {gun.Name} VM-16.");
        }

        public override float GetDamage()
        {
            Console.WriteLine("- Добавлены экспансивные пули. Увеличен урон.");
            return gun.GetDamage() + 15;
        }

        public override float GetWeight()
        {
            Console.WriteLine("- Вес у оружия увеличен.");
            return gun.GetWeight() + 2;
        }
    }
}
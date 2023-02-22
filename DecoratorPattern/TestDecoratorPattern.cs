namespace DecoratorPattern
{
    public class TestDecoratorPattern
    {
        public void Execute()
        {
            Gun snowballGun = new SnowballGun();
            Console.WriteLine("Characteristics:\n" +
                $"Damage: {snowballGun.GetDamage()}\n" +
                $"Weight: {snowballGun.GetWeight()}\n");

            snowballGun = new ExpansiveWeaponsForGun(snowballGun);
            Console.WriteLine("Characteristics:\n" +
                $"Damage: {snowballGun.GetDamage()}\n" +
                $"Weight: {snowballGun.GetWeight()}\n");

            snowballGun = new FireWeaponForGun(snowballGun);
            Console.WriteLine("Characteristics:\n" +
                $"Damage: {snowballGun.GetDamage()}\n" +
                $"Weight: {snowballGun.GetWeight()}\n");
        }
    }
}
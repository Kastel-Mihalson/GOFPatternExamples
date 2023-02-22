using FactoryPattern.Domain;
using FactoryPattern.Factories;

namespace FactoryPattern
{
    public class TestFactoryPattern
    {
        public void Execute()
        {
            Console.WriteLine("Let's get spaaceship guns!");
            Console.WriteLine("Enter the spaceship gun would you like get: (SG, LG or SBG)");
            Console.WriteLine($"" +
                $"> Simple gun - SG\n" +
                $"> Laser gun - LG\n" +
                $"> Snowball gun - SBG\n");

            string gunType = Console.ReadLine();

            SpaceshipGunFactory factory = GetFactory(gunType);

            ISpaceshipGun gun = factory.GetSpaceshipGun();

            Console.WriteLine("\nYou gun parameters:\n" +
                $"-- Name: {gun.Name}\n" +
                $"-- Fire rate: {gun.FireRate}\n" +
                $"-- Damage: {gun.Damage}\n");
        }

        private SpaceshipGunFactory GetFactory(string gunType)
        {
            return gunType.ToLower() switch
            {
                "sg" => new SimpleGunFactory("Simple Gun - RAZOR", 100, 200),
                "lg" => new LaserGunFactory("Laser Gun - IMPULSE", 250, 500),
                "sbg" => new SnowballGunFactory("Snowball Gun - ICE BABY", 200, 300),
                _ => new NoneGunFactory()
            };
        }
    }
}

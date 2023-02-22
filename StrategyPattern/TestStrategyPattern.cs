namespace StrategyPattern
{
    public class TestStrategyPattern
    {
        public void Execute()
        {
            Spaceship spaceship = new Spaceship();
            spaceship.SetGun(new LaserGun());
            spaceship.Shot();
            Console.WriteLine();

            spaceship.SetGun(new SnowballGun());
            spaceship.Shot();
            spaceship.Shot();
            Console.WriteLine();

            spaceship.SetGun(new SimpleGun());
            spaceship.Shot();
        }
    }
}
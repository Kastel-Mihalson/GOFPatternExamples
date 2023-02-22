namespace StrategyPattern
{
    public class Spaceship
    {
        public ISpaceshipGun Gun { get; set; }
        public Spaceship() { }

        public void SetGun(ISpaceshipGun gun)
        {
            if (Gun != null && Gun != gun)
            {
                Console.WriteLine("-- Смена оружия --");
            }
            Console.WriteLine($"Установлена пушка: {gun.Info} ");
            Gun = gun;
        }

        public void Shot()
        {
            Gun.Fire();
        }
    }
}
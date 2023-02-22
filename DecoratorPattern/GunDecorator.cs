namespace DecoratorPattern
{
    public abstract class GunDecorator : Gun
    {
        protected Gun gun;
        protected GunDecorator(string name, Gun gun) : base(name)
        {
            this.gun = gun;
        }
    }
}
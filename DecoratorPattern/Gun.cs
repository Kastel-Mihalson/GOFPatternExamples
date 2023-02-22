namespace DecoratorPattern
{
    public abstract class Gun
    {
        public string Name { get; protected set; }

        public Gun(string name)
        {
            Name = name;
        }

        public abstract float GetDamage();
        public abstract float GetWeight();
    }
}
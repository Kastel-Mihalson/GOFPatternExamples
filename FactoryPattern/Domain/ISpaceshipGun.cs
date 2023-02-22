namespace FactoryPattern.Domain
{
    public interface ISpaceshipGun
    {
        string Name { get; }
        float FireRate { get; }
        float Damage { get; }
    }
}
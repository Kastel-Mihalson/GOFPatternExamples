using FactoryPattern.Domain;

namespace FactoryPattern.Factories
{
    public abstract class SpaceshipGunFactory
    {
        public abstract ISpaceshipGun GetSpaceshipGun();
    }
}
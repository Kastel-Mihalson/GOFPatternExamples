using FactoryPattern.Domain;

namespace FactoryPattern.Factories
{
    public class LaserGunFactory : SpaceshipGunFactory
    {
        private readonly string _name;
        private readonly float _fireRate;
        private readonly float _damage;

        public LaserGunFactory(string name, float fireRate, float damage)
        {
            _name = name;
            _fireRate = fireRate;
            _damage = damage;
        }

        public override ISpaceshipGun GetSpaceshipGun()
        {
            return new LaserGun(_name, _fireRate, _damage);
        }
    }
}
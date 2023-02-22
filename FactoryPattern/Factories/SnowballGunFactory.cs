using FactoryPattern.Domain;

namespace FactoryPattern.Factories
{
    public class SnowballGunFactory : SpaceshipGunFactory
    {
        private readonly string _name;
        private readonly float _fireRate;
        private readonly float _damage;

        public SnowballGunFactory(string name, float fireRate, float damage)
        {
            _name = name;
            _fireRate = fireRate;
            _damage = damage;
        }

        public override ISpaceshipGun GetSpaceshipGun()
        {
            return new SnowballGun(_name, _fireRate, _damage);
        }
    }
}
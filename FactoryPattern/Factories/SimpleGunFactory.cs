using FactoryPattern.Domain;

namespace FactoryPattern.Factories
{
    public class SimpleGunFactory : SpaceshipGunFactory
    {
        private readonly string _name;
        private readonly float _fireRate;
        private readonly float _damage;

        public SimpleGunFactory(string name, float fireRate, float damage)
        {
            _name = name;
            _fireRate = fireRate;
            _damage = damage;
        }

        public override ISpaceshipGun GetSpaceshipGun()
        {
            return new SimpleGun(_name, _fireRate, _damage);
        }
    }
}
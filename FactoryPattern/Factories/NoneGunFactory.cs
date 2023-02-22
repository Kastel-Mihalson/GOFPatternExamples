using FactoryPattern.Domain;

namespace FactoryPattern.Factories
{
    public class NoneGunFactory : SpaceshipGunFactory
    {
        private readonly string _name;
        private readonly float _fireRate;
        private readonly float _damage;

        public NoneGunFactory()
        {
            _name = "Default gun - NONE";
            _fireRate = 0f;
            _damage = 0f;
        }

        public override ISpaceshipGun GetSpaceshipGun()
        {
            return new NoneGun(_name, _fireRate, _damage);
        }
    }
}
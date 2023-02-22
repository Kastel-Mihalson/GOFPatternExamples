namespace FactoryPattern.Domain
{
    public class SimpleGun : ISpaceshipGun
    {
        private readonly string _name;
        private readonly float _fireRate;
        private readonly float _damage;

        public SimpleGun(string name, float fireRate, float damage)
        {
            _name = name;
            _fireRate = fireRate;
            _damage = damage;
        }

        public string Name => _name;
        public float FireRate => _fireRate;
        public float Damage => _damage;
    }
}
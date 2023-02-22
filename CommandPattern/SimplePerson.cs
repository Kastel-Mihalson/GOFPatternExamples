namespace CommandPattern
{
    public class SimplePerson : IUnit
    {
        public void Walk()
        {
            Console.WriteLine("Персонаж ходит.");
        }
        public void Jump()
        {
            Console.WriteLine("Персонаж прыгает.");
        }
        public void Wait()
        {
            Console.WriteLine("Персонаж очень ожиавет.");
        }
        public void Attack()
        {
            Console.WriteLine("Персонаж аттакует.");
        }
    }
}
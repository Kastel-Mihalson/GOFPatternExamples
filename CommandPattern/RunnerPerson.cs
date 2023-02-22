namespace CommandPattern
{
    public class RunnerPerson : IUnit
    {
        public void Attack()
        {
            Console.WriteLine("Персонаж атакует ножом.");
        }

        public void Jump()
        {
            Console.WriteLine("Персонаж делает двойное сальто.");
        }

        public void Wait()
        {
            Console.WriteLine("Персонаж просто ожидает.");
        }

        public void Walk()
        {
            Console.WriteLine("Персонаж щемит со вмех ног.");
        }
    }
}
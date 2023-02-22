namespace StatePattern
{
    public class Green : TrafficLightState
    {
        public override void ChangeState(TrafficLight trafficLight)
        {
            float time = 5;
            Console.ForegroundColor = ConsoleColor.Green;
            while (time >= 0)
            {
                if (time > 3)
                {
                    Console.Write($"Зеленый свет: {time} сек.");
                } else
                {
                    Console.Write($"Мигающий зеленый свет: {time} сек.");
                }
                time--;
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
            }
            trafficLight.State = new YellowAfterGreen();
        }
    }
}
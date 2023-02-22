namespace StatePattern
{
    public class YellowAfterGreen : TrafficLightState
    {
        public override void ChangeState(TrafficLight trafficLight)
        {
            float time = 2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (time >= 0)
            {
                Console.Write($"Желтый свет: {time} сек.");
                time--;
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
            }
            trafficLight.State = new Red();
        }
    }
}
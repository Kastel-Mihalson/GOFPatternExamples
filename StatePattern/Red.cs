namespace StatePattern
{
    public class Red : TrafficLightState
    {
        public override void ChangeState(TrafficLight trafficLight)
        {
            float time = 10;
            Console.ForegroundColor = ConsoleColor.Red;
            while (time >= 0)
            {
                Console.Write($"Красный свет: {time} сек.");
                time--;
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
            }
            trafficLight.State = new YellowBeforeGreen();
        }
    }
}
namespace StatePattern
{
    public class TestStatePattern
    {
        public void Execute()
        {
            var trafficLight = new TrafficLight(new Red());
            while(true)
            {
                trafficLight.ChangeTrafficLightState();
            }
        }
    }
}
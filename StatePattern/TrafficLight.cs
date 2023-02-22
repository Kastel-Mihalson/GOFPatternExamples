namespace StatePattern
{
    public class TrafficLight
    {
        public TrafficLightState State { get; set; }

        public TrafficLight(TrafficLightState state)
        {
            State = state;
        }

        public void ChangeTrafficLightState()
        {
            State.ChangeState(this);
        }
    }
}
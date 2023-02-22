namespace FacadePattern
{
    public class TestFacadePattern
    {
        public void Execute()
        {
            var house = new House("3-ёх этажное здание.");
            house.ShowInfo();
            house.SetFoundation(new Foundation("Бетонная Сейсмиустойчивая основа."));
            house.AddFloor(new Floor(1));
            house.AddFloor(new Floor(2));
            house.AddFloor(new Floor(3));
            house.SetRoof(new Roof("Черепичная двухскатная."));
        }
    }
}
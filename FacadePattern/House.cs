namespace FacadePattern
{
    public class House
    {
        private string Name { get; set; }
        private Foundation Foundation { get; set; }
        private List<Floor> Floors = new List<Floor>();
        private Roof Roof { get; set; }

        public House(string name)
        {
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Проект: {Name}\n{new string('-', 20)}");
        }

        public void SetFoundation(Foundation foundation)
        {
            Console.WriteLine($"Построен фундамент здания:\n" +
                $"- Тип фундамента: {foundation.Type}");
            Foundation = foundation;
        }

        public void AddFloor(Floor floor)
        {
            Console.WriteLine($"Построен {floor.Number} этаж здания:");
            Floors.Add(floor);
        }

        public void SetRoof(Roof roof)
        {
            Console.WriteLine($"Построена крыша здания:\n" +
                $"- Тип крыши: {roof.Type}");
            Roof = roof;
        }
    }
}
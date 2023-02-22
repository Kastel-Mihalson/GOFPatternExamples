namespace VisitorPattern
{
    public class TestVisitorPattern
    {
        public void Execute()
        {
            DrawerSchool school = new DrawerSchool();
            var andrew = new TraditionalDrawer { Name = "Andrew", DrawerType = DrawerType.TRADITIONAL };
            var nina = new TraditionalDrawer { Name = "Nina", DrawerType = DrawerType.TRADITIONAL };
            var stranger = new BoardDrawer { Name = "Stranger", DrawerType = DrawerType.STRANGER };
            var castel = new CGDrawer { Name = "Castel", DrawerType = DrawerType.CG };
            var vlada = new CGDrawer { Name = "Vlada", DrawerType = DrawerType.CG };

            school.AddDrawer( andrew );
            school.AddDrawer( nina );
            school.AddDrawer( stranger );
            school.AddDrawer( castel );
            school.AddDrawer( vlada );

            Console.WriteLine($"Участвование на конкрусе традиционных рисунков.\n{new string('-', 40)}");
            school.ParticipateInTheEvent(new MoscowGotTalent());

            Console.WriteLine($"\nУчаствование на конкрусе цифровых рисунков.\n{new string('-', 40)}");
            school.ParticipateInTheEvent(new SomeLocalDrawEvent());
        }
    }
}
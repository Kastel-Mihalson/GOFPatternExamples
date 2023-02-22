namespace VisitorPattern
{
    public class SomeLocalDrawEvent : IVisitor
    {
        public void DrawOnBoard(BoardDrawer drawer)
        {
            Console.WriteLine($"Drawer: {drawer.Name}\tType: {DrawerTypes.DrawerTypeNames[drawer.DrawerType]}\n" +
                $"Не понимают что делать с планшетом. Просят доски.");
        }

        public void DrawOnPaper(TraditionalDrawer drawer)
        {
            Console.WriteLine($"Drawer: {drawer.Name}\tType: {DrawerTypes.DrawerTypeNames[drawer.DrawerType]}\n" +
                $"Линии не ровные, так как рука не привыкла к планшету.");
        }

        public void DrawOnTablet(CGDrawer drawer)
        {
            Console.WriteLine($"Drawer: {drawer.Name}\tType: {DrawerTypes.DrawerTypeNames[drawer.DrawerType]}\n" +
                $"Цифровой рисунок вышел на ура.");
        }
    }
}
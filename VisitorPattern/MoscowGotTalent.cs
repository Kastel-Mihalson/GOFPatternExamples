namespace VisitorPattern
{
    public class MoscowGotTalent : IVisitor
    {
        public void DrawOnBoard(BoardDrawer drawer)
        {
            Console.WriteLine($"Drawer: {drawer.Name}\tType: {DrawerTypes.DrawerTypeNames[drawer.DrawerType]}\n" +
                $"Не понимают что происходит. Тут нет досок и мелов.");
        }

        public void DrawOnPaper(TraditionalDrawer drawer)
        {
            Console.WriteLine($"Drawer: {drawer.Name}\tType: {DrawerTypes.DrawerTypeNames[drawer.DrawerType]}\n" +
                $"Нарисованы прекрасные картины. {drawer.Name} мастер традиционного рисования.");
        }

        public void DrawOnTablet(CGDrawer drawer)
        {
            Console.WriteLine($"Drawer: {drawer.Name}\tType: {DrawerTypes.DrawerTypeNames[drawer.DrawerType]}\n" +
                $"Рисование дается тяжело, так как использются кисточки.");
        }
    }
}
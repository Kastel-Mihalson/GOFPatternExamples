namespace VisitorPattern
{
    public class BoardDrawer : IDrawer
    {
        public string Name { get; set; }
        public DrawerType DrawerType { get; set; }
        public void Draw(IVisitor drawMethod)
        {
            drawMethod.DrawOnBoard(this);
        }
    }
}
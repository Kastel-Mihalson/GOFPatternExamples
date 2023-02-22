namespace VisitorPattern
{
    public class CGDrawer : IDrawer
    {
        public string Name { get; set; }
        public DrawerType DrawerType { get; set; }
        public void Draw(IVisitor drawMethod)
        {
            drawMethod.DrawOnTablet(this);
        }
    }
}
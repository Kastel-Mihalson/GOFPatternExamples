namespace VisitorPattern
{
    public class TraditionalDrawer : IDrawer
    {
        public string Name { get; set; }
        public DrawerType DrawerType { get; set; }
        public void Draw(IVisitor drawMethod)
        {
            drawMethod.DrawOnPaper(this);
        }
    }
}
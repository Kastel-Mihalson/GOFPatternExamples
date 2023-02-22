namespace VisitorPattern
{
    public interface IVisitor
    {
        void DrawOnTablet(CGDrawer drawer);
        void DrawOnPaper(TraditionalDrawer drawer);
        void DrawOnBoard(BoardDrawer drawer);
    }
}
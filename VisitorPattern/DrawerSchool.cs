namespace VisitorPattern
{

    public class DrawerSchool
    {
        private List<IDrawer> _drawers = new List<IDrawer>();

        public void AddDrawer(IDrawer drawer)
        {
            _drawers.Add(drawer);
        }

        public void RemoveDrawer(IDrawer drawer)
        {
            _drawers.Remove(drawer);
        }

        public void ParticipateInTheEvent(IVisitor eventName)
        {
            foreach (var drawer in _drawers)
            {
                drawer.Draw(eventName);
            }
        }
    }
}
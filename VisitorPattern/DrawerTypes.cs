namespace VisitorPattern
{
    public class DrawerTypes
    {
        public static IDictionary<DrawerType, string> DrawerTypeNames = new Dictionary<DrawerType, string>
        {
            { DrawerType.CG, "Цифровой художник" },
            { DrawerType.TRADITIONAL, "традиционный художник" },
            { DrawerType.STRANGER, "Странный тип художников" },
        };
    }
}
namespace Lesson29.Classes.Countryes
{
    internal class GEO : Country
    {
        public GEO()
        {
            Truck = new Truck() { Price = 500, ShipTime = "6 hours" };
        }
    }
}

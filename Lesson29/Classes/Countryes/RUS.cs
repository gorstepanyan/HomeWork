namespace Lesson29.Classes.Countryes
{
    internal class RUS : Country
    {
        public RUS()
        {
            AirPlane = new AirPlane() { Price = 2000, ShipTime = "4 hours" };
            Truck = new Truck() { Price = 100, ShipTime = "2 months" };
        }
    }
}

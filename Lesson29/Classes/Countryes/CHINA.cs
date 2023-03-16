namespace Lesson29.Classes.Countryes
{
    internal class CHINA : Country
    {
        public CHINA()
        {
            AirPlane = new AirPlane() { Price = 300, ShipTime = "8 hours" };
            Truck = new Truck() { Price = 1500, ShipTime = "90 hours" };
        }

    }
}

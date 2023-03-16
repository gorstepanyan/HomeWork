namespace Lesson29.Classes.Countryes
{
    internal class USA : Country
    {
        public USA()
        {
            Ship = new Ship() { Price = 100, ShipTime = "2 months" };
            AirPlane = new AirPlane() { Price = 5000, ShipTime = "5 days" };
        }
    }
}

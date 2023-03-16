namespace Lesson29.Classes.Countryes
{
    internal abstract class Country
    {
        public virtual Ship Ship { get; set; }
        public virtual AirPlane AirPlane { get; set; }
        public virtual Truck Truck { get; set; }
    }
}

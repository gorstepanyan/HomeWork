using Lesson29.Interfaces;

namespace Lesson29.Classes
{
    internal class Truck : ITransport
    {
        public string ShipTime { get; set; }
        public int MaxWeight { get; set; } = 100;
        public int MinWeight { get; set; } = 1;
        public decimal Price { get; set; }
        //public int Payment { get; set; }
    }
}

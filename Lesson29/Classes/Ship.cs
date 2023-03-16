using Lesson29.Interfaces;

namespace Lesson29.Classes
{
    internal class Ship : ITransport
    {
        public string ShipTime { get; set; }
        public int MaxWeight { get; set; } = 50000;
        public int MinWeight { get; set; } = 1;
        public decimal Price { get; set; }
        //public int Payment { get; set; }
    }
}

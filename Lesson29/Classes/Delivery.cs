using Lesson29.Interfaces;

namespace Lesson29.Classes
{
    internal class Delivery : IDelivery
    {
        public string DeliveryTyme { get; set; }
        public long TrackId { get; set; }
        public decimal DeliveryCoast { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Sale { get; set; }
        public decimal TotalSum { get; set; }
    }
}

namespace Lesson29.Interfaces
{
    internal interface IDelivery
    {
        string DeliveryTyme { get; set; }
        long TrackId { get; set; }
        decimal DeliveryCoast { get; set; }
        DateTime StartDate { get; set; }
        DateTime? EndDate { get; set; }
        decimal Sale { get; set; }
        decimal TotalSum { get; set; }
    }
}

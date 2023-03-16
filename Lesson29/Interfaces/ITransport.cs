namespace Lesson29.Interfaces
{
    internal interface ITransport
    {
        string ShipTime { get; set; }
        int MaxWeight { get; set; }
        int MinWeight { get; set; }
        decimal Price { get; set; }
        //int Payment { get; set; }
    }
}

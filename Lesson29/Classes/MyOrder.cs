using Lesson29.Classes.Countryes;
using Lesson29.Interfaces;

namespace Lesson29.Classes
{
    internal class MyOrder : IOrder
    {
        private readonly long _orderId;
        private double _weight;
        public MyOrder(double weight)
        {
            _weight = weight;
            _orderId = new Random().Next(100000000, 999999999);
            Print();
            string country = ChooseCountry();
            string transport = ChooseTransport();
            CreateDelivery(country, transport);
        }

        #region Delivery
        public void CreateDelivery(string country, string transport)
        {
            ITransport transportName;
            switch (transport)
            {
                case "Ship":
                    if ((transportName = GetObject(country).Ship) == null)
                    {
                        Console.WriteLine($"{country} cannot delivery your order on {transport}");
                        return;
                    }
                    break;
                case "AirPlane":
                    if ((transportName = GetObject(country).AirPlane) == null)
                    {
                        Console.WriteLine($"{country} cannot delivery your order on {transport}");
                        return;
                    }
                    break;
                case "Truck":
                    if ((transportName = GetObject(country).Truck) == null)
                    {
                        Console.WriteLine($"{country} cannot delivery your order on {transport}");
                        return;
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }

            IDelivery delivery = new Delivery()
            {
                DeliveryTyme = transportName.ShipTime,
                StartDate = DateTime.Now,
                EndDate = null,
                TrackId = new Random().Next(100000, 1000000),
                DeliveryCoast = transportName.Price * (decimal)_weight,
                Sale = 100
            };
            delivery.TotalSum = delivery.DeliveryCoast - delivery.Sale;

            Console.WriteLine($"TrackId: {delivery.TrackId}");
            Console.WriteLine($"DeliveryTyme: {delivery.DeliveryTyme}");
            Console.WriteLine($"StartDate: {delivery.StartDate}");
            Console.WriteLine($"EndDate: {delivery.EndDate}");
            Console.WriteLine($"DeliveryCoast: {delivery.DeliveryCoast}");
            Console.WriteLine($"Sale: {delivery.Sale}");
            Console.WriteLine($"TotalSum: {delivery.TotalSum}");
        }

        #endregion

        #region Print
        public void Print()
        {
            foreach (var name in Enum.GetNames(typeof(CountryRes)))
            {
                Country obj = GetObject(name);
                if (obj.Ship != null)
                {
                    Console.WriteLine($"Order ID = {_orderId} by weight {_weight} kg can delivery from {obj.GetType().Name} on {obj.Ship.GetType().Name} in {obj.Ship.ShipTime}. It costs {obj.Ship.Price * (decimal)_weight} drams");
                }
                if (obj.AirPlane != null)
                {
                    Console.WriteLine($"Order ID = {_orderId} by weight {_weight} kg can delivery from {obj.GetType().Name} on {obj.AirPlane.GetType().Name} in {obj.AirPlane.ShipTime}. It costs {obj.AirPlane.Price * (decimal)_weight} drams");
                }
                if (obj.Truck != null)
                {
                    Console.WriteLine($"Order ID = {_orderId} by weight {_weight} kg can delivery from {obj.GetType().Name} on {obj.Truck.GetType().Name} in {obj.Truck.ShipTime}. It costs {obj.Truck.Price * (decimal)_weight} drams");
                }
                Console.WriteLine(new string('-', 20));
            }
        }
        #endregion

        #region Transport
        private string ChooseTransport()
        {
            while (true)
            {
                Console.Write("Input transport name: ");
                string transportName = Console.ReadLine();
                bool checkTransportName = CheckTransportName(transportName);
                if (!checkTransportName)
                {
                    Console.WriteLine("You eneterd wrong transport name. Pleace, try again!!!");
                }
                else
                {
                    return transportName;
                }
            }
        }

        private bool CheckTransportName(string transportName)
        {
            if (transportName == "Ship" || transportName == "AirPlane" || transportName == "Truck")
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Country
        private string ChooseCountry()
        {
            while (true)
            {
                Console.Write("Input country name: ");
                string country = Console.ReadLine();
                bool checkCountryName = CheckCountryName(country);
                if (!checkCountryName)
                {
                    Console.WriteLine("You eneterd wrong country name. Pleace, try again!!!");
                }
                else
                {
                    return country;
                }
            }
        }


        private bool CheckCountryName(string countryName)
        {
            foreach (var name in Enum.GetNames(typeof(CountryRes)))
            {
                if (name == countryName)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        private Country GetObject(string name)
        {
            Country obj;
            switch (name)
            {
                case "USA":
                    obj = new USA();
                    break;
                case "RUS":
                    obj = new RUS();
                    break;
                case "CHINA":
                    obj = new CHINA();
                    break;
                case "GEO":
                    obj = new GEO();
                    break;
                default:
                    return null;
            }
            return obj;
        }

    }
}

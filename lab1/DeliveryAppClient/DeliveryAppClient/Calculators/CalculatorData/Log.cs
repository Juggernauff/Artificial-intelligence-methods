using System;

namespace DeliveryAppClient.Calculators.CalculatorData
{
    public class Log
    {
        public decimal price { get; set; } = 0;
        public DateTime dt { get; set; } = DateTime.Now;
        public Log(decimal price)
        {
            this.price = price;
        }
        public Log()
        {

        }
    }
}

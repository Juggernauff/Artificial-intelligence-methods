using DeliveryAppClient.Calculators.CalculatorData;
using Newtonsoft.Json;
using System.IO;

namespace DeliveryAppClient.Calculators
{
    internal class Alisa : ICalculator
    {
        public decimal Calculate(dynamic tc, decimal num_km, decimal num_kg)
        {
            switch(tc.name.ToString())
            {
                case "SDEK":
                    return (tc.price_km * num_km) + (tc.price_kg * num_kg) + tc.price_insurance;
                case "UralTransit":
                    return (tc.price_km * num_km) + (tc.price_kg * num_kg);
            }
            return 0;
        }
        public bool SaveLogs(decimal price)
        {
            using (StreamWriter fs = new StreamWriter(@"D:\Code\RITG\Practice_RITG\DeliveryAppClient\DeliveryAppClient\Calculators\CalculatorData\AlisaData.json", true))
            {
                Log log = new Log(price);
                JsonSerializer js = new JsonSerializer();
                js.Serialize(fs, log);
                return true;
            }
            return false;
        }
        public decimal CountPackaging()
        {
            // Посчитать упаковку + получить из бд данные по тк. + сервер (нет функции).
            return 0;
        }
    }
}

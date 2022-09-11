using DeliveryAppClient.Calculators.CalculatorData;
using System.IO;
using System.Xml.Serialization;

namespace DeliveryAppClient.Calculators
{
    internal class Oleg : ICalculator
    {
        public decimal Calculate(dynamic tc, decimal num_km, decimal num_kg)
        {
            switch (tc.name.ToString())
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
            Log log = new Log(price);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Log));

            using (FileStream fs = new FileStream(@"D:\Code\RITG\Practice_RITG\DeliveryAppClient\DeliveryAppClient\Calculators\CalculatorData\OlegData.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, log);
                return true;
            }
        }
        public decimal CountPackaging(dynamic tc)
        {
            // Посчитать упаковку + получить из бд данные по тк. + сервер (нет функции).
            return 0;
        }
    }
}

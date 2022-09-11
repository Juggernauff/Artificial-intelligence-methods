using System;
using System.Data.SqlClient;

namespace DeliveryAppClient.Calculators
{
    internal class Marusya : ICalculator
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
            var sqlConnection = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\RITG\Practice_RITG\DeliveryAppClient\DeliveryAppClient\Calculators\CalculatorData\Marusya.mdf;Integrated Security=True");
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [MarusyaLogs] (price, dateTime) " +
                    $"VALUES (@price, @dateTime); ",
                    sqlConnection);

                command.Parameters.AddWithValue("price", price);
                command.Parameters.AddWithValue("dateTime", DateTime.Now);

                bool result = Convert.ToBoolean(command.ExecuteNonQuery());
                sqlConnection.Close();
                return result;
            }
            catch
            {
                sqlConnection.Close();
                return false;
            }
        }
        public decimal CountPackaging(dynamic tc)
        {
            // Посчитать упаковку + получить из бд данные по тк. + сервер (нет функции).
            return 0;
        }
    }
}

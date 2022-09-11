namespace DeliveryAppClient.Calculators
{
    internal interface ICalculator
    {
        decimal Calculate(object tc, decimal num_km, decimal num_kg);
        bool SaveLogs(decimal price);
        //decimal CountPackaging(dynamic tc);
    }
}

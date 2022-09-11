namespace TransportCompany2
{
    public class UralTransit
    {
        public int id { get; set; } = -1;
        public string name { get; set; }  = "UralTransit";
        public decimal price_km { get; set; } = 0;
        public decimal price_kg { get; set; } = 0;

        public UralTransit(int id, decimal price_km, decimal price_kg) // СЕРВЕР: Отвечает клиенту, если такая транспортная компания существует.
        {
            this.id = id;
            this.price_km = price_km;
            this.price_kg = price_kg;
        }
        public UralTransit() { }
    }
}

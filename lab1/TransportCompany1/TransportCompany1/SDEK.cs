namespace TransportCompany1
{
    public class SDEK
    {
        public int id { get; set; } = -1;
        public string name { get; set; } = "SDEK";
        public decimal price_km { get; set; } = 0;
        public decimal price_kg { get; set; } = 0;
        public decimal price_insurance { get; set; } = 0;

        public SDEK(int id, decimal price_km, decimal price_kg, decimal price_insurance)
        {
            this.id = id;
            this.price_km = price_km;
            this.price_kg = price_kg;
            this.price_insurance = price_insurance;
        }
        public SDEK() { }
    }
}

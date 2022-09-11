namespace DeliveryAppServer
{
    public class Order
    {
        public int id { get; set; } = 0;
        public int userId { get; set; } = 0;
        public string whereFrom { get; set; }
        public bool fromDoor { get; set; }
        public string whereTo { get; set; }
        public bool toDoor { get; set; }
        public decimal weight { get; set; } = 0;
        public decimal volume { get; set; } = 0;
        public decimal price { get; set; } = 0;
        public DateTime DateTime { get; set; }

        public Order(int userId, string whereFrom, bool fromDoor, string whereTo, bool toDoor, decimal weight, decimal volume, decimal price, DateTime DateTime)
        {
            this.userId = userId;
            this.whereFrom = whereFrom;
            this.whereTo = whereTo;
            this.toDoor = toDoor;
            this.weight = weight;
            this.volume = volume;
            this.price = price;
            this.DateTime = DateTime;
        }
    }
}

namespace Tourism
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TourId { get; set; }
        public string Date { get; set; }
        public int Time { get; set; }

        public virtual Client Client { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
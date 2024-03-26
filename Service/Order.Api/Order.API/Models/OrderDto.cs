namespace Order.API.Models
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public string CustomerName { get; set; }
        public long TotalPrice { get; set; }
        public int ItemCount  { get; set; }
    }
}

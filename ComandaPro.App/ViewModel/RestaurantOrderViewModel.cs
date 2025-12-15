namespace ComandaPro.App.ViewModel
{
    public class RestaurantOrderViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public decimal TotalValue { get; set; }
    }
}

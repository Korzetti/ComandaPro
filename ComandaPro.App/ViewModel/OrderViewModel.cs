namespace ComandaPro.App.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date_Time { get; set; }
        public string Status { get; set; }
        public Decimal TotalValue { get; set; }
    }
}

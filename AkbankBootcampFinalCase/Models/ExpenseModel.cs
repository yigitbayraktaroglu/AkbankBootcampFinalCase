namespace AkbankBootcampFinalCase.Models
{
    public class ExpenseModel
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string PaymentInstrument { get; set; }
        public string Location { get; set; }
        public decimal Cost { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Updated { get; set; }
    }
}

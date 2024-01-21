namespace AkbankBootcampFinalCase.Models
{
    public class EmployeeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string IBAN { get; set; }
        public List<ExpenseModel> Expenses { get; set; }
    }
}

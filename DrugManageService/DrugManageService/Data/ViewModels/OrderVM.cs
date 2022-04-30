namespace DrugManageService.Data.ViewModels
{
    public class OrderVM
    {
        public string DrugName { get; set; }
        public int DrugQty { get; set; }
        public double DrugPrice { get; set; }
        public string Description { get; set; }
        public string PharmacyName { get; set; }
        public string PharmacyAddress { get; set; }
        public string PharmacyCity { get; set; }
        public int PharmacyContactNO { get; set; }
    }
}

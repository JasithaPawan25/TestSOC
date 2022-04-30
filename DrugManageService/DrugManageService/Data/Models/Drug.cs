﻿namespace DrugManageService.Data.Models
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string SupplierName { get; set; }
        public string Discription { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime MnfDate { get; set; }
        public string brandName { get; set; }
    }
}

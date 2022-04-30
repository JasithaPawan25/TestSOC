using DrugManageService.Data.Models;
using DrugManageService.Data.ViewModels;

namespace DrugManageService.Data.Services
{
    public class DrugsService
    {
        private AppDbContext _context;
        public DrugsService(AppDbContext context)
        {
            _context = context;

        }

        public void AddDrug(DrugVM drug)
        {
            var _drug = new Drug()
            {
              //  Id=drug.Id,
                Name = drug.Name,
                Price = drug.Price,
                SupplierName = drug.SupplierName,
                Discription = drug.Discription,
                Quantity = drug.Quantity,
                ExpDate = drug.ExpDate,
                MnfDate = drug.MnfDate,
                brandName = drug.brandName



            };

            _context.Drugsmm.Add(_drug);
            _context.SaveChanges();

        }

        public List<Drug> GetAllDrugs() => _context.Drugsmm.ToList();

        public Drug GetDrugById(int DrugId) => _context.Drugsmm.FirstOrDefault(n => n.Id == DrugId);


        public Drug UpdateDrugById(int drugId, DrugVM drug)
        {
            var _drug = _context.Drugsmm.FirstOrDefault(n => n.Id == drugId);

            if (_drug != null)
            {
                _drug.Name = drug.Name;
                _drug.Price = drug.Price;
                _drug.SupplierName = drug.SupplierName;
                _drug.Discription = drug.Discription;
                _drug.Quantity = drug.Quantity;
                _drug.ExpDate = drug.ExpDate;
                _drug.MnfDate = drug.MnfDate;
                _drug.brandName = drug.brandName;


                _context.SaveChanges();

            }
            return _drug;
        }

        public void DeleteDrugById(int drugId)
        {
            var _drug = _context.Drugsmm.FirstOrDefault(n => n.Id == drugId);
            if (_drug != null)
            {
                _context.Drugsmm.Remove(_drug);
                _context.SaveChanges();
            }
        }




    }
}

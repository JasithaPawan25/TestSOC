using DrugManageService.Data.Models;
using DrugManageService.Data.ViewModels;

namespace DrugManageService.Data.Services
{
    public class SuppliersService
    {
        private AppDbContext _context;
        public SuppliersService(AppDbContext context)
        {
            _context = context;

        }

        public void AddSupplier(SupplierVM supplier)
        {
            var _supplier = new Supplier()
            {
                Name = supplier.Name,
                Address = supplier.Address,
                Contact = supplier.Contact,
                DrugName = supplier.DrugName,
                price = supplier.price
            };
            _context.Suppliers.Add(_supplier);
            _context.SaveChanges();

        }
    
        public List<Supplier>GetAllSuppliers() => _context.Suppliers.ToList();

        public Supplier GetSupplierById(int SupplierId) => _context.Suppliers.FirstOrDefault(n => n.id == SupplierId);

        public Supplier GetSupplierByName(string SupplierName) => _context.Suppliers.FirstOrDefault(n => n.Name == SupplierName);

        public Supplier UpdateSupplierById(int supplierId, SupplierVM supplier)
        {
            var _supplier = _context.Suppliers.FirstOrDefault(n=>n.id == supplierId);

            if (_supplier != null)
            {
                _supplier.Name = supplier.Name;
                _supplier.Address = supplier.Address;
                _supplier.Contact = supplier.Contact;
                _supplier.DrugName = supplier.DrugName;
                _supplier.price = supplier.price;


                _context.SaveChanges();

            }
            return _supplier;
        }

        public void DeleteSupplierById(int supplierId)
        {
            var _supplier = _context.Suppliers.FirstOrDefault(n => n.id == supplierId);
            if (_supplier != null)
            {
                _context.Suppliers.Remove(_supplier);
                _context.SaveChanges();
            }
        }

    }
}

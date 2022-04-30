using DrugManageService.Data.Models;
using DrugManageService.Data.ViewModels;

namespace DrugManageService.Data.Services
{
    public class OrdersService
    {
        private AppDbContext _context;
        public OrdersService(AppDbContext context)
        {
            _context = context;

        }

        public void AddOrder(OrderVM order)
        {
            var _order = new Order()
            {
                //  Id=drug.Id,
                DrugName = order.DrugName,
                DrugQty = order.DrugQty,
                DrugPrice = order.DrugPrice,
                Description = order.Description,
                PharmacyName = order.PharmacyName,
                PharmacyAddress = order.PharmacyAddress,
                PharmacyCity = order.PharmacyCity,
                PharmacyContactNO = order.PharmacyContactNO



            };

            _context.Ordersm.Add(_order);
            _context.SaveChanges();

        }

        public List<Order> GetAllOrders() => _context.Ordersm.ToList();

        public Order GetOrderById(int OrderId) => _context.Ordersm.FirstOrDefault(n => n.id == OrderId);



        public Order UpdateOrderById(int OrderId, OrderVM order)
        {
            var _order = _context.Ordersm.FirstOrDefault(n => n.id == OrderId);

            if (_order != null)
            {


                _order.DrugName = order.DrugName;
                _order.DrugQty = order.DrugQty;
                _order.DrugPrice = order.DrugPrice;
                _order.Description = order.Description;
                _order.PharmacyName = order.PharmacyName;
                _order.PharmacyAddress = order.PharmacyAddress;
                _order.PharmacyCity = order.PharmacyCity;
                _order.PharmacyContactNO = order.PharmacyContactNO;
          


                _context.SaveChanges();

            }
            return _order;
        }

        public void DeleteOrderById(int orderId)
        {
            var _order = _context.Ordersm.FirstOrDefault(n => n.id == orderId);
            if (_order != null)
            {
                _context.Ordersm.Remove(_order);
                _context.SaveChanges();
            }
        }



    }
}

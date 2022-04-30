using DrugManageService.Data.Services;
using DrugManageService.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrugManageService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        public SuppliersService _suppliersService;

        public SuppliersController(SuppliersService suppliersService)
        {
            _suppliersService = suppliersService;
        }

        [HttpGet("all-suppliers")]

        public IActionResult GetAllSuppliers()
        {
            var allSuppliers = _suppliersService.GetAllSuppliers();
            return Ok(allSuppliers);
        }

        [HttpGet("get-supplier-by-id/{id}")]

        public IActionResult GetSupplierById(int id)
        {
            var Supplier = _suppliersService.GetSupplierById(id);
            if (Supplier != null)
            {
                return Ok(Supplier);
            }
            return NotFound();

        }

        [HttpGet("get-supplier-by-name/{name}")]

        public IActionResult GetSupplierByName(string name)
        {
            var Supplier = _suppliersService.GetSupplierByName(name);
            if (Supplier != null)
            {
                return Ok(Supplier);
            }
            return NotFound();
        }



        [HttpPost("add-supplier")]

        public IActionResult AddSupplier([FromBody] SupplierVM supplier)
        {
            _suppliersService.AddSupplier(supplier);
            return Ok();

        }

        [HttpPut("update-supplier-by-id/{id}")]

        public IActionResult UpdateSupplierById(int id, [FromBody] SupplierVM supplier)
        {
            var updatedSupplier = _suppliersService.UpdateSupplierById(id, supplier);
            return Ok(updatedSupplier);

        }

        [HttpDelete("delete-supplier-by-id/{id}")]
        public IActionResult DeleteSupplierById(int id)
        {
            _suppliersService.DeleteSupplierById(id);
            return Ok();
            
        }




    }
}

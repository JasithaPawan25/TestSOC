using DrugManageService.Data.Services;
using DrugManageService.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrugManageService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugsController : ControllerBase
    {
        private DrugsService _drugsService;

        public DrugsController(DrugsService drugsService)
        {
            _drugsService = drugsService;

        }

        [HttpGet("all-drugs")]

        public IActionResult GetAllDrugs()
        {
            var allDrugs = _drugsService.GetAllDrugs();
            return Ok(allDrugs);
        }

        [HttpGet("get-drug-by-id/{id}")]

        public IActionResult GetDrugById(int id)
        {
            var Drug = _drugsService.GetDrugById(id);
            return Ok(Drug);
        }

        [HttpPost("add-Drug")]

        public IActionResult AddDrug([FromBody] DrugVM drug)
        {
            _drugsService.AddDrug(drug);
            return Ok();

        }




        [HttpPut("update-drug-by-id/{id}")]

        public IActionResult UpdateDrugById(int id, [FromBody] DrugVM drug)
        {
            var updatedDrug = _drugsService.UpdateDrugById(id, drug);
            return Ok(updatedDrug);

        }

        [HttpDelete("delete-drug-by-id/{id}")]
        public IActionResult DeleteDrugById(int id)
        {
            _drugsService.DeleteDrugById(id);
            return Ok();

        }




    }
}

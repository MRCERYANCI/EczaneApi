using EczaneApi.Repositories.DrugRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EczaneApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugsController : ControllerBase
    {
        private readonly IDrugRepository _drugRepository;

        public DrugsController(IDrugRepository drugRepository)
        {
            _drugRepository = drugRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDrug()
        {
            return Ok(await _drugRepository.GetAllResultDrugAsync());
        }

        [HttpGet("GetResultBarcodeDrug/{barcode}")]
        public async Task<IActionResult> GetResultBarcodeDrug(decimal barcode)
        {
            return Ok(await _drugRepository.GetResultDrugAsync(barcode));
        }
    }
}

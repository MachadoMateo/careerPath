using MASCareerPath.Service.Interface;
using Microsoft.AspNetCore.Mvc;
namespace MASCareerPath.Web.Controllers
{
	[ApiController]
    [Route("[controller]")]
    
    public class SeniorityValuesController : ControllerBase
	{
		private readonly ISeniorityService _serviceSeniority;

        public  SeniorityValuesController(ISeniorityService service)
        {
			_serviceSeniority = service;       
        }

        [HttpGet]
        public IActionResult GetAllsSeniority() 
        {
            var seniorities = _serviceSeniority.GetSeniorityList();
            return Ok(seniorities);
        } 

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var senioritiesId = _serviceSeniority.GetById(Id);

            if (senioritiesId == null)
            {
                return NotFound();
            }
            else {
                return Ok(senioritiesId);
            }
        }
    }
}

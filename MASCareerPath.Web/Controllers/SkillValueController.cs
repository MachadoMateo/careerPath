using MASCareerPath.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MASCareerPath.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkillValueController : ControllerBase
    {
		private readonly ISkillValueService serviceSkillValue;
		public SkillValueController(ISkillValueService service)
		{
			serviceSkillValue = service;
		}

        [HttpGet]
        public IActionResult DeserializaserJsonSkillCurrent()
        {
            var DeserializaserFile = serviceSkillValue.DeserializaserJsonSkillCurrent();

            if (DeserializaserFile == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(DeserializaserFile);
            }
        }
    }
}

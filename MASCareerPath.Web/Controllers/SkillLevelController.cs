using MASCareerPath.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MASCareerPath.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkillLevelController : ControllerBase
    {
        private readonly ISkillLevelService _serviceSkillLevel;
        public SkillLevelController(ISkillLevelService service)
        {
            _serviceSkillLevel = service;
        }

        [HttpGet]
        public IActionResult GetSkillLevelList()
        {
            var levelAll = _serviceSkillLevel.GetSkillLevelList();
            if (levelAll == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(levelAll);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var levelId = _serviceSkillLevel.GetSkillLevel(Id);

            if (levelId == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(levelId);
            }
        }
    }
}

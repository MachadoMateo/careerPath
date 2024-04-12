using MASCareerPath.Model.Entity;
using System.Text.Json.Serialization;
namespace MASCareerPath.Models.Entity
{
	public class SkillsGeneral
	{
		[JsonPropertyName("role")]
		public string Role { get; set; }
		[JsonPropertyName("requirement")]
        public List<SkillProperty> Requirement { get; set; }
		[JsonPropertyName("softSkill")]
		public List<SkillProperty> SoftSkills { get; set; }
		[JsonPropertyName("techSkill")]
		public List<SkillProperty> TechSkills { get; set; }

		

		
    }
}

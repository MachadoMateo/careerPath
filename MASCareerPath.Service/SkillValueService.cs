using MASCareerPath.Models.Entity;
using MASCareerPath.Service.Interface;
using System.Text.Json;


namespace MASCareerPath.Service
{
    public class SkillValueService : ISkillValueService
    {
        public SkillsGeneral  DeserializaserJsonSkillCurrent()
        {
            string myFileValueCurrent = File.ReadAllText("JsonFile\\SkillCurrent.json");

            SkillsGeneral? skillsGeneral = JsonSerializer.Deserialize<SkillsGeneral>(myFileValueCurrent);
            if (skillsGeneral == null) throw new Exception("Json was not found");

            return skillsGeneral;

        }
    }
}

using MASCareerPath.Models.Entity;
using MASCareerPath.Service.Interface;

namespace MASCareerPath.Service
{
    public class SkillLevelService : ISkillLevelService
    {
		private List<SkillLevel> _listSkillLevel;

		//List with values for id
		public List<SkillLevel> CreateSkillLevel()
        {
            SkillLevelService _listSkillLevel = new SkillLevelService();

            return new List<SkillLevel> {

                _listSkillLevel.Create(0,0, "None"),
                _listSkillLevel.Create(1,1, "Basic"),
                _listSkillLevel.Create(2,2, "Basic-Intermediate"),
                _listSkillLevel.Create(3,3, "Intermediate"),
                _listSkillLevel.Create(4,4, "Intermediate-Advance"),
                _listSkillLevel.Create(5,5, "Advance"),

           };
        }

        public List<SkillLevel> GetSkillLevelList()
        {

			return CreateSkillLevel();
        }

        public SkillLevel Create(int Id,int ValueSkill, string Name)
        {
            return new SkillLevel(Id, ValueSkill, Name);
        }

        //get skills for values type int of list skill
        public SkillLevel? GetSkillLevel(int Id)
        {
            try
            {
                SkillLevelService ServiceDataValue = new();

                var skillsLevel = ServiceDataValue.CreateSkillLevel();

                if (skillsLevel != null)
                {
                    foreach (SkillLevel level in skillsLevel)
                    {
                        if (level.ValueSkill == Id)

                            return level;
                    }
                }
                return null;
            }
            catch (Exception e) { throw new Exception("Not found"); }
        }
    }
}

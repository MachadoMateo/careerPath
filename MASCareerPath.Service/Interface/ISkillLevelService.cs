using MASCareerPath.Models.Entity;

namespace MASCareerPath.Service.Interface
{
    public interface ISkillLevelService
    {
        List<SkillLevel> CreateSkillLevel();

        public SkillLevel Create(int Id, int ValueSkill, string Name);

        public SkillLevel? GetSkillLevel(int Id);
        public List<SkillLevel>  GetSkillLevelList();

    }
}

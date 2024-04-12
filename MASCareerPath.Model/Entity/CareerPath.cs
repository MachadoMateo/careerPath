namespace MASCareerPath.Models.Entity
{
    public class CareerPath
    {
        public Guid Id { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public IList<Seniority> Seniority { get; set; }
        public IList<SkillsGeneral> SkillsGeneral { get; set; }

    }
}

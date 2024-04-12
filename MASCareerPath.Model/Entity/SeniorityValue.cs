namespace MASCareerPath.Models.Entity
{
    public class SeniorityValue
    {
        public Guid Id { get; set; }
        public Guid SeniorityId { get; set; }
        public IList<SkillValue> SkillsValues { get; set; }

    }
}

namespace MASCareerPath.Models.Entity
{
    public class SkillLevel
    {
        public int Id { get; set; }
        public int ValueSkill { get; set; }
        public string Name { get; set; }

		public SkillLevel(int id, int valueSkill, string name)
		{
			Id = id;
			ValueSkill = valueSkill;
			Name = name;
		}

		public SkillLevel()
        {
        }
    }
}

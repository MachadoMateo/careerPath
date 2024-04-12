namespace MASCareerPath.Models.Entity
{
    public class Seniority
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //I want create a TYPE seniority
        public Seniority(string Name)
        {
            this.Name = Name;
        }

        public Seniority()
        {
        }
    }
}

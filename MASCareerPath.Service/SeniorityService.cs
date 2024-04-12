using MASCareerPath.Models.Entity;
using MASCareerPath.Models.Enum;
using MASCareerPath.Service.Interface;

namespace MASCareerPath.Service
{
    public class SeniorityService : ISeniorityService
    {
        public List<Seniority> listSeniorities = new List<Seniority>() {

                new Seniority(){Id = 0, Name = "Trainee"},
                new Seniority(){Id = 1, Name = "Junior"},
                new Seniority(){Id = 2, Name = "Mid-Senior"},
                new Seniority(){Id = 3, Name = "Senior"},
                new Seniority(){Id = 4, Name = "Principal"},
                new Seniority(){Id = 5, Name = "Advanced"}

        };

        public Seniority CreateValueSeniority(SeniorityType Type)
        {
            switch (Type)
            {
                case SeniorityType.Trainee:
                    return new Seniority("Trainee");

                case SeniorityType.Junior:
                    return new Seniority("Junior");

                case SeniorityType.MidSenior:
                    return new Seniority("MidSenior");

                case SeniorityType.Senior:
                    return new Seniority("Senior");

                case SeniorityType.Principal:
                    return new Seniority("Principal");

                case SeniorityType.Advanced:
                    return new Seniority("Advanced");

                default:
                    throw new NotSupportedException("type Seniority not fount");
            }
        }
        

        public Seniority? GetById(int Id)
        {
            return listSeniorities.FirstOrDefault(x => x.Id == Id);
        }

        public List<Seniority> GetSeniorityList()
        {
            return listSeniorities;
        }
    }
}

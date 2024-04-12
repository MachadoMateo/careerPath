using MASCareerPath.Models.Entity;
using MASCareerPath.Models.Enum;

namespace MASCareerPath.Service.Interface
{
    public interface ISeniorityService
    {
        public List<Seniority> GetSeniorityList();

        public Seniority? GetById(int Id);

        public Seniority CreateValueSeniority(SeniorityType Type);



    }
}

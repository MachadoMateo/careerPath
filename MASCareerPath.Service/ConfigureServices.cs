using MASCareerPath.Models.Entity;
using MASCareerPath.Service.Interface;
using Microsoft.Extensions.DependencyInjection;


namespace MASCareerPath.Service
{
    public  static class ConfigureServices
    {
        public static void ConfigureServicesDependency(IServiceCollection services)
        {

            services.AddScoped<ISeniorityService, SeniorityService>();

            services.AddScoped<ISkillLevelService, SkillLevelService>();

            services.AddScoped<ISkillValueService, SkillValueService>();
        }
    }
}

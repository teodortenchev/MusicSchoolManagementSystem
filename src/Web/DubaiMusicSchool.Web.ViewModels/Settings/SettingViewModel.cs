namespace DubaiMusicSchool.Web.ViewModels.Settings
{
    using DubaiMusicSchool.Data.Models;
    using DubaiMusicSchool.Services.Mapping;

    using AutoMapper;

    public class SettingViewModel : IMapFrom<Courses>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string NameAndValue { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            //configuration.CreateMap<Courses, SettingViewModel>().ForMember(
            //    m => m.NameAndValue,
            //    opt => opt.MapFrom(x => x.Name + " = " + x.Value));
        }
    }
}

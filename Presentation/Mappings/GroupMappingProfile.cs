using AutoMapper;
using VitruviSoft.SamvelAvagyan.Presentation.Models;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Presentation.Mappings
{
    public class GroupMappingProfile : Profile
    {
        public GroupMappingProfile()
        {
            CreateMap<GroupViewModel, Group>()
                .ForMember(m => m.Active, p => p.Ignore())
                .ForMember(m => m.CreatedOn, p => p.Ignore())
                .ForMember(m => m.ModifiedOn, p => p.Ignore())
                .ForMember(m => m.Providers, p => p.Ignore());
        }
    }
}

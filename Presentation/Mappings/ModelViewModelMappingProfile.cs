using AutoMapper;
using VitruviSoft.SamvelAvagyan.Presentation.Models;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Presentation.Mappings
{
    public class ModelViewModelMappingProfile : Profile
    {
        public ModelViewModelMappingProfile()
        {
            CreateMap<Group, GroupViewModel>()
                .ForMember(m => m.Id, cfg => cfg.MapFrom(vm => vm.Id))
                .ForMember(m => m.Name, cfg => cfg.MapFrom(vm => vm.Name))
                .ForMember(m => m.Type, cfg => cfg.MapFrom(vm => vm.Type));

            CreateMap<Provider, ProviderViewModel>()
                .ForMember(m => m.Id, cfg => cfg.MapFrom(vm => vm.Id))
                .ForMember(m => m.Name, cfg => cfg.MapFrom(vm => vm.Name))
                .ForMember(m => m.Type, cfg => cfg.MapFrom(vm => vm.Type))
                .ForMember(m => m.GroupId, cfg => cfg.MapFrom(vm => vm.GroupId));
        }
    }
}

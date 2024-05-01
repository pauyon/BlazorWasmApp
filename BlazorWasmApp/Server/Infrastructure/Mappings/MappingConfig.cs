using AutoMapper;
using BlazorWasmApp.Shared.Domain.Dtos;
using BlazorWasmApp.Shared.Domain.Entities;

namespace BlazorWasmApp.Server.Infrastructure.Mappings;

public class MappingConfig : Profile
{
    public MappingConfig()
    {
        CreateMap<Camera, CameraDto>().ReverseMap();
        CreateMap<Accessory, AccessoryDto>().ReverseMap();
    }
}

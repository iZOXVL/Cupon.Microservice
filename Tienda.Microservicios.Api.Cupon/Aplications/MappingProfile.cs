using AutoMapper;
using Tienda.Microservicios.Api.Cupon.Models.Dto;

namespace Tienda.Microservicios.Api.Cupon.Aplications
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<CuponDto, Cupon.Models.Cupon>();
            CreateMap<Cupon.Models.Cupon, CuponDto>();
        }
    }
}

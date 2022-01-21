using AutoMapper;
using RestApiAts.Application.Dtos;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Mappers 
{
   public class DtoToModelMappingVaga : Profile
    {

        public DtoToModelMappingVaga()
        {
            VagaMap();
        }

        private void VagaMap()
        {

            CreateMap<VagaDto, Vaga>()
               .ForMember(vag => vag.Id, opt => opt.MapFrom(x => x.Id))
               .ForMember(vag => vag.Descricao, opt => opt.MapFrom(x => x.Descricao))
               .ForMember(vag => vag.Requisitos, opt => opt.MapFrom(x => x.Requisitos))
               .ForMember(vag => vag.DataInicio, opt => opt.MapFrom(x => x.DataInicio))
               .ForMember(vag => vag.DataFim, opt => opt.MapFrom(x => x.DataFim))
               .ForMember(vag => vag.IsAtivo, opt => opt.MapFrom(x => x.IsAtivo));
        }
    }
}

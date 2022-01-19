using AutoMapper;
using RestApiAts.Application.Dtos;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Mappers
{
   public class ModelToDtoMappingVaga : Profile
    {

        public ModelToDtoMappingVaga()
        {
            VagaDtoMap();
        }

        private void VagaDtoMap()
        {

            CreateMap<Vaga, VagaDto>()
                .ForMember(can => can.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(can => can.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(can => can.DataInicio, opt => opt.MapFrom(x => x.DataInicio))
                .ForMember(can => can.DataFim, opt => opt.MapFrom(x => x.DataFim))
                .ForMember(can => can.Requisitos, opt => opt.MapFrom(x => x.Requisitos));
        }
    }
}

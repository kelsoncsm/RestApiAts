using AutoMapper;
using RestApiAts.Application.Dtos;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace RestApiAts.Application.Mappers
{
    public class ModelToDtoMappingCandidato  : Profile
    {

        public ModelToDtoMappingCandidato()
        {
            CandidatoDtoMap();
        }

        private void CandidatoDtoMap()
        {

            CreateMap<Candidato, CandidatoDto>()
                .ForMember(can => can.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(can => can.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(can => can.SobreNome, opt => opt.MapFrom(x => x.SobreNome))
                .ForMember(can => can.Email, opt => opt.MapFrom(x => x.Email));
        }
    }
}

using AutoMapper;
using RestApiAts.Application.Dtos;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Mappers
{
    public class DtoToModelMappingCandidato : Profile
    {
        public DtoToModelMappingCandidato()
        {
           CandidatoMap();
        }

        private void CandidatoMap()
        {

            CreateMap<CandidatoDto, Candidato>()
               .ForMember(cand => cand.Id, opt => opt.Ignore())
               .ForMember(cand => cand.Nome, opt => opt.MapFrom(x => x.Nome))
               .ForMember(cand => cand.SobreNome, opt => opt.MapFrom(x => x.SobreNome))
               .ForMember(cand => cand.Email, opt => opt.MapFrom(x => x.Email))
               .ForMember(cand => cand.DataCadastro, opt => opt.Ignore())
               .ForMember(cand => cand.IsAtivo, opt => opt.Ignore());
        }
    }
}

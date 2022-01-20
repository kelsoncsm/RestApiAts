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
               .ForMember(cand => cand.Id, opt => opt.MapFrom(x => x.Id))
               .ForMember(cand => cand.Nome, opt => opt.MapFrom(x => x.Nome))
               .ForMember(cand => cand.SobreNome, opt => opt.MapFrom(x => x.SobreNome))
               .ForMember(cand => cand.Email, opt => opt.MapFrom(x => x.Email))
               .ForMember(cand => cand.Cpf, opt => opt.MapFrom(x => x.Cpf))
               .ForMember(cand => cand.Objetivo, opt => opt.MapFrom(x => x.Objetivo))
               .ForMember(cand => cand.DataCadastro, opt => opt.MapFrom(x => x.DataCadastro))
               .ForMember(cand => cand.IsAtivo, opt => opt.MapFrom(x => x.IsAtivo));
        }
    }
}

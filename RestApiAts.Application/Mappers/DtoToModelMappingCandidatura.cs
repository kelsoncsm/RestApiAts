using AutoMapper;
using RestApiAts.Application.Dtos;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application.Mappers
{
    public class DtoToModelMappingCandidatura : Profile
    {
        public DtoToModelMappingCandidatura()
        {
            CandidadaturaMap();
        }

        private void CandidadaturaMap()
        {

            CreateMap<CandidaturaDto, Candidatura>()
               .ForMember(cand => cand.Id, opt => opt.MapFrom(x => x.Id));
            //.ForMember(cand => cand.Vaga, opt => opt.MapFrom(x => x.VagaDto));



        }
    }
}

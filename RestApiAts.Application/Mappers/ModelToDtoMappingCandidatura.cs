using AutoMapper;
using RestApiAts.Application.Dtos;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace RestApiAts.Application.Mappers
{
    public class ModelToDtoMappingCandidatura : Profile
    {

        public ModelToDtoMappingCandidatura()
        {
            CandidaturaDtoMap();
        }

        private void CandidaturaDtoMap()
        {

            CreateMap<Candidatura, CandidaturaDto>()
                .ForMember(can => can.Id, opt => opt.MapFrom(x => x.Id));
        }
    }
}

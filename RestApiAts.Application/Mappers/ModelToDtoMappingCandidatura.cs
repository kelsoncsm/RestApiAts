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
                .ForMember(can => can.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(can => can.Nome, opt => opt.MapFrom(x => String.Format("{0} {1}", x.Candidato.Nome, x.Candidato.SobreNome)))
                .ForMember(can => can.Descricao, opt => opt.MapFrom(x => x.Vaga.Descricao))
                .ForMember(can => can.DataInicio, opt => opt.MapFrom(x => x.Vaga.DataInicio))
                .ForMember(can => can.DataFim, opt => opt.MapFrom(x => x.Vaga.DataFim));
        }
    }
}

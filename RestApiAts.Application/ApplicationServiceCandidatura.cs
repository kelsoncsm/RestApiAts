using AutoMapper;
using RestApiAts.Application.Dtos;
using RestApiAts.Application.Interface;
using RestApiAts.Domain.Core.Interfaces.Services;
using RestApiAts.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Application
{
    public class ApplicationServiceCandidatura : IApplicationServiceCandidatura
    {
        private readonly IServiceCandidatura serviceCandidatura;
        private readonly IMapper mapper;
        public ApplicationServiceCandidatura(IServiceCandidatura serviceCandidatura
                                       , IMapper mapper)
        {
            this.serviceCandidatura = serviceCandidatura;
            this.mapper = mapper;
        }

        public IEnumerable<CandidaturaDto> GetAll()
        {
            var candidaturas = serviceCandidatura.GetAll2();
            var candidaturasDto = mapper.Map<IEnumerable<CandidaturaDto>>(candidaturas);

            return candidaturasDto;
        }

        public CandidaturaDto GetById(int id)
        {
            var candidatura = serviceCandidatura.GetById(id);
            var candidaturaDto = mapper.Map<CandidaturaDto>(candidatura);

            return candidaturaDto;
        }


        public IEnumerable<CandidaturaDto> GetListaVagasAtivas(int idCandidato)
        {
            var candidaturas = serviceCandidatura.GetListaVagasAtivas(idCandidato);
            var candidaturasDto = mapper.Map<IEnumerable<CandidaturaDto>>(candidaturas);

            return candidaturasDto;
        }


        public void Update(CandidaturaDto candidaturaDto)
        {
            var cliente = mapper.Map<Candidatura>(candidaturaDto);
            serviceCandidatura.Update(cliente);
        }

        public void Add(CandidaturaDto candidaturaDto)
        {
            var candidato = mapper.Map<Candidatura>(candidaturaDto);
            serviceCandidatura.Add(candidato);
        }



    }
}

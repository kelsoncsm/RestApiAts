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
            var candidatos = serviceCandidatura.GetAll2();
            var candidatosDto = mapper.Map<IEnumerable<CandidaturaDto>>(candidatos);

            return candidatosDto;
        }

        public CandidaturaDto GetById(int id)
        {
            var cliente = serviceCandidatura.GetById(id);
            var candidatoDto = mapper.Map<CandidaturaDto>(cliente);

            return candidatoDto;
        }


        public IEnumerable<CandidaturaDto> GetListaVagasAtivas(int idCandidato)
        {
            var candidatos = serviceCandidatura.GetListaVagasAtivas(idCandidato);
            var candidatosDto = mapper.Map<IEnumerable<CandidaturaDto>>(candidatos);

            return candidatosDto;
        }


        public void Update(CandidaturaDto candidaturaDto)
        {
            var cliente = mapper.Map<Candidatura>(candidaturaDto);
            serviceCandidatura.Update(cliente);
        }


    }
}

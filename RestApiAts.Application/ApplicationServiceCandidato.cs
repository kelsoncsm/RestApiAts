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
    public class ApplicationServiceCandidato : IApplicationServiceCandidato
    {
        private readonly IServiceCandidato serviceCandidato;
        private readonly IMapper mapper;
        public ApplicationServiceCandidato(IServiceCandidato serviceCandidato
                                       , IMapper mapper)
        {
            this.serviceCandidato = serviceCandidato;
            this.mapper = mapper;
        }
        public void Add(CandidatoDto candidatoDto)
        {
            var cliente = mapper.Map<Candidato>(candidatoDto);
            serviceCandidato.Add(cliente);
        }

        public IEnumerable<CandidatoDto> GetAll()
        {
            var candidatos = serviceCandidato.GetAll();
            var candidatosDto = mapper.Map<IEnumerable<CandidatoDto>>(candidatos);

            return candidatosDto;
        }

        public CandidatoDto GetById(int id)
        {
            var cliente = serviceCandidato.GetById(id);
            var candidatoDto = mapper.Map<CandidatoDto>(cliente);

            return candidatoDto;
        }

        public void Remove(CandidatoDto candidatoDto)
        {
            var cliente = mapper.Map<Candidato>(candidatoDto);
            serviceCandidato.Remove(cliente);
        }

        public void Update(CandidatoDto candidatoDto)
        {
            var cliente = mapper.Map<Candidato>(candidatoDto);
            serviceCandidato.Update(cliente);
        }
    }
}

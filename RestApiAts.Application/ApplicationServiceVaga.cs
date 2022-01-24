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
    public  class ApplicationServiceVaga : IApplicationServiceVaga
    {
        private readonly IServiceVaga serviceVaga;
        private readonly IMapper mapper;

        public ApplicationServiceVaga(IServiceVaga serviceVaga
                                        , IMapper mapper)
        {
            this.serviceVaga = serviceVaga;
            this.mapper = mapper;
        }

        public void Add(VagaDto produtoDto)
        {
            var produto = mapper.Map<Vaga>(produtoDto);
            serviceVaga.Add(produto);
        }

        public IEnumerable<VagaDto> GetAll()
        {
            var produtos = serviceVaga.GetAll();
            var produtosDto = mapper.Map<IEnumerable<VagaDto>>(produtos);
            return produtosDto;
        }

        public VagaDto GetById(int id)
        {
            var produto = serviceVaga.GetById(id);
            var produtoDto = mapper.Map<VagaDto>(produto);
            return produtoDto;
        }

        public void Remove(VagaDto produtoDto)
        {
            var produto = mapper.Map<Vaga>(produtoDto);
            serviceVaga.Remove(produto);
        }

        public void Update(VagaDto produtoDto)
        {
            var produto = mapper.Map<Vaga>(produtoDto);
            serviceVaga.Update(produto);
        }


        public IEnumerable<VagaDto> GetVagasNaoAssociadas(int idCandidato)
        {
            var vagas = serviceVaga.GetVagasNaoAssociadas(idCandidato);
            var vagasDto = mapper.Map<IEnumerable<VagaDto>>(vagas);
            return vagasDto;
        }

    }
}
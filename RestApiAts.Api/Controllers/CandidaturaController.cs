using Microsoft.AspNetCore.Mvc;
using RestApiAts.Application.Dtos;
using RestApiAts.Application.Interface;
using System;
using System.Collections.Generic;

namespace RestApiAts.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CandidaturaController : ControllerBase
    {

        private readonly IApplicationServiceCandidatura applicationServiceCandidatura;


        public CandidaturaController(IApplicationServiceCandidatura applicationServiceCandidatura)
        {
            this.applicationServiceCandidatura = applicationServiceCandidatura;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceCandidatura.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceCandidatura.GetById(id));
        }


        [HttpGet]
        [Route("GetListaVagasAtivas/{idCandidato}")]
        public ActionResult<IEnumerable<string>> GetListaVagasAtivas(int idCandidato)
        {
            return Ok(applicationServiceCandidatura.GetListaVagasAtivas(idCandidato));
        }



        // PUT api/values/5
        [HttpPut]
        public JsonResult Put([FromBody] CandidaturaDto candidaturaDto)
        {
            try
            {
                if (candidaturaDto == null)
                    return new JsonResult("Entidade nula");

                candidaturaDto.IsAtivo = false;

                applicationServiceCandidatura.Update(candidaturaDto);
                return new JsonResult("Candidato Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }


        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody] CandidaturaDto candidaturaDto)
        {
            try
            {
                if (candidaturaDto == null)
                    return new JsonResult("Entidade nula");

                applicationServiceCandidatura.Add(candidaturaDto);
                return new JsonResult("Candidato Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
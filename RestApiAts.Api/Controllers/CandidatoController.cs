using Microsoft.AspNetCore.Mvc;
using RestApiAts.Application.Dtos;
using RestApiAts.Application.Interface;
using System;
using System.Collections.Generic;

namespace RestApiAts.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {

        private readonly IApplicationServiceCandidato applicationServiceCandidato;


        public CandidatoController(IApplicationServiceCandidato applicationServiceCandidato)
        {
            this.applicationServiceCandidato = applicationServiceCandidato;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceCandidato.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceCandidato.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] CandidatoDto candidatoDto)
        {
            try
            {
                if (candidatoDto == null)
                    return NotFound();

                applicationServiceCandidato.Add(candidatoDto);
                return Ok("Candidato Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] CandidatoDto candidatoDto)
        {
            try
            {
                if (candidatoDto == null)
                    return NotFound();

                applicationServiceCandidato.Update(candidatoDto);
                return Ok("Candidato Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] CandidatoDto candidatoDto)
        {
            try
            {
                if (candidatoDto == null)
                    return NotFound();

                applicationServiceCandidato.Remove(candidatoDto);
                return Ok("Candidato Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
using Microsoft.AspNetCore.Cors;
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
        public ActionResult<IEnumerable<string>> Get( int page= 1,int pageSize = 10)
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
        public JsonResult Post([FromBody] CandidatoDto candidatoDto)
        {
            try
            {
                if (candidatoDto == null)
                    return new JsonResult("Entidade nula");

                applicationServiceCandidato.Add(candidatoDto);
                return new JsonResult("Candidato Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



        // PUT api/values/5
        [HttpPut]
        public JsonResult Put([FromBody] CandidatoDto candidatoDto)
        {
            try
            {
                if (candidatoDto == null)
                    return  new JsonResult("Entidade nula");


                applicationServiceCandidato.Update(candidatoDto);
                return new JsonResult("Candidato Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpPost()]
        [Route("Delete")]
        public JsonResult Delete([FromBody] CandidatoDto candidatoDto)
        {
            try
            {
                if (candidatoDto == null)
                    return new JsonResult("Entidade nula");

                applicationServiceCandidato.Remove(candidatoDto);
                return new JsonResult("Candidato Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
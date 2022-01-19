using Microsoft.AspNetCore.Mvc;
using RestApiAts.Application.Dtos;
using RestApiAts.Application.Interface;
using System;
using System.Collections.Generic;

namespace RestApiAts.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VagaController : ControllerBase
    {

        private readonly IApplicationServiceVaga applicationServiceVaga;


        public VagaController(IApplicationServiceVaga applicationServiceVaga)
        {
            this.applicationServiceVaga = applicationServiceVaga;
        }
        // GET api/values                                   
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceVaga.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceVaga.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] VagaDto vagaDto)
        {
            try
            {
                if (vagaDto == null)
                    return NotFound();

                applicationServiceVaga.Add(vagaDto);
                return Ok("Candidato Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] VagaDto vagaDto)
        {
            try
            {
                if (vagaDto == null)
                    return NotFound();

                applicationServiceVaga.Update(vagaDto);
                return Ok("Candidato Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] VagaDto vagaDto)
        {
            try
            {
                if (vagaDto == null)
                    return NotFound();

                applicationServiceVaga.Remove(vagaDto);
                return Ok("Candidato Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
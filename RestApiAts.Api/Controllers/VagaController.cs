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
        public JsonResult Post([FromBody] VagaDto vagaDto)
        {
            try
            {
                if (vagaDto == null)
                    return new JsonResult("Entidade nula");

                applicationServiceVaga.Add(vagaDto);
                return new JsonResult("Vaga Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



        // PUT api/values/5
        [HttpPut]
        public JsonResult Put([FromBody] VagaDto vagaDto)
        {
            try
            {
                if (vagaDto == null)
                    return new JsonResult("Entidade nula");


                applicationServiceVaga.Update(vagaDto);
                return new JsonResult("Vaga Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpPost()]
        [Route("Delete")]
        public JsonResult Delete([FromBody] VagaDto vagaDto)
        {
            try
            {
                if (vagaDto == null)
                    return new JsonResult("Entidade nula");

                applicationServiceVaga.Remove(vagaDto);
                return new JsonResult("Vaga Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
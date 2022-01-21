using Microsoft.AspNetCore.Mvc;
using RestApiAts.Application.Interface;
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

    }
}
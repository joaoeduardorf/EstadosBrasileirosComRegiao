using EstadosBrasileirosComRegiao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApiDotnetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Estado>> Get()
        {
            return Estado.Estados.ToList();
        }

        [HttpGet("{sigla}")]
        public ActionResult<Estado> Get(string sigla)
        {
            return Estado.Estados.FirstOrDefault(f => f.Sigla.Equals(sigla));
        }
    }
}
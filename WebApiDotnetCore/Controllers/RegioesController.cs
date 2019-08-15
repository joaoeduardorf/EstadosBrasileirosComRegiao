using EstadosBrasileirosComRegiao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApiDotnetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegioesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Regiao>> Get()
        {
            return Regiao.Regioes.ToList();
        }

        [HttpGet("{regiao}/Estados")]
        public ActionResult<IEnumerable<Estado>> Get(string regiao)
        {
            return Estado.EstadosPorRegiao(Regiao.Regioes.First(f => regiao.Equals(f.Nome))).ToList();
        }

    }
}
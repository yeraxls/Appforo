using Appforo.Class;
using Appforo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appforo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstablishmentController : ControllerBase
    {
        private IEstablishmentService establishmentService;
        public EstablishmentController(IEstablishmentService establishmentService)
        {
            this.establishmentService = establishmentService;
        }
        [HttpPost]
        [Route("api/Establishment/AddPeople")]
        public void AddPeople([FromBody] ModAppEstablishment establishment)
        {
            establishmentService.AddPeople(establishment);
        }
    }
}

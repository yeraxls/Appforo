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

        [HttpGet]
        [Route("api/Establishment/LoadEstablishments")]
        public List<ModAppEstablishment> LoadEstablishments()
        {
            return establishmentService.LoadEstablishments();
        }

        [HttpPost]
        [Route("api/Establishment/NewEstablishment")]
        public void NewEstablishment([FromBody] ModAppEstablishment establishment)
        {
            establishmentService.NewEstablishment(establishment);
        }

        [HttpPost]
        [Route("api/Establishment/AddPeople")]
        public void AddPeople([FromBody] ModAppEstablishment establishment)
        {
            establishmentService.AddPeople(establishment);
        }

        [HttpGet]
        [Route("api/Establishment/LoadEstablishmentByCity")]
        public List<ModAppEstablishment> LoadEstablishmentByCity(string city)
        {
            return establishmentService.LoadEstablishmentByCity(city);
        }

    }
}

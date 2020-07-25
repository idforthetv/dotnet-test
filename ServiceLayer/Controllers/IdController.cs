using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdController : ControllerBase
    {
        private readonly IOrchestrationService _service;

        public IdController(IOrchestrationService service)
        {
            _service = service;
        }

        [HttpGet("GetInternalId")]
        public ActionResult<int> GetInternalId(string Id)
        {
            return _service.FetchInternalId(Id);
        }

    }
}

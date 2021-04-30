using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Student.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediateRTestController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> RegisterStudent(RegisterStudent student)
        {
            return await Mediator.Send(student);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace Kolokwium2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Testcontroller : Controller
    {
        [HttpGet]
        public async Task<IActionResult>Create()
        {

            return Ok();

        }
    }

}
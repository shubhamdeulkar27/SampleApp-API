using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleBL.Interface;


namespace SampleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private ISampleBL sample;

        public SampleController(ISampleBL sample)
        {
            this.sample = sample;
        }
        [HttpPost]
        public IActionResult Return_Name(Sample model)
        {
            string original = sample.Return_Name(model);
            return Ok(new { original });
        }
    }
}
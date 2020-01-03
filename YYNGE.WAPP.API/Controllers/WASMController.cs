using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YYNGE.DotNetCompiler;

namespace YYNGE.WAPP.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WASMController : ControllerBase
    {
        // GET: api/WASM/empty.yym
        [HttpGet("{filename}")]
        public async Task<IActionResult> Get(string filename)
        {
            var path = Path.Combine("/Modules/", filename);
            var module = new YYModule(path);
            await module.CompileAsync();
            return File(module.Binary, "application/wasm");
        }
    }
}

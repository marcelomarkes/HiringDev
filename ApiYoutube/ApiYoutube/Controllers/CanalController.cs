using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiYoutube.Infra.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiYoutube.Controllers
{
    [Route("api/canal")]
    [ApiController]
    public class CanalController : ControllerBase
    {
        private readonly ICanalRepository _canalRepository;
        private IHttpContextAccessor _httpContextAccessor;
        private IHostingEnvironment _hostingEnvironment;

        public CanalController(IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostingEnvironment, ICanalRepository canalRepository)
        {
            _canalRepository = canalRepository;
            _hostingEnvironment = hostingEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
using Interview.Entities;
using Interview.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SepetUrunController : ControllerBase
    {
        private ISepetUrunRepository _repository;
        public SepetUrunController(ISepetUrunRepository sepetUrunRepository)
        {
            this._repository = sepetUrunRepository;
        }
        [HttpGet]
        public IEnumerable<SepetUrun> GetSepetUrunList()
        {
            return _repository.GetSepetUrunList();
        }
    }
}

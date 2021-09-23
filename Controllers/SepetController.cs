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
    public class SepetController : ControllerBase
    {
        private readonly ISepetRepository _sepetRepository;
        public SepetController(ISepetRepository sepetRepository)
        {
            _sepetRepository = sepetRepository;
        }
        public IEnumerable<Sepet> getSepetList()
        {
            return _sepetRepository.GetSepetList();
        }
    }
}

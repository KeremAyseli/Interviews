using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interview.Repositories;
using Interview.Entities;
using Interview.Services;
namespace Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriController : ControllerBase
    {
        private readonly IMusteriRepository repository;
        public MusteriController(IMusteriRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IEnumerable<Musteri> getMusteri()
        {
            return this.repository.GetMusteriList();
        }
        [HttpPost("/testData")]
        public void CreateTestData(int musteriAdet, int sepetAdet)
        {
            TestData ts = new TestData(musteriAdet, sepetAdet);
        }
        [HttpGet("/analiz")]
        public List<SehirAnaliz> TabloAnalizi(){
          SehirAnalizi analiz = new SehirAnalizi();
          return analiz.GetAnalizSonuc();
        }
    }
}

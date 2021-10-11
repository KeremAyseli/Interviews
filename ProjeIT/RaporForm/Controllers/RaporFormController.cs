using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaporForm.Repo;
using RaporForm.Models.RaporFormDB;
namespace RaporForm.Controllers
{
    public class RaporFormController : Controller
    {
        private IRepository<ReportFormType> _repository = null;

        public RaporFormController()
        {
            _repository = new Repository<ReportFormType>();
        }

        public ActionResult Index()
        {
            var Forms = _repository.GetById(1);
            return View(Forms);
        }
        [HttpPost("/AddNewReport")]
        public int AddNewReport(ReportFormType reportForm)
        {
            try
            {
                _repository.Insert(reportForm);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [HttpPost("/UpdateReport")]
        public int UpdateReport(ReportFormType reportForm)
        {
            try
            {
                _repository.Update(reportForm);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [HttpPost("/DeleteReport")]
        public int DeleteReport(ReportFormType reportForm)
        {
            try
            {
                _repository.Delete(reportForm.FormId);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [HttpPost("/getReport")]
        public IActionResult getReport(int ReportId)
        {
            try
            {
                return View(_repository.GetById(ReportId));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

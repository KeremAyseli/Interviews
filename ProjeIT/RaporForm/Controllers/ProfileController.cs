using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaporForm.Models.RaporFormDB;
using RaporForm.Repo;

namespace RaporForm.Controllers
{
    public class ProfileController : Controller
    {
        private IRepository<Employe> _repository = null;

        public ProfileController()
        {
            _repository = new Repository<Employe>();
        }

        public IActionResult Index(int id)
        {
            return View(_repository.GetById(1));
        }
        [HttpPost("/UpdatePassword")]
        public int UpdatePassword(int Id, string newPassword)
        {
            try
            {
                var employe = _repository.GetById(Id);
                employe.Password = newPassword;
                _repository.Update(employe);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [HttpPost("/AddNewEmp")]
        public int AddNewEmploye(Employe emp)
        {
            try
            {
                _repository.Insert(emp);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [HttpPost("/DeleteEmp")]
        public int DeleteEmploye(int EmpId)
        {
            try
            {
                _repository.Delete(EmpId);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [HttpPost("/UpdateEmp")]
        public int UpdateEmploye(Employe emp)
        {
            try
            {
                Employe employe = _repository.GetById(emp.Id);
                employe = emp;
                _repository.Update(employe);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

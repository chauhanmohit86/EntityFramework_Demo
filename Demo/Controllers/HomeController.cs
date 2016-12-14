using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            DataRepository repo = new DataRepository();
            var deptList = repo.GetDepartments();
            //List<DepartmentVM> formatedDList= deptList.Select(dept => new DepartmentVM() {Id = dept.Id, Name = dept.Name}).ToList();
            return View("Index", deptList.ToList());
        }

    }

    public class DepartmentVM
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}

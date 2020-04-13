using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FenyeMvcDemo.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            List<Student> list = new List<Student>();
            int pagesize = 5;
            int pageindex = Request["PageIndex"] != null ? int.Parse(Request["pageindex"]) : 1;
            for (int i = 0; i < 100; i++)
            {
                Student a = new Student();
                a.age = i;
                a.Name = "Demo" + i;
                a.sex = "男" + i;
                list.Add(a);
            }
          var item=    list.Skip<Student>((pageindex - 1) * pagesize).Take(pagesize).ToList();
            PagerInfo pager = new PagerInfo();
            pager.CurrentPageIndex = pageindex;
            pager.PageSize = pagesize;
            pager.RecordCount = list.Count;
            PagerQuery<PagerInfo, List<Student>> query = new PagerQuery<PagerInfo, List<Student>>(pager, item);

            return View(query);
        }
    }
}
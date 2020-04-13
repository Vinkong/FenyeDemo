using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    public List<Student> StuList { get; set; }
    public string Navstring { get; set; }
     protected void Page_Load(object sender, EventArgs e)
    {
        List<Student> list = new List<Student>();
        int pagesize = 5;
        int pageindex = Request["PageIndex"] != null ? int.Parse(Request["pageindex"] ): 1;
        for (int i = 0; i < 100; i++)
        {
            Student a = new Student();
            a.age = i;
            a.Name = "Demo" + i;
            a.sex = "男" + i;
            list.Add(a);
        }
        StuList = list.Skip<Student>((pageindex - 1) * pagesize).Take(pagesize).ToList();
        Navstring = ShowPageManager.ShowPageNavigate(pageindex, pagesize, list.Count);
    }
}
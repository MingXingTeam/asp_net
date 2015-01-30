using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ncu.jsj.Web
{
    public partial class StudentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            Ncu.jsj.BLL.Student bll = new BLL.Student();
            Ncu.jsj.Model.Student model = new Model.Student();
            model = bll.GetModel(id);
            Label1.Text = ""+model.id;
            Label2.Text = model.name;
            Label3.Text =""+ model.age;
            Label4.Text = model.pictureurl;


        }
    }
}
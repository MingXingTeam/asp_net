using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ncu.jsj.BLL;

namespace Ncu.jsj.Web
{
    public partial class DeleteStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Student bll = new Student();
            bll.Delete(Convert.ToInt32(TextBox1.Text));

        }
    }
}
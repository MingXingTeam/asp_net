using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ncu.jsj.Web
{
    public partial class CityDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ncu.jsj.BLL.City bll = new BLL.City();
            GridView1.DataSource = bll.GetAllList();
            GridView1.DataBind();
        }
    }
}
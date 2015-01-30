using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ncu.jsj.Web.City
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Ncu.jsj.BLL.City bll=new Ncu.jsj.BLL.City();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int CityId=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(CityId);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}
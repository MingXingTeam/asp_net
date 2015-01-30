using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ncu.mao.Web.t_privilege
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				ncu.mao.BLL.t_privilege bll=new ncu.mao.BLL.t_privilege();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int parentid=(Convert.ToInt32(Request.Params["id"]));
				bll.Delete(parentid);
				}
			}

        }
    }
}
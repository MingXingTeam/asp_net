using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ncu.mao.Web.user_roles
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				ncu.mao.BLL.user_roles bll=new ncu.mao.BLL.user_roles();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int rolesid=(Convert.ToInt32(Request.Params["id"]));
				bll.Delete(rolesid);
				}
			}

        }
    }
}
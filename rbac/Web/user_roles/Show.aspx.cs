using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace ncu.mao.Web.user_roles
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int rolesid=(Convert.ToInt32(strid));
					ShowInfo(rolesid);
				}
			}
		}
		
	private void ShowInfo(int rolesid)
	{
		ncu.mao.BLL.user_roles bll=new ncu.mao.BLL.user_roles();
		ncu.mao.Model.user_roles model=bll.GetModel(rolesid);
		this.lblid.Text=model.id.ToString();
		this.lbluserid.Text=model.userid.ToString();
		this.lblrolesid.Text=model.rolesid.ToString();

	}


    }
}

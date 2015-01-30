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
namespace ncu.mao.Web.t_role
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
					int roleid=(Convert.ToInt32(strid));
					ShowInfo(roleid);
				}
			}
		}
		
	private void ShowInfo(int roleid)
	{
		ncu.mao.BLL.t_role bll=new ncu.mao.BLL.t_role();
		ncu.mao.Model.t_role model=bll.GetModel(roleid);
		this.lblroleid.Text=model.roleid.ToString();
		this.lblrolename.Text=model.rolename;
		this.lbldescription.Text=model.description;

	}


    }
}

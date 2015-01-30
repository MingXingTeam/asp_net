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
namespace ncu.mao.Web.role_privilege
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
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		ncu.mao.BLL.role_privilege bll=new ncu.mao.BLL.role_privilege();
		ncu.mao.Model.role_privilege model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblrolesid.Text=model.rolesid.ToString();
		this.lblpriviledgeid.Text=model.priviledgeid.ToString();

	}


    }
}

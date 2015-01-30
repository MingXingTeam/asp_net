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
namespace ncu.mao.Web.t_user
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
					int userid=(Convert.ToInt32(strid));
					ShowInfo(userid);
				}
			}
		}
		
	private void ShowInfo(int userid)
	{
		ncu.mao.BLL.t_user bll=new ncu.mao.BLL.t_user();
		ncu.mao.Model.t_user model=bll.GetModel(userid);
		this.lbluserid.Text=model.userid.ToString();
		this.lblusername.Text=model.username;
		this.lblage.Text=model.age.ToString();
		this.lbladdr.Text=model.addr;

	}


    }
}

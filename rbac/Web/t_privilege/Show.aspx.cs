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
namespace ncu.mao.Web.t_privilege
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
					int parentid=(Convert.ToInt32(strid));
					ShowInfo(parentid);
				}
			}
		}
		
	private void ShowInfo(int parentid)
	{
		ncu.mao.BLL.t_privilege bll=new ncu.mao.BLL.t_privilege();
		ncu.mao.Model.t_privilege model=bll.GetModel(parentid);
		this.lblprivilegeid.Text=model.privilegeid.ToString();
		this.lblprivilegename.Text=model.privilegename;
		this.lbldiscription.Text=model.discription;
		this.lblurl.Text=model.url;
		this.lblflag.Text=model.flag?"是":"否";
		this.lblparentid.Text=model.parentid.ToString();

	}


    }
}

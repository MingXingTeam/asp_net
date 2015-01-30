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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace ncu.mao.Web.user_roles
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int rolesid=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(rolesid);
				}
			}
		}
			
	private void ShowInfo(int rolesid)
	{
		ncu.mao.BLL.user_roles bll=new ncu.mao.BLL.user_roles();
		ncu.mao.Model.user_roles model=bll.GetModel(rolesid);
		this.lblid.Text=model.id.ToString();
		this.txtuserid.Text=model.userid.ToString();
		this.lblrolesid.Text=model.rolesid.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtuserid.Text))
			{
				strErr+="userid格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int userid=int.Parse(this.txtuserid.Text);
			int rolesid=int.Parse(this.lblrolesid.Text);


			ncu.mao.Model.user_roles model=new ncu.mao.Model.user_roles();
			model.id=id;
			model.userid=userid;
			model.rolesid=rolesid;

			ncu.mao.BLL.user_roles bll=new ncu.mao.BLL.user_roles();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

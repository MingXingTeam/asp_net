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
namespace ncu.mao.Web.t_role
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int roleid=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(roleid);
				}
			}
		}
			
	private void ShowInfo(int roleid)
	{
		ncu.mao.BLL.t_role bll=new ncu.mao.BLL.t_role();
		ncu.mao.Model.t_role model=bll.GetModel(roleid);
		this.lblroleid.Text=model.roleid.ToString();
		this.txtrolename.Text=model.rolename;
		this.txtdescription.Text=model.description;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtrolename.Text.Trim().Length==0)
			{
				strErr+="rolename不能为空！\\n";	
			}
			if(this.txtdescription.Text.Trim().Length==0)
			{
				strErr+="description不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int roleid=int.Parse(this.lblroleid.Text);
			string rolename=this.txtrolename.Text;
			string description=this.txtdescription.Text;


			ncu.mao.Model.t_role model=new ncu.mao.Model.t_role();
			model.roleid=roleid;
			model.rolename=rolename;
			model.description=description;

			ncu.mao.BLL.t_role bll=new ncu.mao.BLL.t_role();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

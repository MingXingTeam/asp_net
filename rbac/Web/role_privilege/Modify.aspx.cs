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
namespace ncu.mao.Web.role_privilege
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		ncu.mao.BLL.role_privilege bll=new ncu.mao.BLL.role_privilege();
		ncu.mao.Model.role_privilege model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtrolesid.Text=model.rolesid.ToString();
		this.txtpriviledgeid.Text=model.priviledgeid.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtrolesid.Text))
			{
				strErr+="rolesid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpriviledgeid.Text))
			{
				strErr+="priviledgeid格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int rolesid=int.Parse(this.txtrolesid.Text);
			int priviledgeid=int.Parse(this.txtpriviledgeid.Text);


			ncu.mao.Model.role_privilege model=new ncu.mao.Model.role_privilege();
			model.id=id;
			model.rolesid=rolesid;
			model.priviledgeid=priviledgeid;

			ncu.mao.BLL.role_privilege bll=new ncu.mao.BLL.role_privilege();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

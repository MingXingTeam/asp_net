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
namespace ncu.mao.Web.t_user
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int userid=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(userid);
				}
			}
		}
			
	private void ShowInfo(int userid)
	{
		ncu.mao.BLL.t_user bll=new ncu.mao.BLL.t_user();
		ncu.mao.Model.t_user model=bll.GetModel(userid);
		this.lbluserid.Text=model.userid.ToString();
		this.txtusername.Text=model.username;
		this.txtage.Text=model.age.ToString();
		this.txtaddr.Text=model.addr;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtusername.Text.Trim().Length==0)
			{
				strErr+="username不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtage.Text))
			{
				strErr+="age格式错误！\\n";	
			}
			if(this.txtaddr.Text.Trim().Length==0)
			{
				strErr+="addr不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int userid=int.Parse(this.lbluserid.Text);
			string username=this.txtusername.Text;
			int age=int.Parse(this.txtage.Text);
			string addr=this.txtaddr.Text;


			ncu.mao.Model.t_user model=new ncu.mao.Model.t_user();
			model.userid=userid;
			model.username=username;
			model.age=age;
			model.addr=addr;

			ncu.mao.BLL.t_user bll=new ncu.mao.BLL.t_user();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

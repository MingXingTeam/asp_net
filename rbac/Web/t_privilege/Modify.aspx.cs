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
namespace ncu.mao.Web.t_privilege
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int parentid=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(parentid);
				}
			}
		}
			
	private void ShowInfo(int parentid)
	{
		ncu.mao.BLL.t_privilege bll=new ncu.mao.BLL.t_privilege();
		ncu.mao.Model.t_privilege model=bll.GetModel(parentid);
		this.lblprivilegeid.Text=model.privilegeid.ToString();
		this.txtprivilegename.Text=model.privilegename;
		this.txtdiscription.Text=model.discription;
		this.txturl.Text=model.url;
		this.chkflag.Checked=model.flag;
		this.lblparentid.Text=model.parentid.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtprivilegename.Text.Trim().Length==0)
			{
				strErr+="privilegename不能为空！\\n";	
			}
			if(this.txtdiscription.Text.Trim().Length==0)
			{
				strErr+="discription不能为空！\\n";	
			}
			if(this.txturl.Text.Trim().Length==0)
			{
				strErr+="url不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int privilegeid=int.Parse(this.lblprivilegeid.Text);
			string privilegename=this.txtprivilegename.Text;
			string discription=this.txtdiscription.Text;
			string url=this.txturl.Text;
			bool flag=this.chkflag.Checked;
			int parentid=int.Parse(this.lblparentid.Text);


			ncu.mao.Model.t_privilege model=new ncu.mao.Model.t_privilege();
			model.privilegeid=privilegeid;
			model.privilegename=privilegename;
			model.discription=discription;
			model.url=url;
			model.flag=flag;
			model.parentid=parentid;

			ncu.mao.BLL.t_privilege bll=new ncu.mao.BLL.t_privilege();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

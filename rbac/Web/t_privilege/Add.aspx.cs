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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtprivilegeid.Text))
			{
				strErr+="privilegeid格式错误！\\n";	
			}
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
			int privilegeid=int.Parse(this.txtprivilegeid.Text);
			string privilegename=this.txtprivilegename.Text;
			string discription=this.txtdiscription.Text;
			string url=this.txturl.Text;
			bool flag=this.chkflag.Checked;

			ncu.mao.Model.t_privilege model=new ncu.mao.Model.t_privilege();
			model.privilegeid=privilegeid;
			model.privilegename=privilegename;
			model.discription=discription;
			model.url=url;
			model.flag=flag;

			ncu.mao.BLL.t_privilege bll=new ncu.mao.BLL.t_privilege();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

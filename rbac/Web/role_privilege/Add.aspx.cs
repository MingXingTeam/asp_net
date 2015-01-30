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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			int rolesid=int.Parse(this.txtrolesid.Text);
			int priviledgeid=int.Parse(this.txtpriviledgeid.Text);

			ncu.mao.Model.role_privilege model=new ncu.mao.Model.role_privilege();
			model.rolesid=rolesid;
			model.priviledgeid=priviledgeid;

			ncu.mao.BLL.role_privilege bll=new ncu.mao.BLL.role_privilege();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

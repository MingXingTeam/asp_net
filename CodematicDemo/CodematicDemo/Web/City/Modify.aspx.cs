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
namespace Ncu.jsj.Web.City
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int CityId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(CityId);
				}
			}
		}
			
	private void ShowInfo(int CityId)
	{
		Ncu.jsj.BLL.City bll=new Ncu.jsj.BLL.City();
		Ncu.jsj.Model.City model=bll.GetModel(CityId);
		this.lblCityId.Text=model.CityId.ToString();
		this.txtProvinceId.Text=model.ProvinceId.ToString();
		this.txtCityName.Text=model.CityName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtProvinceId.Text))
			{
				strErr+="ProvinceId格式错误！\\n";	
			}
			if(this.txtCityName.Text.Trim().Length==0)
			{
				strErr+="CityName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CityId=int.Parse(this.lblCityId.Text);
			int ProvinceId=int.Parse(this.txtProvinceId.Text);
			string CityName=this.txtCityName.Text;


			Ncu.jsj.Model.City model=new Ncu.jsj.Model.City();
			model.CityId=CityId;
			model.ProvinceId=ProvinceId;
			model.CityName=CityName;

			Ncu.jsj.BLL.City bll=new Ncu.jsj.BLL.City();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

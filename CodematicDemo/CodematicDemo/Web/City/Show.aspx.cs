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
namespace Ncu.jsj.Web.City
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
					int CityId=(Convert.ToInt32(strid));
					ShowInfo(CityId);
				}
			}
		}
		
	private void ShowInfo(int CityId)
	{
		Ncu.jsj.BLL.City bll=new Ncu.jsj.BLL.City();
		Ncu.jsj.Model.City model=bll.GetModel(CityId);
		this.lblCityId.Text=model.CityId.ToString();
		this.lblProvinceId.Text=model.ProvinceId.ToString();
		this.lblCityName.Text=model.CityName;

	}


    }
}

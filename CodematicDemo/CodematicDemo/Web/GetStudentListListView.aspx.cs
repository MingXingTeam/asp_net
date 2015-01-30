using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ncu.jsj.Web
{
    public partial class GetStudentListListView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Ncu.jsj.BLL.Student bll = new BLL.Student();
            ListView1.DataSource = bll.GetAllList();
            ListView1.DataBind();

        }
        public string getsex(object s)
        { 
            string sex=string.Empty;
            if (Convert.ToBoolean(s))
                sex = "男";
            else
                sex = "女";
            return sex;
        
        }
    }
}
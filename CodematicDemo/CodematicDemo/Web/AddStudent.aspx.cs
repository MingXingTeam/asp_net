using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ncu.jsj.Web
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ncu.jsj.Model.Student model=new Model.Student();
            model.name=TextBox1.Text;
            model.age=Convert.ToInt32(TextBox2.Text);
            model.pictureurl = FileUpload1.FileName;
            model.sex = Convert.ToBoolean(TextBox4.Text);
            Ncu.jsj.BLL.Student bll = new BLL.Student();
            bll.Add(model);

            FileUpload1.SaveAs(Server.MapPath("/Images/") + FileUpload1.FileName);
            
        }
    }
}
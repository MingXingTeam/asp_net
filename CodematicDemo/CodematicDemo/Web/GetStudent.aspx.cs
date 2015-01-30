using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ncu.jsj.Web
{
    public partial class GetStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ncu.jsj.BLL.Student bll = new BLL.Student();
            Ncu.jsj.Model.Student model = new Model.Student();
            model=bll.GetModel(Convert.ToInt32(TextBox1.Text));

            Label2.Text = model.name;
            Label3.Text = ""+model.age;
            Label4.Text = model.pictureurl;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Ncu.jsj.Model.Student model = new Model.Student();
            model.id = Convert.ToInt32(TextBox1.Text);
            model.name = TextBox2.Text;
            model.age = Convert.ToInt32(TextBox3.Text);
            model.pictureurl = TextBox4.Text;

            Ncu.jsj.BLL.Student bll = new BLL.Student();
            bll.Update(model);

            
        }
    }
}
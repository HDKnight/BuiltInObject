using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.txtUserName.Text == "user1" && this.txtPassword.Text == "123")
            {
                Session["UserName"] = this.txtUserName.Text;
                Session["LoginTime"] = DateTime.Now;
                Response.Redirect("welcome.aspx");
            }
            else if(this.txtUserName.Text == "user2" && this.txtPassword.Text == "123")
            {
                Session["UserName"] = this.txtUserName.Text;
                Session["LoginTime"] = DateTime.Now;
                Response.Redirect("welcome.aspx");
            }
            else if(this.txtUserName.Text == "user3" && this.txtPassword.Text == "123")
            {
                Session["UserName"] = this.txtUserName.Text;
                Session["LoginTime"] = DateTime.Now;
                Response.Redirect("welcome.aspx");
            }
            else
            {
                Response.Write("<script>alert('登陆失败，请返回查找原因！')<script/>");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuiltInObject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            PublicUtils utils = new PublicUtils();
            User user = utils.ReadIni();

            if (this.txtUserName.Text == user.UserName && this.txtPassword.Text == user.Password)
            {
                //1.生成一个动态口令 Token
                //2.将Token存储到Cookie中，存储用户名到Cookie中
                //3.服务器端存储一份Token。
                string SevenToken = "";
                bool IsSeven = this.CheckBox1.Checked;
                if (IsSeven)
                {
                    SevenToken = Guid.NewGuid().ToString();
                    //将Token写入服务器的文件中
                    utils.WriteIni(SevenToken);
                }
                WriteCookie(this.txtUserName.Text, SevenToken);
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("<script>alert('登陆失败,情检查用户名或者密码是否有误!');</script>");
            }
        }

        private void WriteCookie(string UserName, string sevenToken)
        {
            HttpCookie cookie = new HttpCookie("LoginInfo");
            cookie.Values["UserName"] = UserName;
            if (sevenToken != "")
            {
                cookie.Values["SevenToken"] = sevenToken;
                cookie.Expires = DateTime.Now.AddDays(7);
            }
            else
            {
                cookie.Expires = DateTime.Now.AddMinutes(20);
            }
            Response.Cookies.Add(cookie);
        }
    }
}
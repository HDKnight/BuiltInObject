using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuiltInObject
{
    public partial class Default : System.Web.UI.Page
    {
        string UserName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsLoginOrSeven(out UserName))
            {
                this.LoginStatus.InnerHtml = "欢迎您" + UserName + "<a herf='#'>我的信息</a>";
            }
            else
            {

            }
        }

        private bool IsLoginOrSeven(out string UserName)
        {
            HttpCookie cookie = Request.Cookies["LoginInfo"];
            UserName = "";
            if (cookie != null)
            {
                PublicUtils utils = new PublicUtils();
                User user = utils.ReadIni();
                UserName = cookie.Values["UserName"];
                string SevenToken = cookie.Values["SevenTOken"];
                if (SevenToken != null)
                {
                    if (UserName == user.UserName && SevenToken == user.SevenToken)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
                else
                {
                    if (UserName == user.UserName)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
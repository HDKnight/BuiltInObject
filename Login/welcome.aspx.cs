using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponseRedirct
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("欢迎" + Session["UserName"].ToString() + "！<br/>");
            Response.Write( Session["LoginTime"].ToString());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequestParams
{
    public partial class Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Value1 = Request["value"];
            string Value2 = Request.QueryString["value"];
            string Value3 = Request.Form["value"];
            string Value4 = Request.Params["value"];

            Response.Write("使用Request[value]方式：" + Value1 + "<br/>");
            Response.Write("使用Request.QueryString[value]方式：" + Value2 + "<br/>");
            Response.Write("使用Request.Form[value]方式：" + Value3 + "<br/>");
            Response.Write("使用Request.Params[value]方式：" + Value4 + "<br/>");

        }
    }
}
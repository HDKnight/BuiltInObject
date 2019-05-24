using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequestBrowser
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpBrowserCapabilities browser = Request.Browser;
            Response.Write("客户端浏览器信息");
            Response.Write("<hr>");
            Response.Write("名称：" + browser.Browser + "<br/>");
            Response.Write("类型：" + browser.Type + "<br/>");
            Response.Write("版本：" + browser.Version + "<br/>");
            Response.Write("平台：" + browser.Platform + "<br/>");
            Response.Write("是否支持框架：" + browser.Frames + "<br/>");
            Response.Write("是否支持表格：" + browser.Tables + "<br/>");
            Response.Write("是否支持Cookie：" + browser.Cookies + "<br/>");
            Response.Write("<hr>");
        }
    }
}
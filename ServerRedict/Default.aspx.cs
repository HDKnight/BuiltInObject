using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerRedict
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnExcute_Click(object sender, EventArgs e)
        {
            Server.Execute("newPage.aspx?message=Excute");
            Response.Write("Default.aspx页面");
        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            Server.Transfer("newPage.aspx?message=Transfer");
            Response.Write("Default.aspx页面");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponseRedirct
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnRedirct_Click(object sender, EventArgs e)
        {
            Response.Redirect("welcome.aspx?name=小南&sex=先生");
        }
    }
}
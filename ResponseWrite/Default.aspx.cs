using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponseWrite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            arr[0] = "水调歌头<br/>";
            arr[1] = "苏轼 北宋<br/>";
            arr[2] = "丙辰中秋，欢饮达旦，大醉，作此篇，兼怀子由。<br/>";
            arr[3] = "明月几时有？把酒问青天。不知天上宫阙，今夕是何年？我欲乘风归去，又恐琼楼玉宇，高处不胜寒。起舞弄清影，何似在人间？<br/>";
            arr[4] = "转朱阁，低绮户，照无眠。不应有恨，何事长向别时圆？人有悲欢离合，月有阴晴圆缺，此事古难全。但愿人长久，千里共婵娟。<br/>";
            foreach(string s in arr)
            {
                Response.Write(s);
            }
            
        }
    }
}
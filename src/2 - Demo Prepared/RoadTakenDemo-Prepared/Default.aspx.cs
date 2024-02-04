using System;
using System.Configuration;
using System.Web.UI;

namespace RoadTakenDemoTemplate
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("/Demo.aspx");
        }
    }
}
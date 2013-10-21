using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teht1
{
    public partial class etusivu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void asParameter_Click(object sender, EventArgs e)
        {
            // Get response.
            var response = base.Response;
            Session["nimi"] = null;
            string parametri = nimi.Text;
            // Redirect temporarily.
            // ... Don't throw an HttpException to terminate.
            response.Redirect("tokasivu.aspx?nimi=" + parametri, false);
        }

        protected void asSession_Click(object sender, EventArgs e)
        {
            // Get response.
            var response = base.Response;
            Session["nimi"] = nimi.Text;
            // Redirect temporarily.
            // ... Don't throw an HttpException to terminate.
            response.Redirect("tokasivu.aspx", false);
        }

        protected void asCookie_Click(object sender, EventArgs e)
        {
            string cookieValue = nimi.Text;
            Session["nimi"] = null;
            Response.Cookies["nimi"].Value = cookieValue;
            Response.Redirect("tokasivu.aspx", false);
        }
    }
}
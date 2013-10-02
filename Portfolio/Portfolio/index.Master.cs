using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio
{
    public partial class index1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void MainMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            var response = base.Response;

            switch (e.Item.Value)
            {
                case "Home": response.Redirect("home.aspx");
                    break;
                case "About": response.Redirect("about.aspx");
                    break;
                case "Salesa": response.Redirect("leffat.aspx");
                    break;
                case "Kotitehtava": response.Redirect("kotitehtavat.aspx");
                    break;
                default:
                    break;
            }
        }
    }
}
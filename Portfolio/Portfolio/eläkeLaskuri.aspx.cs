using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Eläke
{
    public partial class eläkeLaskuri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ika.Text == "")
            {
                ika.Text = ConfigurationManager.AppSettings["DefaultAge"];
                palkka.Text = ConfigurationManager.AppSettings["DefaultPayment"];
            }
            
        }

        protected void miinusIka_Click(object sender, EventArgs e)
        {
            int age = Int32.Parse(ika.Text)-1;
            if (age < 18)
            {
                age = 18;
                
            }
            ika.Text = "" + age;
            
            
        }
        protected void plusIka_Click(object sender, EventArgs e)
        {
            int age = Int32.Parse(ika.Text) + 1;
            if (age > 64)
            {
                age = 64;

            }
            ika.Text = "" + age;
        }

        protected void miinusPalkka_Click(object sender, EventArgs e)
        {

        }


        protected void plusPalkka_Click(object sender, EventArgs e)
        {

        }
    }
}
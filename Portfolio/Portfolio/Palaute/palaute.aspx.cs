using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio.Palaute
{
    public partial class palaute : System.Web.UI.Page
    {
        public List<PalauteForm> palautteita { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                initMyStuff();
            }
            else
                palautteita = (List<PalauteForm>)ViewState["palautteita"];
        }

        private void initMyStuff()
        {
            try
            {
                Palauteet palautteet = new Palauteet();
                Serialisointi.DeSerialisoiXml(Server.MapPath("~/data/palaute.xml"), ref palautteet);
                palautteita = palautteet.palautteet;
                loadListView();
            }
            catch (Exception ex)
            {
                palautteita = new List<PalauteForm>();
               
            }
            ViewState["palautteita"] = palautteita;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblOutput.Text = "Kiitos Palauttestasi";
                PalauteForm pa = new PalauteForm();
                pa.HaluanOppia = halutaTxt.Text;
                pa.Hyvaa = hyvaaTxt.Text;
                pa.Muuta = muutaTxt.Text;
                pa.Opittu = oppinutTxt.Text;
                pa.Parannettavaa = parannettavaaTxt.Text;
                pa.Tekija = nimiTxt.Text;
                pa.Pvm = pvmTxt.Text;
                palautteita.Add(pa);
                loadListView();
                savePalautteet();
            }
            else
            {
                lblOutput.Text = "Required field is empty!";
            }
        }

        private void savePalautteet()
        {
            Palauteet p = new Palauteet();
            p.palautteet = palautteita;
            Serialisointi.SerialisoiXml(Server.MapPath("~/data/palaute.xml"), p);
        }

        private void loadListView()
        {
            ListView1.DataSource = palautteita;
            ListView1.DataBind();
        }
    }
}
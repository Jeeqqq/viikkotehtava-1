using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio.teht4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Record> Albumit { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                initMyStuff();
            }
            else
            {
                Albumit = (List<Record>)ViewState["Records"];
            }
        }

        private void initMyStuff()
        {
            try
            {
                Records records = new Records();
                Serialisointi.DeSerialisoiXml(Server.MapPath("~/data/LevykauppaX.xml"), ref records);
                Albumit = records.genre.Records;
                ViewState["Records"] = Albumit;
                loadListWiew(Albumit);
            }
            catch (Exception ex)
            {
                er.InnerText = ex.Message;
            }
        }
        protected void loadListWiew(List<Record> r)
        {

            ViewState["currentRecords"] = r;
            ListView1.DataSource = r;
            ListView1.DataBind();

        }

        protected void OpenAlbum_Click(object sender, EventArgs e)
        {
            LinkButton button = sender as LinkButton;
            string isbn = button.CommandArgument;
            ListView1.DataSource = null;
            ListView1.DataBind();
            List<Record> record = Albumit.FindAll(
                delegate(Record r)
                {
                    return r.ISBN == isbn;
                });
            ListView2.DataSource=record;
            ListView2.DataBind();

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            ListView2.DataSource = null;
            ListView2.DataBind();
            loadListWiew(Albumit);
        }

    }
}
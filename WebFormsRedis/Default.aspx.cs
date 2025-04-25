using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsRedis
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSetSession_Click(object sender, EventArgs e)
        {
            Session["settime"] = System.DateTime.Now;
        }

        protected void BtnGetSession_Click(object sender, EventArgs e)
        {
            if (Session["settime"] != null)
            {
                this.ShowSessionData.Text = Session["settime"].ToString();

            }
        }

        protected void BtnRemoveSession_Click(object sender, EventArgs e)
        {
            Session.Remove("settime");
            this.ShowSessionData.Text =String.Empty;

        }
    }
}
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsRedis.Helper;

namespace WebFormsRedis
{
    public partial class About : Page
    {
        IDatabase db = RedisHelper.Connection.GetDatabase();

        protected void Page_Load(object sender, EventArgs e)
        {

            //// ✅ Store data
            //db.StringSet("user:1001", "John Doe");

            //// ✅ Retrieve data
            //string userName = db.StringGet("user:1001");

            //// Show on the page
            //Response.Write("User: " + userName);
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {

            if (this.TxtName.Text.Length == 0)
                return;

            User user = new User();
            user.Id = 1;
            user.Name=this.TxtName.Text;
            user.email = this.TxtEmail.Text;

            string json = JsonConvert.SerializeObject(user);
            db.StringSet("user:1", json);
        }

        protected void BtnGetData_Click(object sender, EventArgs e)
        {

            string jsonData = db.StringGet("user:1");
            User retrievedUser = JsonConvert.DeserializeObject<User>(jsonData);
            if (retrievedUser != null)
            {
                //Response.Write(retrievedUser.Name);
                LblNameShow.Text = retrievedUser.Name;
                LblEmailShow.Text = retrievedUser.email;
            }

        }
    }
}
using Newtonsoft.Json;
using Scheduler.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Scheduler.Forms
{
    public partial class testApi : Form
    {
        public testApi()
        {
            InitializeComponent();
        }

        private void btnTestWebApi_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var response = client.GetAsync(@"https://newsapi.org/v2/everything?q=bitcoin&from=2018-08-24&sortBy=publishedAt&apiKey=4de3f1f956424993b6d2fb28deba22be").Result;

            if (response.IsSuccessStatusCode)
            {
                txtResult.Text = response.Content.ReadAsStringAsync().Result;
                JavaScriptSerializer oJS = new JavaScriptSerializer();
                RootObject oRootObject = new RootObject();
                oRootObject = oJS.Deserialize<RootObject>(response.Content.ReadAsStringAsync().Result);

                var groupedArticleList = oRootObject.articles.GroupBy(u => u.author).Select(grp => grp.ToList()).ToList();
            }

        }
    }
}

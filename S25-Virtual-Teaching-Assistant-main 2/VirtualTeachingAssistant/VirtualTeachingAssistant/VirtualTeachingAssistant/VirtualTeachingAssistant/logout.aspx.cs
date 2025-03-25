using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualTeachingAssistant
{
	public partial class logout : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

            Session.Clear();
            string logoutUrl = ConfigurationManager.AppSettings["Cognito_SignoutUri"];
            Response.Redirect(logoutUrl);
        }
    }
}
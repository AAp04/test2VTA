using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualTeachingAssistant
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string clientId = ConfigurationManager.AppSettings["Cognito_ClientId"];

            string redirectUri = ConfigurationManager.AppSettings["Cognito_RedirectUri"];

            string authority = ConfigurationManager.AppSettings["Cognito_Authority"];


            string loginUrl = $"{authority}/oauth2/authorize?client_id={clientId}&response_type=code&scope=openid&redirect_uri={redirectUri}";


            Response.Redirect(loginUrl);

        }
    }
}
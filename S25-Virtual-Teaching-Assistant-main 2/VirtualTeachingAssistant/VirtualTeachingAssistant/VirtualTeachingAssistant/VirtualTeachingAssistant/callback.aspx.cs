using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualTeachingAssistant
{
	public partial class callback : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

            string code = Request.QueryString["code"];
            if (!string.IsNullOrEmpty(code))
            {
                string tokenResponse = await GetTokensAsync(code);

                // Store access token in session
                Session["AccessToken"] = tokenResponse;

                // Redirect to a secure page after login
                Response.Redirect("SecurePage.aspx");
            }
            else
            {
                Response.Write("Error: No authorization code received.");
            }
        }

        private async Task<string> GetTokensAsync(string code)
        {
            string clientId = ConfigurationManager.AppSettings["Cognito_ClientId"];
            string clientSecret = ConfigurationManager.AppSettings["Cognito_ClientSecret"];
            string redirectUri = ConfigurationManager.AppSettings["Cognito_RedirectUri"];
            string authority = ConfigurationManager.AppSettings["Cognito_Authority"];

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, $"{authority}/oauth2/token");
                request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"grant_type", "authorization_code"},
                {"client_id", clientId},
                {"client_secret", clientSecret},
                {"redirect_uri", redirectUri},
                {"code", code}
            });

                var response = await client.SendAsync(request);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
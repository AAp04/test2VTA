﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualTeachingAssistant
{
	public partial class SecurePage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Session["AccessToken"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }
	}
}
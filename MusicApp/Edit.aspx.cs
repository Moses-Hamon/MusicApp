﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicApp
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var svc = new MusicServiceProxy.MusicServiceSoapClient();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
           
        }
    }
}
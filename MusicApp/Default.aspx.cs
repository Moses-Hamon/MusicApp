using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // the object that accesses the web service for us is in
            //the namespace we specified, then <ServiceName>SoapClient
            var svc = new MusicServiceProxy.MusicServiceSoapClient();
            // you can then access the [WebMethod] tagged methods in you web service like this:
            gvList.DataSource = svc.SelectAll();
            gvList.DataBind();

            // note: the types exposed through the WebService (via return types or arguments)
            // are also translated and live within the MusicServiceProxy
            // -> this means you have access to the Music model object here in the app
        }

        protected void gvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = gvList.SelectedRow.Cells[1].Text;
            Response.Redirect($"~/Edit.aspx?id=" + id);
        }
    }
}
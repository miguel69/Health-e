using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Microsoft.Health;
using Microsoft.Health.Web;
using Microsoft.Health.ItemTypes;

public partial class PatientMaster : MasterPage
{
    protected void Page_Prerender(object sender, EventArgs e)
    {
        //PersonName_lbl.Text = PersonInfo.SelectedRecord.DisplayName.ToString();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Drawing;
using System.Drawing.Imaging;

using Microsoft.Health;
using Microsoft.Health.Web;
using Microsoft.Health.ItemTypes;

public partial class FetchProfilePicture : HealthServicePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PersonalImage patientImage = (PersonalImage)PersonInfo.SelectedRecord.GetItemsByType(PersonalImage.TypeId, HealthRecordItemSections.All)[0];

        // Since we are outputting a Jpeg, set the ContentType appropriately
        Response.ContentType = "image/jpeg";
        Bitmap objBitmap = new Bitmap(patientImage.ReadImage());
        
        // Save the image to the OutputStream
        objBitmap.Save(Response.OutputStream, ImageFormat.Jpeg);

        // clean up...
        objBitmap.Dispose();
    }
}

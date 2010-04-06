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

public partial class GenerateChart : HealthServicePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Since we are outputting a Jpeg, set the ContentType appropriately
        Response.ContentType = "image/jpeg";    // Create a Bitmap instance that's 468x60, and a Graphics instance
        const int width = 480, height = 270;
        Bitmap objBitmap = new Bitmap(width, height);
        Graphics objGraphics = Graphics.FromImage(objBitmap);

        // Create a white background
        objGraphics.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height);
        objGraphics.DrawRectangle(new Pen(Color.Black, 1), 0, 0, width - 1, height - 1);

        //// Create a LightBlue background
        //objGraphics.FillRectangle(new SolidBrush(Color.LightBlue), 5, 5,
        //    width - 10, height - 10);

        //// Create the advertising pitch
        Font fontBanner = new Font("Verdana", 10, FontStyle.Regular);
        StringFormat stringFormat = new StringFormat();

        //// center align the advertising pitch
        stringFormat.Alignment = StringAlignment.Center;
        stringFormat.LineAlignment = StringAlignment.Center;

        String label = "Chart for: " + PersonInfo.SelectedRecord.Name.ToString();
        objGraphics.DrawString(label, fontBanner, new SolidBrush(Color.Black), new Rectangle(0, 0, width, height/10), stringFormat);

        // Save the image to the OutputStream
        objBitmap.Save(Response.OutputStream, ImageFormat.Jpeg);

        // clean up...
        objGraphics.Dispose();
        objBitmap.Dispose();

    }
}

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
using Microsoft.Health;
using Microsoft.Health.Web;
using Microsoft.Health.ItemTypes;

public partial class prescription : HealthServicePage 
{
    string texto = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string current = HeightBox.Text;
        Username.Text = PersonInfo.Name;
        update.Text = "Update";
        Height heightMeasurements = GetSingleValue<Height>(Height.TypeId);
        if (heightMeasurements != null)
        {
            HeightBox.Text = heightMeasurements.Value.ToString();
        }
        Weight weightMeasurements = GetSingleValue<Weight>(Weight.TypeId);
        WeightBox.Text = weightMeasurements.Value.ToString();
        BasicV2 age = GetSingleValue<BasicV2>(BasicV2.TypeId);
        Age.Text = age.BirthYear.ToString();
        
    }
    T GetSingleValue<T>(Guid typeID) where T : class
    {
        HealthRecordSearcher searcher = PersonInfo.SelectedRecord.CreateSearcher();

        HealthRecordFilter filter = new HealthRecordFilter(typeID);
        searcher.Filters.Add(filter);

        HealthRecordItemCollection items = searcher.GetMatchingItems()[0];

        if (items != null && items.Count > 0)
        {
            return items[0] as T;
        }
        else
        {
            return null;
        }
    }
    protected void update_Click(object sender, EventArgs e)
    {
       
        
        string[] words = texto.Split(' ');
        double meters = double.Parse(words[0]);
        Length value = new Length(meters);
        Height height = new Height(new HealthServiceDateTime(DateTime.Now), value);
        PersonInfo.SelectedRecord.NewItem(height);
    }

 
}

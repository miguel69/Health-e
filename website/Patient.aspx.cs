/********************************************************************++

Copyright (c) Microsoft Corporation. All rights reserved.

************************************************************************/

using System;
using System.Data;
using System.Configuration;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.IO;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Microsoft.Health;
using Microsoft.Health.Web;
using Microsoft.Health.ItemTypes;

public partial class _Default : HealthServicePage
{
    protected void Page_Prerender(object sender, EventArgs e)
    {
       
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //PersonName_lbl.Text = PersonInfo.SelectedRecord.DisplayName.ToString();

        FullName_lbl.Text += PersonInfo.SelectedRecord.Name.ToString();

        BasicV2 basic = GetSingleValue<BasicV2>(BasicV2.TypeId);
        if (basic != null && basic.BirthYear.HasValue)
        {
            BY_lbl.Text += basic.BirthYear.ToString();
        }

        Gender_lbl.Text += basic.Gender.ToString();

        /*
        if (image == null)
        {
            image = new PersonalImage();
            image.WriteImage(imageStream, "image/jpg");
            PersonInfo.SelectedRecord.NewItem(image);
        }
        else
        {
            image.WriteImage(imageStream, "image/jpg");
            PersonInfo.SelectedRecord.UpdateItem(image);
        }
        */

        Height height = GetSingleValue<Height>(Height.TypeId);
        Weight weight = GetSingleValue<Weight>(Weight.TypeId);

        Height_lbl.Text += height.Value.Value.ToString();
        Weight_lbl.Text += weight.Value.DisplayValue.ToString();

        //Country_lbl.Text = basic.Country.ToString();  


    
       
    }
    protected void StartupData_ActiveViewChanged(object sender, EventArgs e)
    {

    }

    T GetSingleValue<T>(Guid typeID) where T : class
    {
        HealthRecordSearcher searcher = PersonInfo.SelectedRecord.CreateSearcher();

        HealthRecordFilter filter = new HealthRecordFilter(typeID);
        filter.MaxItemsReturned = 1;
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
}

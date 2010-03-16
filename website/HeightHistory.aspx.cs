using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Xml;
using System.Xml.XPath;

using Microsoft.Health;
using Microsoft.Health.Web;
using Microsoft.Health.ItemTypes;


public partial class HeightHistory : HealthServicePage
{
    protected void Page_Prerender(object sender, EventArgs e)
    {
        PersonName_lbl.Text = PersonInfo.SelectedRecord.DisplayName.ToString();
        HealthRecordSearcher searcher = PersonInfo.SelectedRecord.CreateSearcher();
        HealthRecordFilter filter = new HealthRecordFilter(Height.TypeId);
        searcher.Filters.Add(filter);
        HealthRecordItemCollection heights = searcher.GetMatchingItems()[0];
        AddHeaderCells(c_tableHeight, "Date", "Height");
        foreach (Height height in heights)
        {
            AddCellsToTable(c_tableHeight, height.When.ToString(),
                                     height.Value.ToString());
        }
        //Height height = new Height();
    }

    protected void c_buttonSave_Click(object sender, EventArgs e)
    {
        double heightValue = Double.Parse(c_textboxHeight.Text);
        Height height = new Height();
        height.Value.Meters = heightValue;
        PersonInfo.SelectedRecord.NewItem(height);
    }

    protected void StartupData_ActiveViewChanged(object sender, EventArgs e)
    {

    }

    #region helpers

    /*
    void AddHungerToWeight(Weight weight)
    {
        HealthRecordItemExtension extension = new HealthRecordItemExtension(ExtensionWeightTrackerHunger);
        XPathNavigator navigator = extension.ExtensionData.CreateNavigator();
        string innerXml = @"<extension><hunger>" + c_dropDownListHunger.SelectedItem.Value +
            @"</hunger></extension>";
        navigator.InnerXml = innerXml;

        weight.CommonData.Extensions.Add(extension);
    }
    */
    static readonly string ExtensionWeightTrackerHunger = "DemoWeightTrackerHunger";

    /*
    string GetHungerFromExtension(HealthRecordItemExtension extension)
    {
        if (extension.Source != ExtensionWeightTrackerHunger)
        {
            return null;
        }

        XPathNavigator navigator = extension.ExtensionData.CreateNavigator();
        XPathNavigator value = navigator.SelectSingleNode("extension/hunger");
        if (value == null)
        {
            return null;
        }

        return value.Value;
    }
    */

    double CalculateBMI(Height height, Weight weight)
    {
        double bmi = weight.Value.Kilograms / (height.Value.Meters * height.Value.Meters);

        return bmi;
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

    void AskUserForOptionalAuthorization()
    {
        string TargetQuery = "appid=f36debe2-c2a3-434a-b822-f8c294fdecf9&onopt1=emotionalstate";
        RedirectToShellUrl("APPAUTH", TargetQuery);
    }

    HealthRecordItemTypePermission GetItemPermission(Guid typeId)
    {
        List<Guid> items = new List<Guid>();
        items.Add(typeId);
        Collection<HealthRecordItemTypePermission> permissions = PersonInfo.SelectedRecord.QueryPermissions(items);
        if (permissions.Count == 1)
        {
            return permissions[0];
        }
        else
        {
            return new HealthRecordItemTypePermission();
        }
    }



    void PopulateDropDownFromEnum(DropDownList list, Type t)
    {
        list.Items.Clear();
        foreach (int value in Enum.GetValues(t))
        {
            string name = Enum.GetName(t, value);

            ListItem item = new ListItem(name, value.ToString());
            list.Items.Add(item);
        }
    }


    void AddHeaderCells(Table table, params string[] headerCells)
    {
        if (table.Rows.Count == 0)
        {
            table.Rows.Add(new TableRow());
        }

        foreach (string headerCell in headerCells)
        {
            TableHeaderCell cell = new TableHeaderCell();
            cell.Text = headerCell;
            table.Rows[0].Cells.Add(cell);
        }
    }

    void AddCellsToTable(Table table, params string[] cells)
    {
        TableRow row = new TableRow();
        table.Rows.Add(row);

        foreach (string text in cells)
        {
            TableCell cell = new TableCell();
            cell.HorizontalAlign = HorizontalAlign.Right;
            cell.Text = text;
            if (cell.Text == String.Empty)
            {
                cell.Text = "&nbsp;";
            }
            row.Cells.Add(cell);
        }
    }

    void AddLinkToEditPage(Table table, Guid weightId)
    {
        HyperLink hyperLink = new HyperLink();
        hyperLink.Text = "Update";
        hyperLink.NavigateUrl = "UpdateWeight.aspx?Id=" + weightId.ToString();

        TableCell cell = new TableCell();
        cell.Controls.Add(hyperLink);
        table.Rows[table.Rows.Count - 1].Cells.Add(cell);
    }

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
using System;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    public string getClientID(string colName, string controlName) {
        TextBox t = (TextBox)grid.FindHeaderTemplateControl(grid.Columns[colName], controlName);
        return t.ClientID;
    }
}
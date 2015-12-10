using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DataHandler dataHandler;

    protected void Page_Load(object sender, EventArgs e)
    {
        dataHandler = new DataHandler();
        if (!dataHandler.FetchData(""))
        {
            lblMessage.Text = "Tietokantavirhe";
        }
        else
        {
            lblMessage.Text = dataHandler.GetTestData();
            DataTable studentTable = dataHandler.GetStudentDataTable();

            if (studentTable == null) lblMessage.Text = "Ei oppilaita";
            else
            {
                gvAttendees.DataSource = studentTable;
                gvAttendees.DataBind();
            }
        }
    }
}
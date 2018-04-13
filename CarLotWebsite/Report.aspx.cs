using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClassLibrary;


public partial class Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            // update the list 
            DisplayEmployee();
        }

                // update the list box

   // WHY IS THIS NOT WORKING 
    }

    void DisplayEmployee()
    {
        {
            //create an instance of the County Collection
            CarClassLibrary.clsEmployeeCollection Employee = new CarClassLibrary.clsEmployeeCollection();
            //set the data source to the list of counties in the collection
            lstEmployees.DataSource = Employee.EmployeeList;
            //set the name of the primary key
            lstEmployees.DataValueField = "AddressNo";
            //set the data field to display
            lstEmployees.DataTextField = "PostCode";
            //bind the data to the list
            lstEmployees.DataBind();
        }

    }


}
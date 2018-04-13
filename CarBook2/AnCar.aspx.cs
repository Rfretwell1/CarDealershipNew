using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClassLibrary;

public partial class AnCar : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CarNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Cars to be processed
        CarNo = Convert.ToInt32(Session["CarNo"]);
        if (IsPostBack == false)
        {
            //populate the list of Cars
            DisplayCars();
            //if this is not a new record
            if (CarNo != -1)
            {
                //display the current data for the record
                DisplayCars();
            }
        }
    }
    //
    void DisplayCars()
    {
        //create an instance of the Cars Collection
        CarClassLibrary.clsCarCollection Cars = new CarClassLibrary.clsCarCollection();
        //set the data source to the list of Cars in the collection
        ddlCarNo.DataSource = Cars.CarList;
        //set the name of the primary key
        ddlCarNo.DataValueField = "CarNo";
        //set the data field to display
        ddlCarNo.DataTextField = "CarNo";
        //bind the data to the list
        ddlCarNo.DataBind();
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CarNo == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            //Update();
        }
    }
    void Add()
    {
        //create an instance of the address book
        clsCarCollection CarBook = new clsCarCollection();
        //validate the data on the web form
        String Error = CarBook.ThisCar.Valid(ddlCarNo.Text, txtCarMake.Text, txtCarModel.Text, txtAge.Text, txtMileage.Text, txtBodyType.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CarBook.ThisCar.CarNo = Convert.ToInt32(ddlCarNo.Text);
            CarBook.ThisCar.CarMake = txtCarMake.Text;
            CarBook.ThisCar.CarModel = txtCarModel.Text;
            CarBook.ThisCar.Age = Convert.ToInt32(txtAge.Text);
            CarBook.ThisCar.Mileage = Convert.ToInt32(txtMileage.Text);
            CarBook.ThisCar.Active = chkActive.Checked;
            //add the record
            CarBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
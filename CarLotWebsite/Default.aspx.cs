using System;
using CarClassLibrary;
using Class_Library;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            DisplayCars();
        }
    }
    
    void DisplayCars()
    {
        //create an instance of the Car Collection
        CarClassLibrary.clsCarCollection Cars = new CarClassLibrary.clsCarCollection();
        //set the data source to the list of counties in the collection
        lstCar.DataSource = Cars.CarList;
        //set the name of the primary key
        lstCar.DataValueField = "CarNo";
        //set the data field to display
        lstCar.DataTextField = "CarMake";
        //bind the data to the list
        lstCar.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CarNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnCar.aspx");
    }



    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
       
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 AddressNo;
        //if a record has been selected from the list
        if (lstCar.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            AddressNo = Convert.ToInt32(lstCar.SelectedValue);
            //store the data in the session object
            Session["AddressNo"] = AddressNo;
            //redirect to the edit page
            Response.Redirect("AnAddress.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CarNo;
        //if a record has been selected from the list
        if (lstCar.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CarNo = Convert.ToInt32(lstCar.SelectedValue);
            //store the data in the session object
            Session["CarNo"] = CarNo;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void lstCar_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

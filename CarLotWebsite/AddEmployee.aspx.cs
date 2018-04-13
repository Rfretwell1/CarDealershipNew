using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClassLibrary;

public partial class AddEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void chkbox_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnadd_Click(object sender, EventArgs e)
    {

    }

    void Add()
    {
        //create an instance of the address book
        clsEmployeeCollection EmployeeBook = new clsEmployeeCollection();
        //validate the data on the web form
        String Error = EmployeeBook.ThisEmployee.Valid(txtfirstname.Text, txtlastname.Text, txtaddress.Text, txtpostcode.Text, txtdatejoined.Text,  txtemail.Text ,txtphone.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
         
            EmployeeBook.ThisEmployee.FirstName = txtfirstname.Text;
            EmployeeBook.ThisEmployee.LastName = txtlastname.Text;
            EmployeeBook.ThisEmployee.PostCode = txtpostcode.Text;
            EmployeeBook.ThisEmployee.Address= txtaddress.Text;
            EmployeeBook.ThisEmployee.Active = Active.Checked;
            EmployeeBook.ThisEmployee.EmailAddress = txtemail.Text;
            EmployeeBook.ThisEmployee.DateJoined = Convert.ToDateTime(txtdatejoined.Text);
            EmployeeBook.ThisEmployee.PhoneNumber = txtphone.Text;
            //add the record
            EmployeeBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("HomePage.aspx");
        }
        else
        {
            //report an error
            lblerror.Text = "There were problems with the data entered " + Error;
        }
    }
}
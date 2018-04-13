using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Desktop\PM Car Repo 8\AppData\CarBook.mdf;Integrated Security=Tr");
        SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + TextBox1.Text + "' and Password= '" + TextBox2.Text + "'", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        if (dt.Rows[0][0].ToString() == "1")
        {

            Response.Redirect("HomePage.aspx");

        }
        else
        {

            Response.Write("Please enter your user name and passwowrd again");
        
        }
       
    }



 
}
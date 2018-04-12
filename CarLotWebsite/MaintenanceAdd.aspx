<!DOCTYPE html>
<script runat="server">

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        ''            
        ''Session["MaintenaceID"] = -1;
        ''            Response.Redirect("anMaintenance")






    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

        ''Partial Public class_Maintenance : System.Web.UI.Page
        ''{
        ''//this funciton handles the load event
        ''Protected void Page_load(Object sender, EventArgs e)

        ''//if this Is the first time the page Is displayed 
        ''If (IsPostBack == False) Then
        ''                {
        ''//update the list box
        ''DisplayMaintenance();
        ''}
        ''}

        ''void DisplayMaintenance()
        ''{
        ''//create the instance
        ''class_libary.clsMaintenanceCollection Maintenance = New class_libary.clsMaintenance():  
        ''//set the data source
        ''lstMaintenance.DataSource = Maitanance.MaintanceList;
        ''//set the name 
        ''lstMaintnance.DataValueField = "MaintananceID";
        ''//set the data field
        ''lstMaintance.DataTextFeild = "Despcirtion"
        ''//bind the data the list
        ''lstMaintance.DataBind();
        ''}





    End Sub
</script>

<html>
<head>
    <title>Maintenance Add
    </title>
	<meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <<div id="MainHomePage">
    <div class="btn-group">
        <p><a href="Homepage.html"><h2> <button>HomePage</button></h2></a></p>
        <p><a href="LoginAndRegister.html"><h2><button>Login/Register</button></h2></a></p>
        <p><a href="Cars.html"><h2> <button>Cars</button></h2></a></p>
        <p><a href="Maitenance.html"><h2><button>Maintenance</button></h2></a></p>
        <p><a href="Payment.html"> <h2><button>Payment</button></h2></a></p>
    </div>

</div>

    <div>
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>


        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />


        <a style="color:white"><h1>Add Car to Maintenance</h1></a>
</div>
    <table>
        <tr>
            <td>
                
                <form name="MessageBox" onsubmit="return messageBox()" method="post">
                    <p><input type="text" name="name" id="Fname" placeholder="MaintenacneID" autocomplete="off" tabindex="1" class="txtinput"></br></p>
                    <p><input type="text" name="name" id="Lname" placeholder="RepairId" autocomplete="off" tabindex="2" class="txtinput"></br></p>
                    <p><input type="email" name="email" id="email" placeholder="Date" autocomplete="off" tabindex="3" class="txtinput"></br> <a style="color:white">
                    <p><input type="contact Number" name="Number" id="Number" placeholder="Descrpiton" autocomplete="off" tabindex="4" class="txtinput"></br></p>
                    <p><input type="Address" name="Address" id="Address" placeholder="Cost" autocomplete="off" tabindex="5" class="txtinput"</p>              
                    <p><input type="reset" value="Reset"><br></p>
                    <button type="submit">Submit</button>
                    <script>
                    function messageBox()
                    {
                    alert("Thank you for creating a Maintenace ");
                    }
                    </script>
            </td>
            </div>

            
</body>
</html>


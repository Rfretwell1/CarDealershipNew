<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddEmployee.aspx.cs" Inherits="AddEmployee" %>

<!DOCTYPE html>
<html>
<head>
    <title></title>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />


    <style type="text/css">
        .auto-style1 {
            color: black;
            height: 21px;
        }
    </style>


</head>
<body>
    ​<header>
        <div class="header">
            <img src="Images/ferrari.png" alt="logo" style="height: 186px; width: 259px" />

             <p><a href="LogIn.aspx"> <h2><button>LogOut</button></h2></a></p
           
        </div>
    </header>




    <div> <!--  form code -->

        <form id="form_71736" runat="server">
                    <input type="hidden" name="form_id" value="71736" />

            <div class="form_description">
                <h2>Add New Employee</h2>
                <p>Please fill in New Employee Details </p>
                <p class="auto-style1">First Name
                    <asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox>
                </p>
                <p class="auto-style1">Last Name
                    <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
                </p>
                <p class="auto-style1">Address
                    <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
                </p>
                <p class="auto-style1">Postcode
                    <asp:TextBox ID="txtpostcode" runat="server"></asp:TextBox>
                </p>
                <p class="auto-style1">Date Joined<asp:TextBox ID="txtdatejoined" runat="server"></asp:TextBox>
                </p>
                <p class="auto-style1">Email Address
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </p>
                <p class="auto-style1">Phone
                    <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                </p>
                <p class="auto-style1">Job Title
                    <asp:TextBox ID="txttitle" runat="server"></asp:TextBox>
                </p>
                <p class="auto-style1">&nbsp;<asp:CheckBox runat="server" OnCheckedChanged="chkbox_CheckedChanged" ID="Active" />
                </p>
                <p class="auto-style1">
                    <asp:Label ID="lblerror" runat="server"></asp:Label>
                </p>
                <p class="auto-style1">&nbsp;</p>
                <p class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnadd" runat="server" Text="Submit" OnClick="btnadd_Click" />
                </p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
            </div>
            </form>

    </div>
    


    <footer>
        <div class="footer">
            <h4> Copyright ©EliteCarlot</h4>
        </div>
    </footer>








</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
     <<div id="MainHomePage">
        <div class="btn-group">
            <p><a href="HomePage.aspx"><h2> <button>HomePage</button></h2></a></p>
            <p><a href="Login.aspx"><h2><button>Login</button></h2></a></p>
            <p><a href="Cars.aspx"><h2> <button>Cars</button></h2></a></p>
            <p><a href="Maitenance.aspx"><h2><button>Maintenance</button></h2></a></p>
            <p><a href="Payment.aspx"> <h2><button>Payment</button></h2></a></p>
        </div>
</head>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
     
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Username" ForeColor="Black"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 76px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password" ForeColor="Black"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 76px; margin-top: 8px" Width="119px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text="Label" BorderColor="Black" ForeColor="Black"></asp:Label>
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="Login_Click" style="margin-left: 126px" Text="Login" />
    
     
    </div>
    </form>
</body>
</html>

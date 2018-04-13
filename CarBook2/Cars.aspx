<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cars.aspx.cs" Inherits="Cars" %>

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
<body>
    <form id="form1" runat="server">
    <div>
             

        <asp:Label ID="SearchCarMake" runat="server" Text="Search car make"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="lblCarMake" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCarMake" runat="server" Text="Search" />
             

    </div>
    </form>
</body>
</html>

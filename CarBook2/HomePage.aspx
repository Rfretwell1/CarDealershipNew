<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>
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
         <a style="color:white"><h2> Welcome to our car dealership and maintenance website, here you can browse and purchase cars and schedule your cars for maintenance with one of our highly trained mechanics.</h2></a>
       <td><img src="../images/vehicle_maintenance.jpg" alt="Maintenance" id="VM" style="width=250px;height:350px;"> </td>
        <td><img src="../images/ferrari.png" alt="Maintenance" id="VM" style="width=250px;height:350px;"> </td>
    </div>
    </form>
</body>
</html>

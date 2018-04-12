<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PersonalProfile.aspx.cs" Inherits="PersonalProfile" %>

<!DOCTYPE html>
<html>
<head>
    <title></title>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />


</head>
<body>
    ​<header>
        <div class="header">
            <img src="Images/ferrari.png" alt="logo" />

            <h1 class="head1"> Employee Portal </h1> <button class="logout">Log Out</button>
            <h3> Welcome to your Personalised Employee Page  </h3>
        </div>
    </header>


    <div class="row">
        <div class="column">
            <div class="card">
                <img src="Images/mechanic.jpg" style="width:90%">
                <div class="container">
                    <h2>Employee Profile </h2>
                    <p> Mark Walsh </p>
                    <p> Mechanic </p>
                    <p> Employee Since 20/08/15 </p>
                    <p><button class="button">Edit</button></p>
                </div>
            </div>
        </div>
    </div>

        <footer>
            <div class="footer">
                <h4> Copyright ©EliteCarlot</h4>
            </div>
        </footer>

</body>
</html>

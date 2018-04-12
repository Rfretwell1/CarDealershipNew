<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="Images_LogIn" %>

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

            <h1 class="head1"> Employee Portal </h1> 
            <h3> please log for accsess  </h3>
        </div>
    </header>


    <h2>Login Form</h2>

    <form action="HomePage.html">
        <div class="imgcontainer">
            <img src="Images/imagesFC4SWIL5.jpg" alt="loginicon" class="avatar">
        </div>

        <div class="container">
            <label for="uname"><b>Username</b></label>
            <input type="text" placeholder="Enter Username" name="uname" required>

            <label for="psw"><b>Password</b></label>
            <input type="password" placeholder="Enter Password" name="psw" required>

       
           <button href="HomePage.html" >Login</button> 
        </div>

    </form>









</body>
</html>

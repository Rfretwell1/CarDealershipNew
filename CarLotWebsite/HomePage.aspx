<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

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
            <img src="Images/ferrari.png" alt="logo" style="height: 206px; width: 282px" />
 
             <h1 class="head1"> Employee Portal </h1> 
             <h3> Welcome to your Personalised Employee Page  </h3>
              </div> 
    <p><a href="LogIn.aspx"> <h2><button>LogOut</button></h2></a></p>
    
    </header>
    
    
    
    <div class="row">
        <div class="column">
            <div class="card">
                <img src="Images/addem.jpg"  style="width:15%; height: 168px;">
                <div class="container">
                    <h2>Add New Employee</h2>
                    <p>Click Below to add new Employee onto the system </p>
                  <p><a href="AddEmployee.aspx"> <h2><button>Add New Employee</button></h2></a></p>
</div>
            </div>
        </div>

        <div class="column">
            <div class="card">
                <img src="Images/searchem.jpg" style="width:14%; height: 152px;">
                <div class="container">
                    <h2>Search for employee</h2>
                    <p> click here to search for an employee</p>
                   <p><a href="Search.aspx"> <h2><button>Search</button></h2></a></p>
                </div>
            </div>
        </div>

        <div class="column">
            <div class="card">
                <img src="Images/pem.png"  style="width:10%; height: 117px;">
                <div class="container">
                    <h2>Personal Profile </h2>
                        <p>
                            click below to acsses your personal work profile ,
                            where you will be able to view
                            and amend your personal information
                        </p>
                         <p><a href="PersonalProfile.aspx"> <h2><button>Go</button></h2></a></p>
                </div>
            </div>
        </div>



        <div class="column">
            <div class="card">
                <img src="Images/report1.jpg"  style="width:14%; height: 118px;">
                <div class="container">
                    <h2>Reports </h2>
                    <p><a href="Reports.aspx"> <h2><button>Reports</button></h2></a></p>
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

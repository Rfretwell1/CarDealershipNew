<!DOCTYPE html>
<html>
<head>
    <title>Update Account Details</title>
	<meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <div class="btn-group">
        <p><a href="Homepage.html"><h2> <button>HomePage</button></h2></a></p>
        <p><a href="CustomerLoginAndRegister.aspx"><h2><button>Login/Register</button></h2></a></p>
        <p><a href="Cars.html"><h2> <button>Cars</button></h2></a></p>
        <p><a href="Maitenance.html"><h2><button>Maintenance</button></h2></a></p>
        <p><a href="Payment.html"> <h2><button>Payment</button></h2></a></p>
    </div>
    <div>
        <h1>Customer detail page which can allow customers the ablity to change their details if needed.</h1>
    </div>
    <table>
        <tr>
            <td>
                <a style="color:white"><h1>Customer detail page which can allow customers the ablity to change their details if needed.</h1></a>
                <form name="MessageBox" onsubmit="return messageBox()" method="post">
                    <p><input type="text" name="name" id="Fname" placeholder="First Name" autocomplete="off" tabindex="1" class="txtinput"></br></p>
                    <p><input type="text" name="name" id="Lname" placeholder="Last Name" autocomplete="off" tabindex="2" class="txtinput"></br></p>
                    <p><input type="email" name="email" id="email" placeholder="Your Email Address" autocomplete="off" tabindex="3" class="txtinput"></br> <a style="color:white"> Your Email Address will be your username for future login</a></p>
                    <p><input type="contact Number" name="Number" id="Number" placeholder="Telephone Number" autocomplete="off" tabindex="4" class="txtinput"></br></p>
                    <p><input type="Address" name="Address" id="Address" placeholder="Address" autocomplete="off" tabindex="5" class="txtinput"</p>
                    <p><input type="Postal Code" name="PostalCode" id="PostalCode" placeholder="PostalCode" autocomplete="off" tabindex="5" class="txtinput"</p>
                    <p><input type="reset" value="Reset"><br></p>
                    <button type="submit">Update</button>
                    <script>
                    function messageBox()
                    {
                    alert("Your details have been updated!");
                    }
                    </script>

            </td>
            </div>
</body>
</html>
<!DOCTYPE html>
<html>
<head>
    <title>Login/Register</title>
	<meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <div class="btn-group">
    <p><a href="Homepage.html"><h2> <button>HomePage</button></h2></a></p>
    <p><a href="CustomerLoginAndRegister.aspx"><h2><button>Login/Register</button></h2></a></p>
    <p><a href="Cars.html" ><h2> <button>Cars</button></h2></a></p>
    <p><a href="Maitenance.html"><h2><button>Maintenance</button></h2></a></p>
    <p><a href="Payment.html"> <h2><button>Payment</button></h2></a></p>
    </div>

    <div class="btn-login">
    <p style="text-align:center"><h1><b><a href="Login.aspx" style="border:double"><button>Login</button></a></font></b></h1></p>
    <p style="text-align:center"><h1><b><a href="CustomerRegister.aspx" style="border:double"><button>Register</button></a></font></b></h1></p>
    <p style="text-align:center"><h1><b><a href="CustomerUpdate.aspx" style="border:double"><button>UpdateCustomerDetails</button></a></font></b></h1></p>
        <form name="MessageBox" onsubmit="return messageBox()" method="post">
            <p style="text-align:center"><h1><b><a onsubmit="return messageBox()" style="border:double"><button>Delete Account</button></a></font></b></h1></p>
            <script>
                    function messageBox()
                    {
                    alert("Your account has been deleted");
                    }
            </script>
            </form>
</div>
</body>
</html>
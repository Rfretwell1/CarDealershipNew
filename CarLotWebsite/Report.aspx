<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Report" %>

<!DOCTYPE html>
<html>
<head>
    <title></title>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />


</head>
<body>
    <form id="form1" runat="server">
    ​<header>
        <div class="header">
            <img src="Images/ferrari.png" alt="logo" style="height: 263px; width: 370px" />

            <h1 class="head1"> Employee Portal </h1>
            <h3> Report </h3>
        </div>
    </header>


    <div class="Resulform">
        <asp:ListBox ID="lstEmployees" runat="server" Height="286px" OnSelectedIndexChanged="lstEmployees_SelectedIndexChanged" Width="397px"></asp:ListBox>
        <style type="text/css">
            .tg {
                border-collapse: collapse;
                border-spacing: 0;
                border-color: #ccc;
            }

                .tg td {
                    font-family: Arial, sans-serif;
                    font-size: 14px;
                    padding: 10px 5px;
                    border-style: solid;
                    border-width: 0px;
                    overflow: hidden;
                    word-break: normal;
                    border-color: #ccc;
                    color: #333;
                    background-color: #fff;
                    border-top-width: 1px;
                    border-bottom-width: 1px;
                }

                .tg th {
                    font-family: Arial, sans-serif;
                    font-size: 14px;
                    font-weight: normal;
                    padding: 10px 5px;
                    border-style: solid;
                    border-width: 0px;
                    overflow: hidden;
                    word-break: normal;
                    border-color: #ccc;
                    color: #333;
                    background-color: #f0f0f0;
                    border-top-width: 1px;
                    border-bottom-width: 1px;
                }

                .tg .tg-smzr {
                    font-family: "Times New Roman", Times, serif !important;
                    
                    vertical-align: top;
                }

                .tg .tg-amwm {
                    font-weight: bold;
                    text-align: center;
                    vertical-align: top;
                }

                .tg .tg-yw4l {
                    vertical-align: top;
                }
        </style>
    </div>

    <footer>
        <div class="footer">
            <h4> Copyright ©EliteCarlot</h4>
        </div>
    </footer>



    </form>



</body>
</html>

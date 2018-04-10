<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Report" %>

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
            <h3> Report </h3>
        </div>
    </header>


    <div class="Resulform">
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
        <table class="tg">
            <tr>
                <th class="tg-amwm" colspan="10">Employees</th>
            </tr>
            <tr>
                <td class="tg-smzr">E#</td>
                <td class="tg-smzr">Name</td>
                <td class="tg-smzr">Surname</td>
                <td class="tg-smzr">DOB</td>
                <td class="tg-smzr">Address</td>
                <td class="tg-smzr">Job Title</td>
                <td class="tg-smzr">Email</td>
                <td class="tg-smzr">Date Joined</td>
                <td class="tg-smzr">Active </td>
                <td class="tg-yw4l"></td>
            </tr>
            <tr>
                <td class="tg-smzr">E4536474565</td>
                <td class="tg-smzr">Mark</td>
                <td class="tg-smzr">Walsh</td>
                <td class="tg-smzr">06/04/89</td>
                <td class="tg-smzr">54 Springlane Leicester </td>
                <td class="tg-smzr">Manager </td>
                <td class="tg-smzr">mwalsh@EliteCarlot.com</td>
                <td class="tg-smzr">09/09/17</td>
                <td class="tg-smzr">yes</td>
                <td class="tg-yw4l"></td>
            </tr>
            <tr>
                <td class="tg-smzr">E5656456466</td>
                <td class="tg-smzr">Daisy</td>
                <td class="tg-smzr">Dolby</td>
                <td class="tg-smzr">09/08/89</td>
                <td class="tg-smzr">34 Manley Lane Leicester</td>
                <td class="tg-smzr">Sales Operative </td>
                <td class="tg-smzr">dd@gmail.com</td>
                <td class="tg-smzr">10/09/17</td>
                <td class="tg-smzr">yes</td>
                <td class="tg-yw4l"></td>
            </tr>
            <tr>
                <td class="tg-smzr">E3453657457</td>
                <td class="tg-smzr">Ken</td>
                <td class="tg-smzr">Mcfisher</td>
                <td class="tg-smzr">09/05/87</td>
                <td class="tg-smzr">103 Newarke Street Leicester</td>
                <td class="tg-smzr">Sale Operative </td>
                <td class="tg-smzr">kenMC@gmail.com</td>
                <td class="tg-smzr">10/09/17</td>
                <td class="tg-smzr">yes</td>
                <td class="tg-yw4l"></td>
            </tr>
            <tr>
                <td class="tg-smzr">E5685634576</td>
                <td class="tg-smzr">Sophie</td>
                <td class="tg-smzr">Love</td>
                <td class="tg-smzr">05/09/98</td>
                <td class="tg-smzr">53 Bingo Lane</td>
                <td class="tg-smzr">Sales Operative </td>
                <td class="tg-smzr">Sophie.love@gmail.com</td>
                <td class="tg-smzr">12/09/17</td>
                <td class="tg-smzr">yes</td>
                <td class="tg-yw4l"></td>
            </tr>
            <tr>
                <td class="tg-smzr">E4576457457</td>
                <td class="tg-smzr">Jacob</td>
                <td class="tg-smzr">Jackson</td>
                <td class="tg-smzr">31/01/92</td>
                <td class="tg-smzr">64 Alpine Avenue </td>
                <td class="tg-smzr">Mechanic </td>
                <td class="tg-smzr">JJackson@yahoo.co.uk</td>
                <td class="tg-smzr">12/09/17</td>
                <td class="tg-smzr">yes</td>
                <td class="tg-yw4l"></td>
            </tr>
            <tr>
                <td class="tg-smzr">E3534656466</td>
                <td class="tg-smzr">Micheal</td>
                <td class="tg-smzr">Minister</td>
                <td class="tg-smzr">31/12/95</td>
                <td class="tg-smzr">65 Mason Drive</td>
                <td class="tg-smzr">Team Leader </td>
                <td class="tg-smzr">Michael.Minister@outlook.co.uk</td>
                <td class="tg-smzr">14/09/17</td>
                <td class="tg-smzr">yes</td>
                <td class="tg-yw4l"></td>
            </tr>
            <tr>
                <td class="tg-smzr">E3523668786</td>
                <td class="tg-smzr">Maxwell</td>
                <td class="tg-smzr">Love</td>
                <td class="tg-smzr">28/02/90</td>
                <td class="tg-smzr">108 Chingham Way </td>
                <td class="tg-smzr">Mechanic</td>
                <td class="tg-smzr">Maxwell.Work@gmail.com</td>
                <td class="tg-smzr">01/01/17</td>
                <td class="tg-smzr">yes</td>
                <td class="tg-yw4l"></td>
            </tr>
        </table>
    </div>

    <footer>
        <div class="footer">
            <h4> Copyright ©EliteCarlot</h4>
        </div>
    </footer>



</body>
</html>

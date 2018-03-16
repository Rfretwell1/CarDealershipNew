<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateEmployee.aspx.cs" Inherits="UpdateEmployee" %>

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

        </div>
    </header>




    <div>
        
        <form id="form_71736" method="post" action=""> 
            <div class="form_description">
                <h2> Update Information </h2>
                <p> Fill in the form bellow and make changes to any information that are incorect 
                
                </p>
            </div>
   
            <ul>

                <li id="li_1">
                    <label class="description" for="element_1">Name </label>
                    <div>
                        <input id="element_1" name="element_1" class="element text medium" type="text" maxlength="255" value="" />
                    </div>
                </li>
                <li id="li_2">
                    <label class="description" for="element_2">Surname </label>
                    <div>
                        <input id="element_2" name="element_2" class="element text medium" type="text" maxlength="255" value="" />
                    </div>
                </li>
                <li id="li_3">
                    <label class="description" for="element_3">Date of Birth </label>
                    <span>
                        <input id="element_3_1" name="element_3_1" class="element text" size="2" maxlength="2" value="" type="text"> /
                        <label for="element_3_1">MM</label>
                    </span>
                    <span>
                        <input id="element_3_2" name="element_3_2" class="element text" size="2" maxlength="2" value="" type="text"> /
                        <label for="element_3_2">DD</label>
                    </span>
                    <span>
                        <input id="element_3_3" name="element_3_3" class="element text" size="4" maxlength="4" value="" type="text">
                        <label for="element_3_3">YYYY</label>
                    </span>

                 
                 

                </li>
                <li id="li_10">
                    <label class="description" for="element_10">Address </label>

                    <div>
                        <input id="element_10_1" name="element_10_1" class="element text large" value="" type="text">
                        <label for="element_10_1">Street Address</label>
                    </div>

                    <div>
                        <input id="element_10_2" name="element_10_2" class="element text large" value="" type="text">
                        <label for="element_10_2">Address Line 2</label>
                    </div>

                    <div class="left">
                        <input id="element_10_3" name="element_10_3" class="element text medium" value="" type="text">
                        <label for="element_10_3">City</label>
                    </div>

                    <div class="right">
                        <input id="element_10_4" name="element_10_4" class="element text medium" value="" type="text">
                        <label for="element_10_4">State / Province / Region</label>
                    </div>

                    <div class="left">
                        <input id="element_10_5" name="element_10_5" class="element text medium" maxlength="15" value="" type="text">
                        <label for="element_10_5">Postal / Zip Code</label>
                    </div>

                    <div class="right">
                        <select class="element select medium" id="element_10_6" name="element_10_6">
                            <option value="" selected="selected"></option>


                        </select>
                        <label for="element_10_6">Country</label>
                    </div>
                </li>
                <li id="li_5">
                    <label class="description" for="element_5">Job Title </label>
                    <div>
                        <input id="element_5" name="element_5" class="element text medium" type="text" maxlength="255" value="" />
                    </div>
                </li>
                <li id="li_6">
                    <label class="description" for="element_6">Email </label>
                    <div>
                        <input id="element_6" name="element_6" class="element text medium" type="text" maxlength="255" value="" />
                    </div>
                </li>
                <li id="li_7">
                    <label class="description" for="element_7">Mobile </label>
                    <div>
                        <input id="element_7" name="element_7" class="element text medium" type="text" maxlength="255" value="" />
                    </div>
                </li>
                <li id="li_8">
                    <label class="description" for="element_8">Date Joined </label>
                    <span>
                        <input id="element_8_1" name="element_8_1" class="element text" size="2" maxlength="2" value="" type="text"> /
                        <label for="element_8_1">MM</label>
                    </span>
                    <span>
                        <input id="element_8_2" name="element_8_2" class="element text" size="2" maxlength="2" value="" type="text"> /
                        <label for="element_8_2">DD</label>
                    </span>
                    <span>
                        <input id="element_8_3" name="element_8_3" class="element text" size="4" maxlength="4" value="" type="text">
                        <label for="element_8_3">YYYY</label>
                    </span>

                   

                </li>
                <li id="li_9">
                    <label class="description" for="element_9"> </label>
                    <span>
                        <input id="element_9_1" name="element_9_1" class="element checkbox" type="checkbox" value="1" />
                        <label class="choice" for="element_9_1">Active</label>
                    </span>
                </li>

                <li class="buttons">
                    <input type="hidden" name="form_id" value="71736" />

                    <input id="saveForm" class="button_text" type="submit" name="submit" value="Submit" />
                </li>
            </ul>
       
    
     </form>

    </div>
 



    <footer>
        <div class="footer">
            <h4> Copyright ©EliteCarlot</h4>
        </div>
    </footer>








</body>
</html>

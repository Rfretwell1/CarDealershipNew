﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            // update the list 
            DisplayEmployee();
        }

                // update the list box

   // WHY IS THIS NOT WORKING 
    }

    void DisplayEmployee()
    {
       
    }
}
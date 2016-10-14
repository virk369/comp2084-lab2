using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson6_COMP2084
{
    public partial class tip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            /* get amount from the textbox
             * save in a variable of double (which hold decimals)
             * first we have to convert the value from a string to a double
             */
            Double amount = Convert.ToDouble(txtAmount.Text);

            // get tip percent
            Double tipPercent = Convert.ToDouble(ddlPercent.SelectedValue);

            // calculate the tip and total
            Double tipAmount = amount * tipPercent;
            Double total = amount + tipAmount;

            // display result
            lblTip.Text = tipAmount.ToString();
            lblTotal.Text = total.ToString();
        }
    }
}
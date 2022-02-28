using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio5
{
    public partial class ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double salarioant, salario,vlrsuba;
            salarioant = Convert.ToDouble(txtslant.Text);
            vlrsuba = salarioant * .25;
            salario = salarioant + vlrsuba;
            lblnsal.Text = System.Convert.ToString(salario);



        }
    }
}
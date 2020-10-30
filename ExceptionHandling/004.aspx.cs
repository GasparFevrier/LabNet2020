using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionHandling
{
    public partial class _004_MyExeption : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Models.Logic objLogic = new Models.Logic();

            try
            {
                objLogic.ThrowMyExcepcion();
            }
            catch (Exception ex)  
            {
                this.TextBox1.Text = ex.Message;
            }
        }
    }
}
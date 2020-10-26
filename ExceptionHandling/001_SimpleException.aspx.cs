using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionHandling
{
    public partial class _001_SimpleException : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 100;
                int b = 0;
                
                int resultado = a / b;
            }
            catch (Exception Ex)
            {
                this.TextBox1.Text = Ex.Message;
            }
            finally
            {
                this.TextBox2.Text = "Finalizo !!!!";
            }          

        }
    }
}
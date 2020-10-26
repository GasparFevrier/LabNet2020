using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionHandling
{
    public partial class _002_DoubleCatch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public float divideNumeros(int num1, int num2)
        {
            float resultado = 0;
            resultado = num1 / num2;
            return resultado;
        }


        protected void Button_Dividir_Click(object sender, EventArgs e)
        {
            float res = 0;
            int num1, num2 = 0;
            
            try
            {
                if (Int32.TryParse(TextBox_Dividendo.Text, out num1) && Int32.TryParse(TextBox_Divisor.Text, out num2))
                {

                    if (num2 != 0)
                    {
                        try
                        {
                            num1 = Int32.Parse(TextBox_Dividendo.Text);
                            num2 = Int32.Parse(TextBox_Divisor.Text);

                            res = divideNumeros(num1, num2);
                            this.TextBox_Resultado.Text = res.ToString();
                        }
                        catch (Exception Ex)
                        {
                            this.TextBox_Exep.Text = Ex.Message;
                        }
                    }
                    else
                    {
                        throw new Exception("Ameooo no podes dividir por 0");
                    }
                }
                else
                {
                    throw new Exception("Ingresaste una letra !!!");
                }

            }
            catch (Exception excepcion)
            {
                this.TextBox_Resultado.Text = "";
                this.TextBox_Exep.Text = excepcion.Message;
            }

        }

        protected void TextBox_Exep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using Modificadores_de_acesso_mais_completo.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Modificadores_de_acesso_mais_completo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Para instanciar não é preciso quanto se tem o item como static
        // Calculadora rm = new Calculadora();

        Produto prod = new Produto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            valor1 = Convert.ToDouble(Textentrada.Text);
            valor1 = Calculadora.Circunferencia(10);
            valor2 = valor1 * Calculadora.pi;
            Textresultado.Text = Convert.ToString(valor2);

         


            

        }
    }
}
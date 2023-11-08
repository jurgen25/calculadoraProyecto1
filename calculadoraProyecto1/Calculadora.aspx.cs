using System;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculadoraProyecto1
{
    public partial class Calculadora : Page
    {   protected TextBox Display;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Esto asegura que el campo de visualización este vacío al cargar la página
                TextBox Display = FindControl("Display") as TextBox;
                Display.Text = string.Empty;
            }
        }

        protected void Numero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            // Agrega el número presionado a la visualización
            Display.Text += boton.Text;
        }

        protected void Operador_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            // Guarda el primer número y el operador seleccionado.
            ViewState["PrimerNumero"] = Display.Text;
            ViewState["Operador"] = boton.Text;
            // Limpia el campo de visualización
            Display.Text = "";
        }

        protected void Borrar_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            // Limpia cualquier valor guardado en ViewState
            ViewState.Clear();
        }

        protected void Igual_Click(object sender, EventArgs e) // Realiza la operación matemática y muestra el resultado en la visualización
        {
            if (ViewState["PrimerNumero"] != null && ViewState["Operador"] != null)
            {
                double primerNumero = double.Parse(ViewState["PrimerNumero"].ToString());
                double segundoNumero = double.Parse(Display.Text);
                string operacion = ViewState["Operador"].ToString();
                // Realiza la operación matemática adecuada y muestra el resultado en el campo de visualización
                switch (operacion)
                {
                    case "+":
                        Display.Text = (primerNumero + segundoNumero).ToString();
                        break;
                    case "-":
                        Display.Text = (primerNumero - segundoNumero).ToString();
                        break;
                    case "*":
                        Display.Text = (primerNumero * segundoNumero).ToString();
                        break;
                    case "/":
                        if (segundoNumero != 0)
                        {
                            Display.Text = (primerNumero / segundoNumero).ToString();
                        }
                        else
                        {
                            Display.Text = "Error"; // Es por si se divide en 0
                        }
                        break;
                }
            }
        }

        protected void RaizCuadrada_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Display.Text))
            {
                double numero = double.Parse(Display.Text);
                Display.Text = Math.Sqrt(numero).ToString();
            }
        }

        protected void Potencia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Display.Text))
            {
                double baseNumero = double.Parse(ViewState["PrimerNumero"].ToString());
                double exponente = double.Parse(Display.Text);
                Display.Text = Math.Pow(baseNumero, exponente).ToString();
            }
        }

        protected void DiezALaX_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Display.Text))
            {
                double numero = double.Parse(Display.Text);
                double resultado = Math.Pow(10, numero);
                Display.Text = resultado.ToString();
            }
        }

        protected void Logaritmo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Display.Text))
            {
                double numero = double.Parse(Display.Text);
                double resultado = Math.Log10(numero);
                Display.Text = resultado.ToString();
            }
        }

        protected void Cuadrado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Display.Text))
            {
                double numero = double.Parse(Display.Text);
                double resultado = Math.Pow(numero, 2);
                Display.Text = resultado.ToString();
            }
        }

        protected void Factorial_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(Display.Text))
                {
                    int numero = int.Parse(Display.Text);

                    if (numero < 0)
                    {
                        Display.Text = "Error";
                    }
                    else
                    {
                        int resultado = 1;
                        for (int i = 1; i <= numero; i++)
                        {
                            resultado *= i;
                        }
                        Display.Text = resultado.ToString();
                    }
                }
            }
        }
        //Agrega una coma al número
        protected void Coma_Click(object sender, EventArgs e)
        {
            if (!Display.Text.Contains("."))
            {
                Display.Text += ".";
            }
        }
        //Cambia el signo del numro (positivo/negativo)
        protected void CambioSigno_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Display.Text))
            {
                double numero = double.Parse(Display.Text);
                numero = -numero;
                Display.Text = numero.ToString();
            }
        }

        protected void RaizCuadradaConExponente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Display.Text))
            {
                double numero = double.Parse(Display.Text);
                double resultado = Math.Pow(Math.Sqrt(numero), 2);
                Display.Text = resultado.ToString();
            }
        }
    }
}
    


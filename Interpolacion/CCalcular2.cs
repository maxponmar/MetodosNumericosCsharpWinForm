using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raizesMN
{
    public class CCalcular2
    {
        private static double[,] SEL;

        public static double[,] XY { get; private set; }

        public static void CalcularAFS(int n, int cont, TextBox txtResultado, ComboBox cbxMetodos, Panel panelDatos)
        {
            XY = new double[2, n];
            SEL = new double[n, n + 1];
            
            txtResultado.Clear();
            if (CCalcular2.ComprobarTablaMetodo(cbxMetodos,cont))
            {
                if (CCalcular2.SeguridadAFS(cbxMetodos, n))
                {
                    CCalcular2.GuardarDatos(panelDatos);
                    CInterpolar.AcumFunSim(cbxMetodos, SEL, XY, txtResultado);
                }
            }         
        }

        public static void CalcularACMC(int n, int cont, TextBox txtResultado, ComboBox cbxMetodos, Panel panelDatos, TextBox txtDatosf)
        {
            XY = new double[2, n];
            SEL = new double[n, n + 1];

            txtResultado.Clear();
            if (CCalcular2.ComprobarTablaMetodo(cbxMetodos, cont))
            {
                CCalcular2.GuardarDatos(panelDatos);
                CInterpolar.AjCurMinCua(cbxMetodos, SEL, XY, n, txtResultado, txtDatosf);
            }
        }

        public static void CalcularDDFN(int n, int cont, TextBox txtResultado, Panel panelDatos)
        {
            XY = new double[2, n];
            SEL = new double[n, n + 1];
            txtResultado.Clear();
            if (cont==1)
            {
                CCalcular2.GuardarDatos(panelDatos);
                CInterpolar.DDFNewton(XY, n, txtResultado);
            }
            else
            {
                MessageBox.Show("Crea una tabla para poder utilizar el metodo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CalcularL(int n, int cont, TextBox txtResultado, Panel panelDatos)
        {
            XY = new double[2, n];
            SEL = new double[n, n + 1];
            txtResultado.Clear();
 
           CCalcular2.GuardarDatos(panelDatos);
            CInterpolar.Lagrange(XY, n, txtResultado);
        }

        public static void CalcularS(int n, int cont, ComboBox cbxMetodos, Panel panelDatos, ListBox lbxResultado)
        {
            XY = new double[2, n];
            SEL = new double[n, n + 1];
            lbxResultado.Items.Clear();
            if (CCalcular2.ComprobarTablaMetodo(cbxMetodos, cont))
            {
                CCalcular2.GuardarDatos(panelDatos);
                CInterpolar.Splines(cbxMetodos, XY, n, lbxResultado);
            }
        }

        public static void EvaluarDato1(TextBox txtResultado, double dato, TextBox txtResEv)
        {
            string funcion = txtResultado.Text; 
            if (string.IsNullOrEmpty(funcion))
            {
                MessageBox.Show("Aun no hay una función para evaluar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    double resultado; 
                    MathParser miFunc = new MathParser();
                    miFunc.ProgrammaticallyParse("let x = " + dato.ToString());
                    resultado = miFunc.Parse(funcion);
                    txtResEv.Text = resultado.ToString();                
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error, tal vez la funcion es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public static void EvaluarDato2(ListBox lbxResultado, double dato, TextBox txtResEv, int n, Panel panelDatos) // Para splines
        {
            // obtener la funcion 
            string funcion="";

            GuardarDatos(panelDatos);


            for (int i = 0; i < n-1; i++)
            {               
                if ((dato>=XY[0,i]) && (dato <= XY[0, i + 1]))
                {
                    funcion = lbxResultado.Items[i].ToString();                    
                }
            }
            
            if (string.IsNullOrEmpty(funcion))
            {
                MessageBox.Show("Aun no hay una función para evaluar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    double resultado;
                    MathParser miFunc = new MathParser();
                    miFunc.ProgrammaticallyParse("let x = " + dato.ToString());
                    resultado = miFunc.Parse(funcion);
                    txtResEv.Text = resultado.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error, tal vez la funcion es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public static bool SeguridadAFS(ComboBox cbxMetodos, int n)
        {
            switch (cbxMetodos.SelectedIndex)
            {
                case 1:
                    // Cuadratica
                    if (n < 3)
                    { MessageBox.Show("El mínimo de datos es 3, porfavor crea una nueva tabla adecuada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                    else
                        return true;              
                case 2:
                    // Cubica
                    if (n < 4)
                    { MessageBox.Show("El mínimo de datos es 4, porfavor crea una nueva tabla adecuada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
                    else
                        return true;
                default:
                    return true;
            }
        }

        public static void GuardarDatos(Panel panelDatos)
        {
            int f = 0, c = 0, cont = 0;
            // Recorrer todos los txtbox del panel para almacenar los datos en la matriz
            foreach (Control txtBox in panelDatos.Controls)
            {
                if (txtBox is TextBox)
                {
                    if (cont < 20)
                    {
                        f = Convert.ToInt32(txtBox.Name.Substring(0, 1));
                        c = Convert.ToInt32(txtBox.Name.Substring(1, 1));
                    }
                    if (cont >= 20)
                    {
                        f = Convert.ToInt32(txtBox.Name.Substring(0, 2));
                        c = Convert.ToInt32(txtBox.Name.Substring(2, 1));
                    }
                    XY[c, f] = Convert.ToDouble(txtBox.Text);
                    cont++;
                }
            }
        }

        public static bool ComprobarTablaMetodo(ComboBox cbxMetodos, int cont)
        {
            if (cbxMetodos.SelectedIndex == -1)
            {
                MessageBox.Show("Elije el método", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                if (cont == 0)
                {
                    MessageBox.Show("No existe una tabla de datos para trabajar, introduce una tabla", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}

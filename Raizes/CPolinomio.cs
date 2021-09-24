using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace raizesMN
{
    class CPolinomio
    {
        private static int xPos;

        public static void CrearTextBoxs(int n, Panel panelMatriz)
        {
            xPos = 0; 
            for (int m = 0; m < n + 1; m++)
            {
                // Crear instancia de TextBox
                TextBox txtbSEL = new TextBox();
                // Colocar propiedades
                txtbSEL.Height = 20; txtbSEL.Width = 35;
                txtbSEL.Location = new Point(xPos, 0);
                txtbSEL.Name = m.ToString();
                txtbSEL.Text = "0"; txtbSEL.TextAlign = HorizontalAlignment.Right;
                // Añadir Handler de KeyPress a los txtbox
                txtbSEL.KeyPress += new KeyPressEventHandler(txtBox_KeyPress);

                panelMatriz.Controls.Add(txtbSEL);
                xPos += 38;
                if (m == n)
                    xPos = 0;
            }
        }

        // Evento keypress para todos los txtbx del polinomio
        public static void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45|| e.KeyChar == 46) { }
            else
            {
                formSEL.solonumeros(e);
            }
        }

        public static string obtenerPolinomio(TextBox txtN, Panel panelPolinomio)
        {
            string polinomioString="";
            int n = Convert.ToInt32(txtN.Text);
            double[] polinomio = new double[n + 1];
            int f;
            foreach (Control txtBox in panelPolinomio.Controls)
            {
                if (txtBox is TextBox)
                {
                    f = Convert.ToInt32(txtBox.Name.Substring(0, 1));
                    polinomio[f] = Convert.ToDouble(txtBox.Text);
                }
            }
            polinomioString = string.Format("({0}) +", polinomio[0]);
            polinomioString += string.Format("({0}*x) +", polinomio[1]);
            for (int i = 2; i < n; i++)
            {
                polinomioString += string.Format("({0})*x^{1} +", polinomio[i], i);
            }
            polinomioString += string.Format("({0})*x^{1}", polinomio[n], n);
            return polinomioString;
        }
    }
}

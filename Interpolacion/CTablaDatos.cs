using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace raizesMN
{
    public class CTablaDatos
    {
        private static int xPos,yPos;

        private static void CrearTablaDatos(TextBox txtN, Label lblTabla, Label lblX, Label lblY, Panel panelDatos)
        {
            int n;
            xPos = 0; yPos = 0;
            if (Convert.ToInt32(txtN.Text) < 2 || string.IsNullOrEmpty(txtN.Text))
            {
                txtN.Text = "2"; MessageBox.Show("El valor mínimo es 2", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            n = Convert.ToInt32(txtN.Text);
            lblTabla.Visible = true; lblX.Visible = true; lblY.Visible = true;
            for (int i = 0; i < n; i++)
            {
                for (int m = 0; m < 2; m++)
                {
                    // Crear instancia de TextBox
                    TextBox txtbSEL = new TextBox();
                    // Colocar propiedades
                    txtbSEL.Height = 20; txtbSEL.Width = 35;
                    txtbSEL.Location = new Point(xPos, yPos);
                    txtbSEL.Name = i.ToString() + m.ToString();
                    txtbSEL.Text = "0"; txtbSEL.TextAlign = HorizontalAlignment.Right;
                    // Añadir Handler de KeyPress a los txtbox
                    txtbSEL.KeyPress += new KeyPressEventHandler(txtBox_KeyPress);

                    panelDatos.Controls.Add(txtbSEL);
                    yPos += 23;
                    if (m == 1)
                        yPos = 0;
                }
                xPos += 38;
            }
        }

        private static void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 || e.KeyChar == 46) { }
            else
            {
                formInterpolacion.solonumeros(e);
            }
        }

        public static int[] ImprimirTabla(int cont, TextBox txtN, Label lblTabla, Label lblX, Label lblY, Panel panelDatos)
        {
            int[] datos = new int[2]; // 0=cont 1=n
            if (cont == 1)
            {
                DialogResult resultado = MessageBox.Show("Ya existe una tabla de datos \r\n ¿Deseas elminiar la tabla actual para crear una nueva?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    borrarDatos(panelDatos, lblTabla, lblX, lblY);
                    datos[0] = 0; txtN.Enabled = true;
                }
                else
                { datos[0] = 1; }
            }
            else
            {
                CTablaDatos.CrearTablaDatos(txtN, lblTabla, lblX, lblY, panelDatos);
                datos[0] = 1; datos[1] = Convert.ToInt32(txtN.Text);
                txtN.Enabled = false;
            }
            return datos;
        }

        public static void BorrarTabla(Panel panelDatos, Label lblTabla, Label lblX, Label lblY, TextBox txtResultado, TextBox txtN)
        {
            borrarDatos(panelDatos, lblTabla, lblX, lblY);
            txtResultado.Clear();
            
            txtN.Enabled = true;
        }
        public static void BorrarTabla(Panel panelDatos, Label lblTabla, Label lblX, Label lblY, ListBox lbxResultados, TextBox txtN)
        {
            borrarDatos(panelDatos, lblTabla, lblX, lblY);
            lbxResultados.Items.Clear();

            txtN.Enabled = true;
        }
        public static void borrarDatos(Panel panelDatos, Label lblTabla, Label lblX, Label lblY)
        {
            panelDatos.Controls.Clear();
            lblTabla.Visible = false; lblX.Visible = false; lblY.Visible = false;
        }
    }
}

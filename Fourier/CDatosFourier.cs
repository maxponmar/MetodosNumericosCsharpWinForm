using System;
using System.Windows.Forms;
using System.Drawing;

namespace raizesMN
{
    class CDatosFourier
    {
        private int xPos, yPos;

        public void CrearTablaDatos(TextBox txtN, Panel panelDatos,Label lbldatos1, Label lblIndice,Label lblFt, Label lblT)
        {
            int n; 
            xPos = 38; yPos = 0;

            if (string.IsNullOrEmpty(txtN.Text)||Convert.ToInt32(txtN.Text) < 2)
            {
                txtN.Text = "2"; MessageBox.Show("El valor mínimo es 2", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            n = Convert.ToInt32(txtN.Text);
            lbldatos1.Visible = true; lblIndice.Visible = true;lblFt.Visible = true;lblT.Visible = true; 
            for (int i = 0; i < 2; i++)
            {
                for (int m = 0; m < n; m++)
                {
                    Label lblDato = new Label();                 
                    TextBox txtbSEL = new TextBox();
                    // Propiedades
                    lblDato.Name = string.Format("{0}{1}lbl", i, m);
                    lblDato.Text = (m+1).ToString();
                    lblDato.Location = new Point(3, yPos+3);
                    lblDato.Size = new Size(35, 20);
                    panelDatos.Controls.Add(lblDato);

                    txtbSEL.Height = 20; txtbSEL.Width = 35;
                    txtbSEL.Location = new Point(xPos, yPos);
                    txtbSEL.Name = string.Format("{0},{1}", i, m);
                    txtbSEL.Text = "0"; txtbSEL.TextAlign = HorizontalAlignment.Right;
                    // Añadir Handler de KeyPress a los txtbox
                    txtbSEL.KeyPress += new KeyPressEventHandler(txtBox_KeyPress);

                    panelDatos.Controls.Add(txtbSEL);
                    yPos += 23;
                    if (m == n - 1)
                        yPos = 0;
                }
                xPos += 38;
            }
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 || e.KeyChar == 46) { }
            else
            {
                if (e.KeyChar == 45 || e.KeyChar == 46) { }
                else
                {
                    formFourier.solonumerosNegDec(e);
                }
            }
        }

        public void ObtenerDatos(Panel pnlTabla,ref double [,] tft)
        {
            int f = 0, c = 0; string[] indice;
            // Recorrer todos los txtbox del panel para almacenar los datos en la matriz
            foreach (Control txtBox in pnlTabla.Controls)
            {
                if (txtBox is TextBox)
                {
                    indice = txtBox.Name.Split(',');
                    c = Convert.ToInt32(indice[0]);
                    f = Convert.ToInt32(indice[1]);
                    tft[c, f] = Convert.ToDouble(txtBox.Text);
                }
            }           
        }      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raizesMN
{
    public partial class formEqnDiferenciales : Form
    {
        private string ecuacion;
        private int cont, n, m;
        private double h, x, y, xn, yn, memoria, k = 0, k1, k2, k3, k4;

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            formGrafica miGraf = new formGrafica();
            miGraf.Show();
        }

        private void cbxMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cont = 1;
            if (cbxMetodos.SelectedIndex == 1)
            {
                txtM.Visible = true; lblGMejora.Visible = true;
            }
            else
            {
                txtM.Visible = false; lblGMejora.Visible = false;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asegurate de introducir todos los datos y de no equivocarte en las condicones iniciales ya que son muy importantes", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public formEqnDiferenciales()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MathParser eqnDiferencial = new MathParser();
            if (cont == 0)
            {
                MessageBox.Show("Elije un método para resolver la ecuación diferencial", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtEcuacion.Text))
                {
                    MessageBox.Show("Introduce una ecuación", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Inicializar txtbox vacíos
                    txtResultado.Clear();
                    // Almacenar ecuación y datos             
                    ecuacion = txtEcuacion.Text; lblEcuacion.Text = string.Format("y´(x)= {0}", ecuacion);
                    h = Convert.ToDouble(txtH.Text);
                    conIncLbl.Text = "y(" + txtX0.Text + ")=" + txtY0.Text;
                    x = Convert.ToDouble(txtX0.Text); y = Convert.ToDouble(txtY0.Text);
                    h = Convert.ToDouble(txtH.Text); n = Convert.ToInt32(txtNYs.Text);
                    switch (cbxMetodos.SelectedIndex)
                    {
                        case 0: // Euler

                            for (int i = 0; i < n; i++)
                            {
                                eqnDiferencial.ProgrammaticallyParse("let x =" + x.ToString());
                                eqnDiferencial.ProgrammaticallyParse("let y =" + y.ToString());
                                y = y + h * eqnDiferencial.Parse(ecuacion);
                                txtResultado.AppendText("y" + (i + 1).ToString() + "= " + y.ToString() + Environment.NewLine);
                                x += h;
                            }
                            break;
                        case 1: // Euler mejorado
                            m = Convert.ToInt32(txtM.Text);
                            xn = x - h; yn = y;
                            for (int i = 0; i < n; i++)
                            {
                                xn += h; k++;
                                for (int j = 0; j < m; j++)
                                {
                                    eqnDiferencial.ProgrammaticallyParse("let x =" + x.ToString());
                                    eqnDiferencial.ProgrammaticallyParse("let y =" + y.ToString());
                                    memoria = eqnDiferencial.Parse(ecuacion);
                                    eqnDiferencial.ProgrammaticallyParse("let x =" + xn.ToString());
                                    eqnDiferencial.ProgrammaticallyParse("let y =" + yn.ToString());
                                    yn = y + h * (memoria + eqnDiferencial.Parse(ecuacion)) / 2.0;
                                    if (k == 1) { xn += h; }
                                    k++;
                                }
                                txtResultado.AppendText("y" + (i + 1).ToString() + "= " + yn.ToString() + Environment.NewLine);
                                y = yn;
                            }
                            break;

                        case 2: // Runge-Kutta
                            for (int i = 0; i < n; i++)
                            {
                                eqnDiferencial.ProgrammaticallyParse("let x =" + x.ToString());
                                eqnDiferencial.ProgrammaticallyParse("let y =" + y.ToString());
                                k1 = h * eqnDiferencial.Parse(ecuacion);
                                eqnDiferencial.ProgrammaticallyParse("let x =" + (x + (h / 2)).ToString());
                                eqnDiferencial.ProgrammaticallyParse("let y =" + (y + (k1 / 2)).ToString());
                                k2 = h * eqnDiferencial.Parse(ecuacion);
                                eqnDiferencial.ProgrammaticallyParse("let x =" + (x + (h / 2)).ToString());
                                eqnDiferencial.ProgrammaticallyParse("let y =" + (y + (k2 / 2)).ToString());
                                k3 = h * eqnDiferencial.Parse(ecuacion);
                                eqnDiferencial.ProgrammaticallyParse("let x =" + (x + (h / 2)).ToString());
                                eqnDiferencial.ProgrammaticallyParse("let y =" + (y + (k3 / 2)).ToString());
                                k4 = h * eqnDiferencial.Parse(ecuacion);
                                k = (1.0 / 6.0) * (k1 + (2 * k2) + (2 * k3) + k4);
                                y += k; x += h;
                                txtResultado.AppendText("y" + (i + 1).ToString() + "= " + y.ToString() + Environment.NewLine);
                            }
                            break;
                    }
                }
            }
        }

        #region Solo numeros       
        private void solonumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar);
            if (!char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo se permiten números enteros o positivos");
        }

        private void txtX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 || e.KeyChar == 46) { }
            else
            {
                solonumeros(e);
            }
        }

        private void txtH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) { }
            else
            {
                solonumeros(e);
            }
        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }
        #endregion
    }
}

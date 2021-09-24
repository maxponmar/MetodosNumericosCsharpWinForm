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
    public partial class formIntegracion : Form
    {
        private string funcion;
        private double lim1, lim2, h, x, zy, zy1, zy2, t, resultado;       
        private int cont, n;

        public formIntegracion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MathParser integracion = new MathParser();
            if (cont == 0)
            {
                MessageBox.Show("Elije un método de integración", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    funcion = txtEcuacion.Text; lblEcuacion.Text = string.Format("({0}) dx", funcion);
                    h = Convert.ToDouble(txtH.Text);
                    if (h == 0)
                    {
                        h = 1; txtH.Text = h.ToString();
                        MessageBox.Show("h no puede valer 0", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    lim1 = Convert.ToDouble(txtLim1.Text); lim2 = Convert.ToDouble(txtLim2.Text);
                    if (lim1 > lim2)
                    {
                        txtLim1.Text = lim2.ToString(); txtLim2.Text = lim1.ToString();
                        lim1 = Convert.ToDouble(txtLim1.Text); lim2 = Convert.ToDouble(txtLim2.Text);
                        MessageBox.Show("El límite inferior debe de ser menor al límite superior", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    lblLimA.Text = lim1.ToString(); lblLimB.Text = lim2.ToString();

                    n = Convert.ToInt32(((lim2 - lim1) / h) + 1);
                    lblN.Text = "n =  " + Convert.ToString(n - 1);
                    double[] fx = new double[n];
                    switch (cbxMetodos.SelectedIndex)
                    {
                        case 0: // Trapezoidal 
                            x = lim1; zy = 0;
                            for (int i = 0; i < n; i++)
                            {
                                integracion.ProgrammaticallyParse("let x =" + x.ToString());
                                fx[i] = integracion.Parse(funcion);
                                x += h;
                            }
                            for (int i = 1; i < n - 1; i++)
                            {
                                zy += fx[i];
                            }
                            resultado = (h / 2) * (fx[0] + (2 * zy) + fx[n - 1]);
                            txtResultado.Text = resultado.ToString();
                            break;
                        case 1: // Simpson 1/3
                            x = lim1; zy1 = 0; zy2 = 0;
                            for (int i = 0; i < n; i++)
                            {
                                integracion.ProgrammaticallyParse("let x =" + x.ToString());
                                fx[i] = integracion.Parse(funcion);
                                x += h;
                            }
                            for (int i = 2; i <= n - 3; i += 2)
                            {
                                zy1 += fx[i];
                            }
                            for (int i = 1; i <= n - 2; i += 2)
                            {
                                zy2 += fx[i];
                            }
                            resultado = (h / 3) * (fx[0] + (2 * zy1) + (4 * zy2) + fx[n - 1]);
                            txtResultado.Text = resultado.ToString();
                            break;

                        case 2: // Simpson 3/8
                            x = lim1; zy1 = 0; zy2 = 0; t = 1;
                            for (int i = 0; i < n; i++)
                            {
                                integracion.ProgrammaticallyParse("let x =" + x.ToString());
                                fx[i] = integracion.Parse(funcion);
                                x += h;
                            }
                            for (int i = 3; i < n - 1; i += 3)
                            {
                                zy1 += fx[i];
                            }
                            for (int i = 1; i <= n - 2; i++)
                            {
                                if (t < 3)
                                {
                                    zy2 += fx[i];
                                    t++;
                                }
                                else
                                {
                                    t = 1;
                                }
                            }
                            resultado = ((3 * h) / 8) * (fx[0] + (2 * zy1) + (3 * zy2) + fx[n - 1]);
                            txtResultado.Text = resultado.ToString();
                            break;
                    }
                }
            }
        }

        private void cbxMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cont = 1;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elije cualquiera de los métodos de interpolacion e indica la longitud h, entre mas pequeño mas preciso \r\nLa etiqueta n= indica el número de áreas que fueron creadas para encontrar la integral", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            CSeguridadGraf miGraficar = new CSeguridadGraf();
            miGraficar.SeguradadGrafica3(funcion, lim1, lim2);
        }

        #region Solo numeros
        private void solonumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar);
            if (!char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo se permiten números enteros o positivos");
        }

        private void txtH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) { }
            else
            {
                solonumeros(e);
            }
        }

        private void txtLim1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 || e.KeyChar == 46) { }
            else
            {
                solonumeros(e);
            }
        }
        #endregion
    }
}

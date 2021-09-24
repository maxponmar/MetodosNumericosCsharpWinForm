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
    public partial class formFourier : Form
    {
        private CDatosFourier fourier = new CDatosFourier();
        private bool hayTabla = false;
        private int N = 0, n = 0;
        private double[,] tFt;
        private double tao, deltaT, W;

        public formFourier()
        {
            InitializeComponent();
        }

        private void btnCrearTabla_Click(object sender, EventArgs e)
        {           
            if (hayTabla == true)
            {
                DialogResult resultado = MessageBox.Show("Ya existe una tabla de datos, desdeas eliminarla y crear una nueva?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    BorrarDatos(pnlDatos);
                    fourier.CrearTablaDatos(txtN, pnlTabla, lblDatos1, lblIndice, lblFt, lblT);
                    hayTabla = true;
                    N = Convert.ToInt32(txtN.Text);
                }
                else
                    hayTabla = true; 
            }
            else 
            {
                fourier.CrearTablaDatos(txtN, pnlTabla, lblDatos1, lblIndice, lblFt, lblT);
                hayTabla = true;
                N = Convert.ToInt32(txtN.Text);
            }        
        }

        private void BorrarDatos(Panel pnlDatos)
        {
            pnlTabla.Controls.Clear();
            lblDatos1.Visible = false; lblIndice.Visible = false; lblFt.Visible = false; lblT.Visible = false;
            hayTabla = false;
            N = 0;
        }
       
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarDatos(pnlDatos);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtW.Text))
            {
                MessageBox.Show("Se necesita un valor para w, por defecto es 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                W = 1;
            }
            else
            {
                W = Convert.ToDouble(txtW.Text);
            }       
            if (N == 0)
            {
                MessageBox.Show("Aun no hay datos para realizar calculos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {               
                lbxResultados.Items.Clear(); lblN.Text = "N = " + N.ToString();
                if (string.IsNullOrEmpty(txtNumeron.Text))
                {
                    MessageBox.Show("No introduciste el número términos n, por defecto sera 3", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    n = 3; txtNumeron.Text = "3";
                }
                else
                    n = Convert.ToInt32(txtNumeron.Text);

                tFt = new double[2, N];
                fourier.ObtenerDatos(pnlTabla, ref tFt);
                double[] an = new double[n], bn = new double[n];
               
                                              
                deltaT = tFt[0, 1] - tFt[0, 0];
                tao = deltaT * N;
               // lbxResultados.Items.Add(tFt[0, 1]);
                double zx = 0, zxcos = 0, zxsen = 0, a0;

                // SUMATORIA X
                for (int i = 0; i < N; i++)
                {
                    zx += tFt[1, i];
                }
                a0 = (2.0 / N) * zx;
                // SUMATORIAS XCOS Y XSEN
                for (int i = 0; i < n; i++)
                {                    
                    for (int j = 0; j < N; j++)
                    {                      
                        zxcos += tFt[1, j] * Math.Cos((2.0 * Math.PI * i * tFt[0, j]) / tao);
                        zxsen += tFt[1, j] * Math.Sin((2.0 * Math.PI * i * tFt[0, j]) / tao);
                        
                    }
                    an[i] = (2.0 / N) * zxcos;
                    bn[i] = (2.0 / N) * zxsen;
                    zxcos = 0;zxsen = 0;
                }
                
                lbxResultados.Items.Add((Convert.ToDecimal(a0/2)).ToString());
                for (int i = 1; i < n; i++)
                {
                    lbxResultados.Items.Add(string.Format("1*({0}*cos({1}*{2}*x)) + 1*({3}*sin({1}*{2}*x))", Convert.ToDecimal(an[i]), Convert.ToDecimal(W),i, Convert.ToDecimal(bn[i]) ));
                }              
            }           
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            CSeguridadGraf miGraf = new CSeguridadGraf();
            if (rbtnSi.Checked==true)
            {
                miGraf.SeguridadGrafica5(lbxResultados, tFt, N, true);
            }
            else
            {
                miGraf.SeguridadGrafica5(lbxResultados, tFt, N, false);
            }                            
        }
        #region Solonumeros
        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumerosEntPos(e);
        }

        private void btnWn_Click(object sender, EventArgs e)
        {
            tFt = new double[2, N];
            fourier.ObtenerDatos(pnlTabla, ref tFt);
            deltaT = tFt[0, 1] - tFt[0, 0];
            tao = deltaT * N;
            N = Convert.ToInt32(txtN.Text);
            double Wn = 2 * Math.PI / tao;
            txtW.Text = Wn.ToString();
        }

        public static void solonumerosEntPos(KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar);
            if (!char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo se permiten números enteros positivos");
        }

        private void txtW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 || e.KeyChar == 46) { }
            else
            {
                if (e.KeyChar == 45 || e.KeyChar == 46) { }
                else
                {
                    solonumerosNegDec(e);
                }
            }
        }

        public static void solonumerosNegDec(KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar);
            if (!char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo se permiten números enteros, decimales, positivos o negativos");
        }
        #endregion
    }
}

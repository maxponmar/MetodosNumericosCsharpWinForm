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
    public partial class TabularFuncion : Form
    {
        private CTabular MiTabla = new CTabular();

        public TabularFuncion()
        {
            InitializeComponent();
        }

        public void establecerFuncion(string pFuncion)
        {
            txtFuncion.Text = pFuncion;
        }

        private void cbxTabla_CheckedChanged(object sender, EventArgs e)
        {
            MiTabla.establecerRango(cbxTabla, txtV1, txtV2);
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            MiTabla.MuestraTabla(rtxTabla, txtX1, txtX2, txtFuncion, txtV1, txtV2, lblFuncion, txtPaso);
        }

        #region solo numeros
        private void solonumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar);
            if (!char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo se permiten números");
        }

        // Solo permite teclear números enteros, positivos o negativos
        private void txtV1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45) { }
            else
            {
                solonumeros(e);
            }
        }

        // Solo permite teclear números, ya sean decimales, enteros, positivos o negativos
        private void txtPaso_KeyPress(object sender, KeyPressEventArgs e)
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

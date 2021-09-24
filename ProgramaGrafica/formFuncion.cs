using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace raizesMN
{
    public partial class formFuncion : Form
    {
        private CColorFuncion fc;
        public CColorFuncion Fc { get{ return fc; }}
       
        public formFuncion(CColorFuncion fc)
        {
            InitializeComponent();
            this.fc = fc;
            txtFuncion.Text = fc.Funcion;
            panelColor.BackColor = fc.Color;
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialogFuncion.ShowDialog();
            panelColor.BackColor = colorDialogFuncion.Color;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            fc.Funcion = txtFuncion.Text;
            fc.Color = panelColor.BackColor;

            this.DialogResult = DialogResult.OK;
            this.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Visible = false;
        }
    }
}

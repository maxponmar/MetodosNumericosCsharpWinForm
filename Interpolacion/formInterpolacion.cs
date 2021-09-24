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
    public partial class formInterpolacion : Form
    {
        private int[] cont = new int[5]; // 0=AFS  1=ACMC  2=DDFN  3=LAGRANGE  4=SPLINES --------------- CONT = 0 No hay tabla, CONT = 1 Ya hay tabla 
        private int[] n = new int[5];
        private int[] temp = new int[2];
        private double[] dato { get; set; }

        public formInterpolacion()
        {
            InitializeComponent();
        }

        private void btnCrearTabla_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == "btnCrearTablaAFS")
            {
                temp = CTablaDatos.ImprimirTabla(cont[0], txtNAFS, lblTablaAFS, lblXAFS, lblYAFS, panelDatosAFS);
                cont[0] = temp[0]; n[0] = temp[1];
            }
            if (((Button)sender).Name == "btnCrearTablaACMC")
            {
                temp = CTablaDatos.ImprimirTabla(cont[1], txtNACMC, lblTablaACMC, lblXACMC, lblYACMC, panelDatosACMC);
                cont[1] = temp[0]; n[1] = temp[1];
            }
            if (((Button)sender).Name == "btnCrearTablaDDFN")
            {
                temp = CTablaDatos.ImprimirTabla(cont[2], txtNDDFN, lblTablaDDFN, lblXDDFN, lblYDDFN, panelDatosDDFN);
                cont[2] = temp[0]; n[2] = temp[1];
            }
            if (((Button)sender).Name == "btnCrearTablaL")
            {
                temp = CTablaDatos.ImprimirTabla(cont[3], txtNL, lblTablaL, lblXL, lblYL, panelDatosL);
                cont[3] = temp[0]; n[3] = temp[1];
            }
            if (((Button)sender).Name == "btnCrearTablaS")
            {
                temp = CTablaDatos.ImprimirTabla(cont[4], txtNS, lblTablaS, lblXS, lblYS, panelDatosS);
                cont[4] = temp[0]; n[4] = temp[1];
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == "btnBorrarAFS")
            {
                CTablaDatos.BorrarTabla(panelDatosAFS, lblTablaAFS, lblXAFS, lblYAFS, txtResultadoAFS, txtNAFS);
                cont[0] = 0;
            }
            if (((Button)sender).Name == "btnBorrarACMC")
            {
                CTablaDatos.BorrarTabla(panelDatosACMC, lblTablaACMC, lblXACMC, lblYACMC, txtResultadoACMC, txtNACMC);txtDatosfACMC.Clear();
                cont[1] = 0;
            }
            if (((Button)sender).Name == "btnBorrarDDFN")
            {
                CTablaDatos.BorrarTabla(panelDatosDDFN, lblTablaDDFN, lblXDDFN, lblYDDFN, txtResultadoDDFN, txtNDDFN);
                cont[2] = 0;
            }
            if (((Button)sender).Name == "btnBorrarL")
            {
                CTablaDatos.BorrarTabla(panelDatosL, lblTablaL, lblXL, lblYL, txtResultadoL, txtNL);
                cont[3] = 0;
            }
            if (((Button)sender).Name == "btnBorrarS")
            {
                CTablaDatos.BorrarTabla(panelDatosS, lblTablaS, lblXS, lblYS, lbxResultadoS, txtNS);
                cont[4] = 0;
            }
        }    

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == "btnCalcularAFS")            
                CCalcular2.CalcularAFS(n[0], cont[0], txtResultadoAFS, cbxMetodosAFS, panelDatosAFS);

            if (((Button)sender).Name == "btnCalcularACMC")
            { txtDatosfACMC.Clear(); CCalcular2.CalcularACMC(n[1], cont[1], txtResultadoACMC, cbxMetodosACMC, panelDatosACMC, txtDatosfACMC); }
            
            if (((Button)sender).Name == "btnCalcularDDFN")           
                CCalcular2.CalcularDDFN(n[2], cont[2], txtResultadoDDFN, panelDatosDDFN);
            
            if (((Button)sender).Name == "btnCalcularL")
                CCalcular2.CalcularL(n[3], cont[3], txtResultadoL, panelDatosL);

            if (((Button)sender).Name == "btnCalcularS")            
                CCalcular2.CalcularS(n[4], cont[4], cbxMetodosS, panelDatosS, lbxResultadoS);          
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == "btnEvaluarAFS")
            {
                CCalcular2.EvaluarDato1(txtResultadoAFS, Convert.ToDouble(txtDatoAFS.Text), txtResEvAFS);
            }
            if (((Button)sender).Name == "btnEvaluarACMC")
            {
                CCalcular2.EvaluarDato1(txtResultadoACMC, Convert.ToDouble(txtDatoACMC.Text), txtResEvACMC);
            }
            if (((Button)sender).Name == "btnEvaluarDDFN")
            {
                CCalcular2.EvaluarDato1(txtResultadoDDFN, Convert.ToDouble(txtDatoDDFN.Text), txtResEvDDFN);
            }
            if (((Button)sender).Name == "btnEvaluarL")
            {
                CCalcular2.EvaluarDato1(txtResultadoL, Convert.ToDouble(txtDatoL.Text), txtResEvL);
            }
            if (((Button)sender).Name == "btnEvaluarS")
            {
                CCalcular2.EvaluarDato2(lbxResultadoS, Convert.ToDouble(txtDatoS.Text), txtResEvS, Convert.ToInt32(txtNS.Text), panelDatosS);
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            CSeguridadGraf mostrarGrafica = new CSeguridadGraf();
            if (((Button)sender).Name == "btnGraficarAFS")          
                mostrarGrafica.SeguridadGrafica1(txtResultadoAFS.Text, CCalcular2.XY, Convert.ToInt32(txtNAFS.Text), txtDatoAFS, txtResEvAFS);                            
            
            if (((Button)sender).Name == "btnGraficarACMC")            
                mostrarGrafica.SeguridadGrafica1(txtResultadoACMC.Text, CCalcular2.XY, Convert.ToInt32(txtNACMC.Text), txtDatoACMC, txtResEvACMC);
            
            if (((Button)sender).Name == "btnGraficarDDFN")           
                mostrarGrafica.SeguridadGrafica1(txtResultadoDDFN.Text, CCalcular2.XY, Convert.ToInt32(txtNDDFN.Text), txtDatoDDFN, txtResEvDDFN);
            
            if (((Button)sender).Name == "btnGraficarL")           
                mostrarGrafica.SeguridadGrafica1(txtResultadoL.Text, CCalcular2.XY, Convert.ToInt32(txtNL.Text), txtDatoL, txtResEvL);
            
            if (((Button)sender).Name == "btnGraficarS")         
                mostrarGrafica.SeguridadGrafica2(lbxResultadoS, CCalcular2.XY, Convert.ToInt32(txtNS.Text), txtDatoS, txtResEvS);        
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name == "btnAyudaAFS")
            {
                MessageBox.Show("1.- Selecciona el método que creas conveniente, líneal, cuadrático o cúbico. \r\n" +
                    "2.- Para instroducir los datos crea una tabla introduciendo el número de datos que vas a interpolar en el textbox. \r\n" +
                    "3.- Se creará una tabla en el lado derecho, introduce los datos. \r\n" +
                    "4.- Asegurate de tener la cantidad de datos suficiendo para el método que vas a utilizar. \r\n" +
                    "5.- Presiona calcular, aparecerá la funcion en la parte inferior." +
                    "6.- Introduce el valor que deseas interpolar y presiona evaluar." +
                    "7.- Puedes graficar el resultado pulsando el botón graficar.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }     
            if (((Button)sender).Name == "btnAyudaACMC")
            {
                MessageBox.Show("1.- Selecciona el método que creas conveniente, líneal o cuadrático. \r\n" +
                    "2.- Para instroducir los datos crea una tabla introduciendo el número de datos que vas a interpolar en el textbox. \r\n" +
                    "3.- Se creará una tabla en el lado derecho, introduce los datos. \r\n" +
                    "4.- Presiona calcular, aparecerá la funcion en la parte inferior." +
                    "5.- Introduce el valor que deseas interpolar y presiona evaluar." +
                    "6.- Puedes graficar el resultado pulsando el botón graficar.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (((Button)sender).Name == "btnAyudaDDFN" || ((Button)sender).Name == "btnAyudaL")
            {
                MessageBox.Show("1.- Para instroducir los datos crea una tabla introduciendo el número de datos que vas a interpolar en el textbox. \r\n" +
                    "2.- Se creará una tabla en el lado derecho, introduce los datos. \r\n" +
                    "3.- Presiona calcular, aparecerá la funcion en la parte inferior." +
                    "4.- Introduce el valor que deseas interpolar y presiona evaluar." +
                    "5.- Puedes graficar el resultado pulsando el botón graficar.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (((Button)sender).Name == "btnAyudaS")
            {
                MessageBox.Show("1.- Selecciona el método que creas conveniente, grado 1, grado 2 o splines cúbicos. \r\n" +
                    "2.- Para instroducir los datos crea una tabla introduciendo el número de datos que vas a interpolar en el textbox. \r\n" +
                    "3.- Se creará una tabla en el lado derecho, introduce los datos. \r\n" +
                    "4.- Presiona calcular, aparecerá la funcion en la parte inferior." +
                    "5.- Introduce el valor que deseas interpolar y presiona evaluar." +
                    "6.- Puedes graficar el resultado pulsando el botón graficar.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("Ten en cuenta que no se pueden repetir datos, por ejemplo, si X vale 2 y Y vale 10, no puede haber otra X igual a 2, ya que no puede tener 2 valores al mismo tiempo. \r\n" +
                "Y recuerda acomodar los valores de x de menor a mayor, x1 < x2 < x2 < .... < xn", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxMetodosAFS.SelectedIndex)
            {
                case 0:
                    // Lineal
                    MessageBox.Show("Líneal solo usa los 2 primeros datos para interpolar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    // Cuadratica
                    MessageBox.Show("Cuadrática solo usa los 3 primeros datos para interpolar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    // Cubica
                    MessageBox.Show("Cúbica solo usa los 4 primeros datos para interpolar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        
        public void RefrescarVariables(int indice, int pN, int pCont)
        {
            cont[indice] = pCont;
            n[indice] = pN;
            //matrices.Insert(indice, new double[pN, pN + 1]);
        }

        #region Solo números enteros
        public static void solonumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar);
            if (!char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo se permiten números");
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void txtDato_KeyPress(object sender, KeyPressEventArgs e)
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

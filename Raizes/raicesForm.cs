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
    public partial class formRaizes : Form
    {
        private CTabular MiTabla = new CTabular();
        private CCalcular Calculador = new CCalcular();

        public formRaizes()
        {
            InitializeComponent();
        }

        // Boton de ayuda
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string mensajeAyuda = "", encabezadoAyuda = "";
            if (((Button)sender).Name == "btnAyudaBS")
            {
                mensajeAyuda = "Bisecciones sucesivas - Método cerrado \r\n" +
                    "1.- Introduce la función en el formato correcto \r\n" +
                "2.- Usa tabular para encontrar el rango donde se encuentra la raíz o introducelo tu mism@ en x1 y x2 \r\n" +
                "3.- Establece el número de iteraciones a ejecutar (Entre mas grande mas preciso pero tardará mas) \r\n" +
                "4.- Presiona calcular para iniciar el proceso";
                encabezadoAyuda = "Cómo usar Bisecciones sucesivas";
            }
            if (((Button)sender).Name == "btnAyudaNR")
            {
                mensajeAyuda = "Newton-Raphson - Método abierto \r\n" +
                    "Es recomendable poner un valor inicial cercano a la raíz \n" +
                "1.- Escribe la función y su derivada en el formato correcto \r\n" +
                "2.- Indica x0 inicial y el número de iteraciones \r\n" +
                "3.- Presiona calcular \r\n" +
                "Si no se te es posible introducir la derivada, se puede usar una diferenciación númerica, pero al hacer esto, en realidad se esta usan el método de la secante modificado \r\n" +
                "Para ello desactiva Derivada e introduce el tamaño de h, entre mas pequeño sera mejor, pero ten en cuenta que puede suceder una divergencia";
                encabezadoAyuda = "Cómo usar Newton-Raphson";               
            }
            if (((Button)sender).Name == "btnAyudaFP")
            {
                mensajeAyuda = "Falsa posición - Método cerrado \r\n" +
                    "1.- Introduce la función en el formato correcto \r\n" +
                "2.- Usa tabular para encontrar el rango donde se encuentra la raíz o introducelo tu mism@ en x1 y x2 \r\n" +
                "3.- Establece el número de iteraciones a ejecutar (Entre mas grande mas preciso pero tardará mas) \r\n" +
                "4.- Presiona calcular para iniciar el proceso";

                encabezadoAyuda = "Cómo usar Falpsa posición";
            }
            if (((Button)sender).Name == "btnAyudaPF")
            {
                mensajeAyuda = "Punto fijo - Método abierto \r\n" +
                    "1.- Escribe la función original en f(x) \r\n" +
                    "2.- Despeja x e intrudce el resultado en g(x), escribe su derivada en g´(x) o calculala con botón derivar \r\n" +
                    "3.- Establece el número de iteraciones \r\n" +
                    "4.- Puedes usar cualquier punto Xm para comenzar, pero puedes introducir x1 y x2, al dar click en el cuadro de texto xm se calculara la media de los dos puntos \r\n" +
                    "5.- Presiona calcular \r\n" +
                    "Nota: Es necesario introducir la derivada para saber si el metodo va a funcionar o no, si no tienes la derivada en ese momento se puede hacer uso de diferenciación númerica, solo desactiva derivada e introduce h \r\n" +
                    "entre mas se aproxime a 0 mejor, pero ten encuneta que un número demasiado pequeñe puede generar problemas";
                encabezadoAyuda = "Cómo usar Punto fijo";
            }
            if (((Button)sender).Name == "btnAyudaS")
            {
                mensajeAyuda = "Secante - Método abierto \r\n" +
                    "1.- Introduce la función en el formato correcto \r\n" +
                "2.- Usa tabular para encontrar el rango donde se encuentra la raíz o introducelo tu mism@ en x1 y x2 \r\n" +
                "3.- Establece el número de iteraciones a ejecutar (Entre mas grande mas preciso pero tardará mas) \r\n" +
                "4.- Presiona calcular para iniciar el proceso \r\n" +
                "Nota: Aunque el método de la secante es un método abierto, en este programa se usa un rango para mejorar el método, recuerdo que entre mejor encierron x1 y x2 a la raíz, abrá mayor seguridad en el método";

                encabezadoAyuda = "Cómo usar Secante";
            }
            if (((Button)sender).Name == "btnAyudaB")
            {
                mensajeAyuda = "Método de Brent - Método híbrido \r\n" +
                    "1.- Introduce la función en el formato correcto \r\n" +
                "2.- Usa tabular para encontrar el rango donde se encuentra la raíz o introducelo tu mism@ en x1 y x2 \r\n" +
                "3.- Establece el número de iteraciones máximas a ejecutar (En caso de no llegar a la tolerancia, el cálculo se detiene hasta ese número de ciclos) \r\n" +
                "4.- Presiona calcular para iniciar el proceso \r\n" +
                "Nota: El métodos de Brent es una combinación entre métodos abiertos y cerrados, el método se detiene hasta llegar a una tolerancia de 1e-6 o hasta llegar al número maximo de ciclos";

                encabezadoAyuda = "Cómo usar Método de Brent";
            }
            if (((Button)sender).Name == "btnAyudaM")
            {
                mensajeAyuda = "Método de Muller - Método para polinomios \r\n" +
                    "1.- Introduce la función en el formato correcto - OJO, DEBE DE SER UN POLINOMIO \r\n" +
                "2.- Puedes usar tabular para elejir un valor aproximado xr a la raíz  \r\n" +
                "3.- Establece el número de iteraciones máximas a ejecutar (En caso de no llega�!a la to|urancia( el cänculo se detiene hasta qse!número d� ciclos) \r|n" +-
       $    `$  "4.- Antroduce h, para generar otros 2 runts am rededOr de!|r distanciados a ula!longitud hb +
           !    "5.- Presionq calcunar para iniciaR el procgso \r\n* k
"          "  & "Nota: El médodo de Ouller es utilhzado para e~coftrar las raízes reahes d� un polmnkmiob;

            (   encebezadoAyuda = "Cómo usar Método de Muller";
            }        "   in (((Button)sen`er).Name == "btlAyudaBaiz")
            {           0   $mensajeAyuea � "Mëtodo de�BeIr3u/w - MÉtodo$qar` polinomios \r\n"(+
          (    �    21.- Introduce el(grado del polinomio \r\n" +
         0      "2. Introdtce los coeficientec de manera ascendente en El rklinomio en lms auadzos de0texto  \rTn" *
        `  $    "3.- Presigna calCular \r\n" +         (  "8  "4.� Puedes graficar al qolinomim pulsando Graficar @olinomio" +
                "Nota:�El méto$o de Ba�rrtow es utili{ado paba enco~trar las raízes reales e imaginarias de un polinomio";

                encabezadoAyuda = "Cómo usar Método de Bairstow";
            }
            CAyuda.mostrarMensaje(mensajeAyuda, encabezadoAyuda);
            
        }

        // Boton imprimir tabla
        private void btnTabla_Click(object sender, EventArgs e)
        {
            TabularFuncion AbrirTabla = new TabularFuncion();

            if (((Button)sender).Name == "btnTablaBS")
            {
                AbrirTabla.establecerFuncion(txtFuncionBS.Text);               
                AbrirTabla.Show();
            }
            if (((Button)sender).Name == "btnTablaFP")
            {
                AbrirTabla.establecerFuncion(txtFuncionFP.Text);
                AbrirTabla.Show();
            }
            if (((Button)sender).Name == "btnTablaPF")
            {
                AbrirTabla.establecerFuncion(txtFuncionPF.Text);
                AbrirTabla.Show();

            }
            if (((Button)sender).Name == "btnTablaS")
            {
                AbrirTabla.establecerFuncion(txtFuncionS.Text);
                AbrirTabla.Show();
            }
            if (((Button)sender).Name == "btnTablaB")
            {
                AbrirTabla.establecerFuncion(txtFuncionB.Text);
                AbrirTabla.Show();
            }
            if (((Button)sender).Name == "btnTablaM")
            {
                AbrirTabla.establecerFuncion(txtFuncionM.Text);
                AbrirTabla.Show();
            }
        }

        // Boton calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int metodo = 0;
            // 1.- Bisecciones sucesivas 3.- Falsa posicion 5.- Secante 6.- Brent 7.-Muller 8.-Bairstow
            
            if (((Button)sender).Name == "btnCalcularBS")
            {  
                metodo = 1;
                Calculador.calcularBTN(txtFuncionBS, txtResultadoBS, txtIteracionesBS, txtX1BS, txtX2BS, lblFuncionBS, metodo);
            }
            if (((Button)sender).Name == "btnCalcularNR")
            {
                Calculador.calcularBTN(txtFuncionNR, txtResultadoNR, txtIteracionesNR, txtX0NR, txtDerivadaNR,lblFuncionNR,txtHNR);
            }
            if (((Button)sender).Name == "btnCalcularFP")
            {
                metodo = 3;
                Calculador.calcularBTN(txtFuncionFP, txtResultadoFP, txtIteracionesFP, txtX1FP, txtX2FP, lblFuncionFP, metodo);
            }
            if (((Button)sender).Name == "btnCalcularPF")
            {
                Calculador.calcularBTN(txtFuncionPF, txtGx, txtDerivadaPF, txtResultadoPF, txtIteracionesPF, txtXmPF, lblFuncionPF,txtHPF);
            }
            if (((Button)sender).Name == "btnCalcularS")
            {
                metodo = 5;
                Calculador.calcularBTN(txtFuncionS, txtResultadoS, txtIteracionesS, txtX1S, txtX2S, lblFuncionS,metodo);
            }
            if (((Button)sender).Name == "btnCalcularB")
            {
                metodo = 6;
                Calculador.calcularBTN(txtFuncionB, txtResultadoB, txtIteracionesB, txtX1B, txtX2B, lblFuncionB, metodo);
            }
            if (((Button)sender).Name == "btnCalcularM")
            {
                metodo = 7;
                Calculador.calcularBTN(txtFuncionM, txtResultadoM, txtIteracionesM, txtX1M, txtX2M, lblFuncionM, metodo);
            }
            if (((Button)sender).Name == "btnCalcularBair")
            {
                lbxResultadoBair.Items.Clear();
                Calculador.calcularBTN(txtN, panelPolinomio, lbxResultadoBair,lblPoli);
            }
        }

        // Imprimir la derivada de la función
        private void btnDerivar_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Name== "btnDerivarNR")
            {
                if (txtDerivadaNR.Enabled == false)
                { txtDerivadaNR.Enabled = true; lblActivarDNR.Text = "Desactivar:"; txtHNR.Enabled = false; }
                else
                { txtDerivadaNR.Enabled = false; lblActivarDNR.Text = "Activar:"; txtHNR.Enabled = true; }
            }
            if (((Button)sender).Name == "btnDerivarPF")
            {
                if (txtDerivadaPF.Enabled == false)
                { txtDerivadaPF.Enabled = true; lblDerivarPF.Text = "Desactivar:"; txtHPF.Enabled = false; }
                else
                { txtDerivadaPF.Enabled = false; lblDerivarPF.Text = "Activar:"; txtHPF.Enabled = true; }
            }
        }

        // Imprimir gráfica
        private void btnGrafica_Click(object sender, EventArgs e)
        {
            CSeguridadGraf mostrarGrafica = new CSeguridadGraf();
            string fx, gx, dx;
            if (((Button)sender).Name == "btnGraficaBS")
            {
                fx = txtFuncionBS.Text;
                mostrarGrafica.SeguridadGrafica0(fx, lblFuncionBS);
            }
            if (((Button)sender).Name == "btnGraficaNR")
            {
                fx = txtFuncionNR.Text;
                if (txtDerivadaNR.Enabled == true)
                {
                    dx = txtDerivadaNR.Text;
                    mostrarGrafica.SeguridadGrafica0(fx, dx, lblFuncionNR);
                }
                else
                    mostrarGrafica.SeguridadGrafica0(fx, lblFuncionNR);                   
            }
            if (((Button)sender).Name == "btnGraficaFP")
            {
                fx = txtFuncionFP.Text;
                mostrarGrafica.SeguridadGrafica0(fx, lblFuncionFP);
            }
            if (((Button)sender).Name == "btnGraficaPF")
            {
                fx = txtFuncionPF.Text; gx = txtGx.Text;
                if (txtDerivadaPF.Enabled == true)
                {
                    dx = txtDerivadaPF.Text;
                    mostrarGrafica.SeguridadGrafica0(fx, gx, dx, lblFuncionPF);
                }
                else
                    mostrarGrafica.SeguridadGrafica0(fx, gx, lblFuncionNR);             
            }
            if (((Button)sender).Name == "btnGraficaS")
            {
                fx = txtFuncionS.Text;
                mostrarGrafica.SeguridadGrafica0(fx, lblFuncionS);
            }
            if (((Button)sender).Name == "btnGraficaB")
            {
                fx = txtFuncionB.Text;
                mostrarGrafica.SeguridadGrafica0(fx, lblFuncionB);
            }
            if (((Button)sender).Name == "btnGraficaM")
            {
                fx = txtFuncionM.Text;
                mostrarGrafica.SeguridadGrafica0(fx, lblFuncionM);
            }
            if (((Button)sender).Name == "btnGraficaBair")
            {
                lblPoli.Text = CPolinomio.obtenerPolinomio(txtN, panelPolinomio);
                fx = lblPoli.Text;
                mostrarGrafica.SeguridadGrafica0(fx, lblFuncionM);
            }
        }

        // Solo permitir teclear números (0-9, -, .)
        #region solo numeros
        private void solonumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar);
            if (!char.IsNumber(e.KeyChar) & !Char.IsControl(e.KeyChar))
                MessageBox.Show("No permitido");
        }

        // Solo permite teclear números enteros, positivos o negativos
        private void txtV1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45) { }
            else
            {
                solonumeros(e);
            }
        }
  
        // Solo permite teclear números enteros positivos
        private void txtIteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        // Solo permite teclear números, ya sean decimales, enteros, positivos o negativos
        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 || e.KeyChar == 46) { }
            else
            {
                solonumeros(e);
            }
        }

        // Solo permite numeros enteros o decimales positivos (para h)
        private void txtHNR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) { }
            else
            {
                solonumeros(e);
            }
        }

        #endregion

        //Calcular valor medio
        private void txtXmPF_Click(object sender, EventArgs e)
        {
            
            try
            {
                double xm;
                double x1 = Convert.ToDouble(txtX1PF.Text);
                double x2 = Convert.ToDouble(txtX2PF.Text);
                xm = (x1 + x2) / 2;
                txtXmPF.Text = xm.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Aun no hay x1 y/0 x2, introducelos y haz click en el cuadro de texto Xm para obtener la media \r" +
                    "Si quieres hacer uso de esto, ignoralo e introduce xm apropiado");
            }
        }

        private int cont = 0; // 0.-No existe polinomio 1.-ya existe polinomio
        // Para método de Bairstow
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int n=0; 
            if (cont == 1)
            {
                DialogResult resultado = MessageBox.Show("Ya existe un polinomio, deseas eliminarlo y crear otro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    txtN.Enabled = true; borrarDatos(); cont = 0; lbxResultadoBair.Items.Clear(); lblPoli.Text="";
                }
            }
            else
            {
                cont = 1;
                MessageBox.Show("Introduce los coeficientes del polinomio en orden ascendente en los cuadros de texto");            
                n = Convert.ToInt32(txtN.Text);
                if (n<0)
                {
                    MessageBox.Show("El grado de polinomio debe ser mayor o igual a 0");
                    n = 0;txtN.Text = "0";
                }               
                lblPolinomio.Visible = true;
                CPolinomio.CrearTextBoxs(n, panelPolinomio);
                
            }            
        }

        private void borrarDatos()
        {
            cont = 0;
            panelPolinomio.Controls.Clear();
            lblPolinomio.Visible = false;
            lbxResultadoBair.Items.Clear();
            lblPoli.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtN.Enabled = true; borrarDatos(); cont = 0;
        }
    }
}

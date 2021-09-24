using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace raizesMN
{
    public class CSeguridadGraf
    {
        private MathParser miTest = new MathParser();
        private formGrafica miGrafica = new formGrafica();
        private double[] dato = new double[2];

        public CSeguridadGraf() 
        {

        }

        public void SeguridadGrafica0(string fx, Label lblFuncion) // raices
        {
            if (string.IsNullOrEmpty(fx))
            {
                MessageBox.Show("Introduce la función"); lblFuncion.Visible = false;
            }
            else
            {
                miGrafica.Indice = 0;
                try
                {
                    miTest.ProgrammaticallyParse("let x = 1");
                    miTest.Parse(fx);
                    miGrafica.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("La función no esta en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFuncion.Visible = false;
                }

                miGrafica.btnAñadir_Click(fx, Color.Red);
               
            }
        }

        public void SeguridadGrafica0(string fx, string dx,Label lblFuncion)// raices
        {
            if (string.IsNullOrEmpty(fx)|| string.IsNullOrEmpty(dx))
            {
                MessageBox.Show("Introduce la función y/o derivada"); lblFuncion.Visible = false;
            }
            else
            {
                miGrafica.Indice = 0;
                try
                {                 
                    miTest.ProgrammaticallyParse("let x = 1");
                    miTest.Parse(fx); miTest.Parse(dx);
                    miGrafica.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("La función y/o derivada no estan en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFuncion.Visible = false;
                }
                miGrafica.btnAñadir_Click(fx, Color.Red); miGrafica.btnAñadir_Click(dx, Color.Black);
            }
        }

        public void SeguridadGrafica0(string fx, string gx,string dx, Label lblFuncion)// raices
        {
            if (string.IsNullOrEmpty(fx) || string.IsNullOrEmpty(gx) || string.IsNullOrEmpty(dx))
            {
                MessageBox.Show("Falta una función y/o derivada"); lblFuncion.Visible = false;
            }
            else
            {
                miGrafica.Indice = 0;
                try
                {
                    miTest.ProgrammaticallyParse("let x = 1");
                    miTest.Parse(fx); miTest.Parse(dx); miTest.Parse(gx);
                    miGrafica.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Las funciónes no estan en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFuncion.Visible = false;
                }
                miGrafica.btnAñadir_Click(fx, Color.Red); miGrafica.btnAñadir_Click(dx, Color.Black); miGrafica.btnAñadir_Click(gx, Color.Blue);
            }
        }

        public void SeguridadGrafica1(string fx, double[,] xy, int n, TextBox txtDato, TextBox txtResEv) // interpolacion
        {
            if (string.IsNullOrEmpty(fx))
            {
                MessageBox.Show("No existe una función");
            }
            else
            {
                dato[0] = Convert.ToDouble(txtDato.Text); dato[1] = Convert.ToDouble(txtResEv.Text);
                miGrafica.Indice = 1; miGrafica.xy = xy; miGrafica.n = n;  miGrafica.datoXY = dato;
                try
                {
                    miTest.ProgrammaticallyParse("let x = 1");
                    miTest.Parse(fx);
                    miGrafica.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("La función no esta en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                miGrafica.btnAñadir_Click(fx, Color.Red);
            }
        }

        public void SeguridadGrafica2(ListBox lbxResultados, double[,] xy, int n, TextBox txtDato, TextBox txtResEv) // Interpolacion splines
        {
            int nsplines = n - 1, posicion = 0;
            string[] splines = new string[nsplines];
            string splin;
            if (lbxResultados.Items.Count == 0)
            {
                MessageBox.Show("Aun no hay un resultado");
            }
            else
            {
                dato[0] = Convert.ToDouble(txtDato.Text); dato[1] = Convert.ToDouble(txtResEv.Text);
                miGrafica.Indice = 2; miGrafica.xy = xy; miGrafica.n = n; miGrafica.datoXY = dato;
                // Obetener splines
                for (int i = 0; i < nsplines; i++)
                {
                    splin = (string)lbxResultados.Items[i];
                    posicion = splin.IndexOf(","); 
                    splines[i]= splin.Substring(0,posicion);
                }

                try
                {
                    for (int i = 0; i < nsplines; i++)
                    {
                        miTest.ProgrammaticallyParse("let x = 1");
                        miTest.Parse(splines[i]);
                    }
                    miGrafica.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("La función no esta en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                miGrafica.btnAñadir_Click(splines, Color.Red, nsplines);
            }
        }

        public void SeguradadGrafica3(string fx, double a, double b) //integracion
        {
            if (string.IsNullOrEmpty(fx))
            {
                MessageBox.Show("Aun no existe una función"); 
            }
            else
            {
                miGrafica.Indice = 3; miGrafica.a = a; miGrafica.b = b;
                try
                {
                    miTest.ProgrammaticallyParse("let x = 1");
                    miTest.Parse(fx);
                    miGrafica.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("La función no esta en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }
                miGrafica.btnAñadir_Click(fx, Color.Red);
            }
        }

        public void SeguridadGrafica4(string fx, double x, double fxx)
        {
            if (string.IsNullOrEmpty(fx))
            {
                MessageBox.Show("Aun no existe una función");
            }
            else
            {
                miGrafica.Indice = 4; miGrafica.a = x; miGrafica.b = fxx;
                try
                {
                    miTest.ProgrammaticallyParse("let x = 1");
                    miTest.Parse(fx);
                    miGrafica.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("La función no esta en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                miGrafica.btnAñadir_Click(fx, Color.Red);
            }
        }

        public void SeguridadGrafica5(ListBox lbXResultados, double[,] xy, int N,bool armonicos)// Fourier
        {
            string SuperFunc = "";
            miGrafica.Indice = 5; miGrafica.xy = xy;miGrafica.n = N;
            miGrafica.Show();

            
            for (int i = 0; i < lbXResultados.Items.Count; i++)
            {
                if(i==0)
                    SuperFunc += lbXResultados.Items[i].ToString();
                else
                    SuperFunc += "+ 1*("+lbXResultados.Items[i].ToString()+")";

                if(armonicos==true)
                    miGrafica.btnAñadir_Click(lbXResultados.Items[i].ToString(), Color.Red);

            }
            miGrafica.btnAñadir_Click(SuperFunc, Color.Green);
        }
    }
}

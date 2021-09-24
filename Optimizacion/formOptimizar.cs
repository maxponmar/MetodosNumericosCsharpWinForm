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
    public partial class formOptimizar : Form
    {
        private MathParser miParser = new MathParser();
        private double px, pfx;
        public formOptimizar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cbxMetodo.SelectedIndex==-1)
            {
                MessageBox.Show("Selecciona un metodo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(txtFuncion.Text))
                {
                    MessageBox.Show("Introduce la funcion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtResultado.Clear();
                    string func = txtFuncion.Text;
                    double xlow = Convert.ToDouble(txtxlow.Text);
                    double xhigh = Convert.ToDouble(txtxhigh.Text);
                    double es = Convert.ToDouble(txtError.Text);
                    int maxit = Convert.ToInt32(txtMaxIt.Text);
                    switch (cbxMetodo.SelectedIndex)
                    {
                        case 0:
                            secciondorada(func, xlow, xhigh, maxit, es);
                            break;
                        default:
                            brent(func, xlow, xhigh);
                            break;
                    }
                }              
            }
        }

        public void secciondorada(string fx,double xlo,double xhi,int maxit,double es)
        {
            double R = (Math.Sqrt(5) - 1) / 2;
            double xl = xlo;double xu = xhi;
            double d = R * (xu - xl);
            double x1 = xl + d;double x2 = xu - d;
            double f1, f2, xopt, fxx, ea = 0;
            miParser.ProgrammaticallyParse("let x ="+ x1);
            f1 = miParser.Parse(fx);
            miParser.ProgrammaticallyParse("let x =" + x2);
            f2 = miParser.Parse(fx);

            if (f1>f2)
            {
                xopt = x1;
                fxx = f1;              
            }
            else
            {
                xopt = x2;
                fxx = f2;
            }
            for (int i = 0; i < maxit; i++)
            {
                d *= R;
                if (f1>f2)
                {
                    xl = x2;
                    x2 = x1;
                    x1 = xl + d;
                    f2 = f1;
                    miParser.ProgrammaticallyParse("let x =" + x1);
                    f1 = miParser.Parse(fx);
                }
                else
                {
                    xu = x1;
                    x1 = x2;
                    x2 = xu - d;
                    f1 = f2;
                    miParser.ProgrammaticallyParse("let x =" + x2);
                    f2 = miParser.Parse(fx);
                }
                if (f1 > f2)
                {
                    xopt = x1;
                    fxx = f1;
                }
                else
                {
                    xopt = x2;
                    fxx = f2;
                }
                if (xopt != 0)
                {
                    ea = (1 - R) * (Math.Abs(xu - xl) / xopt) * 100;
                }
                miParser.ProgrammaticallyParse("let x =" + xopt);
                fxx = miParser.Parse(fx);             
                if (ea<=es) 
                {
                    txtResultado.AppendText(string.Format("iteracion {0} - f({1}) = {2} \r\n", i + 1, xopt, fxx));
                    px = xopt; pfx = fxx;
                    break;
                }
                txtResultado.AppendText(string.Format("iteracion {0} - f({1}) = {2} \r\n", i + 1, xopt, fxx));
                px = xopt; pfx = fxx;
            }           
        }

        private void brent(string fx, double xl, double xu)
        {
            double tol = 0.000001; double phi = (1 + Math.Sqrt(5)) / 2;double rho = 2 - phi;
            double u = xl + rho * (xu - xl); double v = u; double w = u; double x = u;
            miParser.ProgrammaticallyParse("let x =" + u);
            double fu = miParser.Parse(fx); double fv = fu; double fw = fu; double fxx = fu;
            double xm = 0.5 * (xl + xu); double d = 0; double e = 0;
            bool para = true; double r, p, q, s; int i = 0;
            do
            {
                i++;
                if (Math.Abs(x-xm)<=tol)               
                    para = Math.Abs(e) > tol;

                if (para)
                {
                    r = (x - w) * (fxx - fv); q = (x - v) * (fxx - fw);
                    p = (x - v) * q - (x - w) * r; s = 2 * (q - r);
                    if (s > 0)
                        p = -p;

                    s = Math.Abs(s);
                    para = Math.Abs(p) < Math.Abs(0.5 * s * e) && p > s * (xl - x) && p < s * (xu - x);
                    if (para)
                    {
                        e = d;d = p / s;
                    }
                }
                if (!para)
                {
                    if (x >= xm)
                        e = xl - x;
                    else
                        e = xu - x;

                    d = rho * e;
                }
                u = x + d;
                miParser.ProgrammaticallyParse("let x =" + u);
                fu = miParser.Parse(fx);

                if (fu <= fxx)
                {
                    if (u >= x)
                        xl = x;
                    else
                        xu = x;

                    v = w;fv = fw;w = x;fw = fxx;x = u;fxx = fu;
                }
                else
                {
                    if (u < x)
                        xl = u;
                    else
                        xu = u;

                    if (fu<=fw || w==x)
                    {
                        v = w;fv = fw;w = u;fw = fu;
                    }
                    else
                    {
                        if (fu<=fv || v==x || v==w)
                        {
                            v = u;fv = fu;
                        }
                    }
                }
                xm = 0.5 * (xl + xu);
                txtResultado.AppendText(string.Format("iteracion {0} - f({1}) = {2} \r\n", i,u, fu));
                px = u; pfx = fu;
            } while (Math.Abs(e) > tol);
        }

        private void cbxMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxMetodo.SelectedIndex)
            {
                case 0:
                    txtMaxIt.Enabled = true;
                    txtError.Enabled = true;
                    break;
                case 1:
                    txtMaxIt.Enabled = false;
                    txtError.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Método de la sección dorada: Introduce la función en el formato correcto, los valores xl y xu que encierran el máximo, \r\n" +
                "número máximo de iteraciones y el error, esto para que el método pueda terminar \r\n" +
                "Método de Brent: Introduce la función en el formato correcto y los valores xl y xu que encierran el mínimo \r\n" +
                "NOTA: Ten en cuenta que si deseas encontrar un mínimo con la seccion dorada solo introduce la funcion multiplicada por -1, \r\n" +
                "lo mimo con el método de Brent en caso de encotrar un máximio \r\n" +
                "Puedes gráficar la función para verificar la información", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            CSeguridadGraf mostrarGrafica = new CSeguridadGraf();
            string fx = txtFuncion.Text;
            mostrarGrafica.SeguridadGrafica4(fx,px,pfx);
        }
    }
}

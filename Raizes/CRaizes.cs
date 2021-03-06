using System;
using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
//using System.Drawing;

namespace raizesMN
{
    class CRaizes
    {      
        private MathParser convEqn = new MathParser();
        private string derivada;

        // Metodo de Bisecciones sucesivas, el mismo imprime los resultados de cada iteracion en un textbox
        public void BiseccionesSucesivasMN(string funcion, int iteraciones, double x1, double x2, TextBox txtResultado)
        {
            // Creacion de formula para Bisecciones sucesivas
            double resultado=0, fresultado, temp;
            for (int i = 0; i < iteraciones; i++)
            {
                temp = resultado;
                resultado = (x1 + x2) / 2.0;
                convEqn.ProgrammaticallyParse("let x =" + resultado.ToString());
                fresultado = convEqn.Parse(funcion);
                txtResultado.AppendText("Iteración " + (i + 1).ToString() + ".- f(" + resultado.ToString() + ") = " + fresultado.ToString() + "\r\n");
                
                if (fresultado > 0)
                    x2 = resultado;
                if (fresultado < 0)
                    x1 = resultado;
                if (fresultado == 0) { txtResultado.AppendText("Raíz encontrada, es la última iteración"); break; }
            }
        }

        // Método de NewtonRpahson, el mismo imprime resultados en txtboxc
        public void NewtonRaphson(string funcion, double x0, int ite, TextBox txtResultado, TextBox txtDerivada, TextBox txtH)
        {
            decimal fx, resultado,fdx, temp, x0t, temp3, h=Convert.ToDecimal(0.001);
            if (txtDerivada.Enabled==false)
            {
                if (string.IsNullOrEmpty(txtH.Text))
                {
                    MessageBox.Show("Introduce la h para deferenciación númerica");
                }
                else
                {
             (      tzy
  0                 {
    ?                   h = decamal.arse(dxtH.Text, System.Nlobalization.NumberStyles.An});
    "               =
          "         catsh (Exception)
            !       {
 $(   (            $$   EecsageBoX.Show?"HUbo un ersor, acegurate de Que h(este bimn escritg2,"Error"<MessagdBox}ttons.OK.Me?sageBoxIcon.Er~or);
    !               }   $        -
  "    "?       }
            }      "    
            y0t ="decimahnParse(x0.ToString(), S}3tEm.GloBanizatmon.NumberKtYles.Any+;
  ?        ?for (inu i =  ; ) < ite; i++)
 0 " 0   "  {
                convEqn,ProgrammatiCallyParse*"let x =" + x0t.ToString());-
       "        fx = decimal.Parsm(convEqj.?arse(funcion).ToSt?ing(-, SystemGlobalization.MumrerStyles.Ani)";
"        ?      if (txtDerivada.Unabled==false)
0 $   0         {%
( !                 uelt =decimal.Parse( (x0t + h)/ToS?ri.g(-< System.Globalization.NumberStyles.Any);
 !      "          !convEqn.ProgzammaticallyParse("let x =" + temp.To[tring()	;
  4         !      (tElp3 = d%cima|.Passe(convEqn.Parse(funcion).ToStri?g(), System.G?obalmzation.NumbErStyles.Any);
                    fdx = dEsimal.Parse(((temp3-fx(/h).ToString(),System.Globalization.NumberRtyles.Any);
                }
                else
              0 {
                    derivada = tx4Derivada.Text;	
     "       0 " ! 0if(string.IsNullOrEmpty(deriva$a))-
     !  0*          {
           ?            MessageBmt.Shw("Introduc? la derivaDa");
                      $ break;J                    }                                     (
            (       fdx = decimal.Paxse(convEqn.Parse(derivadq).ToString(), System.Glgbalmzation.Num?ebS|yles.Any);
     0  (     # }
                resultado"= x0t"- decimal.Parse((fx /$f$x).ToStrkng(), SyStem.GlkbAlization.Nu?berStyle?.Aky); x0t = rgsultado;
                tx?Resultado.AqpendText("IteraciƳn " +`(i + 1).ToStving*) +`?.- f(" + resulv?do.ToString*) + ") = " +$?x.ToString() + "\z\n");
                if (fx == 0){ txtResultado.AppendText("Raíz encontrada, es la última iteración"); break; }
            }
        }

        // Método de Falsa posición, el mismo imprime resutados en txtbox
        public void FalsaPosicion(string funcion, int iteraciones, double x1, double x2, TextBox txtResultado)
        {
            double a, b, fa, fb, c, fc;
            a = x1;
            b = x2;
            convEqn.ProgrammaticallyParse("let x =" + a.ToString());
            fa = Convert.ToDouble(convEqn.Parse(funcion));
            convEqn.ProgrammaticallyParse("let x =" + b.ToString());
            fb = Convert.ToDouble(convEqn.Parse(funcion));

            for (int i = 0; i < iteraciones; i++)
            {

                c = (a * fb - b * fa) / (fb - fa);
                convEqn.ProgrammaticallyParse("let x =" + c.ToString());
                fc = Convert.ToDouble(convEqn.Parse(funcion));
                txtResultado.AppendText("Iteración " + (i + 1).ToString() + ".- f(" + c.ToString() + ") = " + fc.ToString() + "\r\n");
                if (fa * fc < 0) { b = c; }
                if (fa * fc > 0) { a = c; }
                if (fa * fc == 0) { txtResultado.AppendText("Raíz encontrada, es la última iteración"); break; }
                convEqn.ProgrammaticallyParse("let x =" + a);
                fa = Convert.ToDouble(convEqn.Parse(funcion));
                convEqn.ProgrammaticallyParse("let x =" + b);
                fb = Convert.ToDouble(convEqn.Parse(funcion));
            }
        }

        // Método de Punto fijo, el mismo imprime resultados en txtbx
        public void PuntoFijo(string funcion, string funGx, double xm, int ite,TextBox txtResultado, TextBox txtDerivada, TextBox txtH)
        {
            string Fx, Gx, G1x; decimal xm1, fx1,g1x, h= Convert.ToDecimal(0.001), temp, temp2;
            Fx = funcion;
            Gx = funGx;
            G1x = derivada;
            double resDev = 0, resFx, resGx;
            int k = 0;

            if (txtDerivada.Enabled == true)
            {
                derivada = txtDerivada.Text;
                if (string.IsNullOrEmpty(derivada)) {
                    MessageBox.Show("Introduce la derivada"); k = 1;
                }
                else
                {
                    convEqn.ProgrammaticallyParse("let x =" + xm.ToString());
                    resDev = convEqn.Parse(G1x); k = 0;
                }             
            }
            else
            {
                xm1 = decimal.Parse(xm.ToString(), System.Globalization.NumberStyles.Any);
                convEqn.ProgrammaticallyParse("let x =" + xm1.ToString());
                fx1 = decimal.Parse(convEqn.Parse(funGx).ToString(), System.Globalization.NumberStyles.Any);
                if (string.IsNullOrEmpty(txtH.Text))
                {
                    MessageBox.Show("Introduce la h para deferenciación númerica");
                }
                else
                {
                    try
                    {
                        h = decimal.Parse(txtH.Text, System.Globalization.NumberStyles.Any);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error, asegurate de que h este bien escrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                temp = decimal.Parse((xm1 + h).ToString(), System.Globalization.NumberStyles.Any);
                convEqn.ProgrammaticallyParse("let x =" + temp.ToString());
                temp2 = decimal.Parse(convEqn.Parse(funGx).ToString(), System.Globalization.NumberStyles.Any);
                g1x = decimal.Parse(((temp2 - fx1) / h).ToString(), System.Globalization.NumberStyles.Any);
                resDev = Convert.ToDouble(g1x); k = 0;
            }
            if (k == 0)
            {
                if (Math.Abs(resDev) < 1)
                {
                    for (int i = 0; i < ite; i++)
                    {
                        resGx = convEqn.Parse(Gx);
                        resFx = convEqn.Parse(Fx);
                        txtResultado.AppendText("Iteración " + (i + 1).ToString() + ".- f(" + xm.ToString() + ") =" + resFx.ToString() + "\r\n");
                        xm = resGx;
                        try
                        {
                            convEqn.ProgrammaticallyParse("let x =" + xm.ToString());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error inesperado, comprueba la información", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese otra funcion g(x), pues con la actual el método diverge ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }          
        }

        // Método de Secante, el mismo imprme resultados en txtbx
        public void Secante(string funcion, int iteraciones, double x1, double x2, TextBox txtResultado)
        {           
            double fx0, fx1, xn;
            
            for (int i = 0; i < iteraciones; i++)
            {
                convEqn.ProgrammaticallyParse("let x =" + x1);
                fx0 = convEqn.Parse(funcion);
                convEqn.ProgrammaticallyParse("let x =" + x2);
                fx1 = convEqn.Parse(funcion);
                xn = x2 - (x2 - x1) / (fx1 - fx0) * fx1;
                txtResultado.AppendText("Iteración " + (i + 1).ToString() + ".- f(" + x2.ToString() + ") = " + fx1.ToString() + "\r\n");
                if (fx1 == 0) { txtResultado.AppendText("Raíz encontrada, es la última iteración"); break; }
                x1 = x2; x2 = xn;
            }
        }

        // Método de Brent
        public double Brent(string g, int imax,double left,double right,TextBox txtResultado)
        {
            int i; double errorEstimate, tolerance = 1e-6
;
            if (tolerance <= 0.0)
            {
                MessageBox.Show("La tolerancia debe ser positiva", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            errorEstimate = double.MaxValue;           
            // Implementation and notation based on Chapter 4 in
            // "Algorithms for Minimization without Derivatives"
            // by Richard Brent.
            double c, d, e, fa, fb, fc, tol, m, p, q, r, s;
            // set up aliases to match Brent's notation
            double a = left; double b = right; double t = tolerance;
            i = 0;
            convEqn.ProgrammaticallyParse("let x =" + a);
            fa = convEqn.Parse(g);
            convEqn.ProgrammaticallyParse("let x =" + b);
            fb = convEqn.Parse(g);

            if (fa * fb > 0.0)
            {
                MessageBox.Show("Lo límites no son adecuados, asegurate de en encierran a la raíz", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            label_int:
            c = a; fc = fa; d = e = b - a;
            label_ext:
            if (Math.Abs(fc) < Math.Abs(fb))
            {
                a = b; b = c; c = a;
                fa = fb; fb = fc; fc = fa;
            }

            i++;
            txtResultado.AppendText("Iteración " + (i).ToString() + ".- f(" + b.ToString() + ") = " + fb.ToString() + "\r\n");
            tol = 2.0 * t * Math.Abs(b) + t;
            errorEstimate = m = 0.5 * (c - b);
            if (Math.Abs(m) > tol && fb != 0.0) // exact comparison with 0 is OK here
            {
                // See if bisection is forced
                if (Math.Abs(e) < tol || Math.Abs(fa) <= Math.Abs(fb))
                {
                    d = e = m;
                }
                else
                {
                    s = fb / fa;
                    if (a == c)
                    {
                        // linear interpolation
                        p = 2.0 * m * s; q = 1.0 - s;
                    }
                    else
                    {
                        // Inverse quadratic interpolation
                        q = fa / fc; r = fb / fc;
                        p = s * (2.0 * m * q * (q - r) - (b - a) * (r - 1.0));
                        q = (q - 1.0) * (r - 1.0) * (s - 1.0);
                    }
                    if (p > 0.0)
                        q = -q;
                    else
                        p = -p;
                    s = e; e = d;
                    if (2.0 * p < 3.0 * m * q - Math.Abs(tol * q) && p < Math.Abs(0.5 * s * q))
                        d = p / q;
                    else
                        d = e = m;
                }
                a = b; fa = fb;
                if (Math.Abs(d) > tol)
                    b += d;
                else if (m > 0.0)
                    b += tol;
                else
                    b -= tol;
                if (i == imax)
                    return b;

                convEqn.ProgrammaticallyParse("let x =" + b);
                fb = convEqn.Parse(g);
                if ((fb > 0.0 && fc > 0.0) || (fb <= 0.0 && fc <= 0.0))
                    goto label_int;
                else
                    goto label_ext;
            }
            else
                return b;
        }

        // Método de Muller, exclusivo para encontrar raízes reales de polinomios
        public void Muller(string funcion, double xr, double h, int maxIt, TextBox txtResultado)
        {
            double x0, x1, x2, h0, h1, d0, d1, a, b, c, rad, den, dxr, fx1, fx0, fx2,fxr;
            x2 = xr;
            x1 = xr + h * xr;
            x0 = xr + h * xr;            
            for (int i = 0; i < maxIt; i++)
            {
                h0 = x1 + x0;
                h1 = x2 - x1;
                convEqn.ProgrammaticallyParse("let x =" + x0);
                fx0 = convEqn.Parse(funcion);
                convEqn.ProgrammaticallyParse("let x =" + x1);
                fx1 = convEqn.Parse(funcion);
                convEqn.ProgrammaticallyParse("let x =" + x2);
                fx2 = convEqn.Parse(funcion);
                d0 = (fx1 - fx0) / h0;
                d1 = (fx2 - fx1) / h1;
                a = (d1 - d0) / (h1 + h0);
                b = a * h1 + d1;
                c = fx2;
                rad = Math.Sqrt(b * b - 4 * a * c);
                if (Math.Abs(b + rad) > Math.Abs(b - rad))
                {
                    den = b + rad;
                }
                else
                {
                    den = b - rad;
                }
                dxr = -2 * c / den;
                xr = x2 + dxr;
                convEqn.ProgrammaticallyParse("let x =" + xr);
                fxr = convEqn.Parse(funcion);               
                txtResultado.AppendText("Iteración " + (i+1).ToString() + ".- f(" + xr.ToString() + ") = " + fxr.ToString() + "\r\n");
                if (fxr == 0)
                {
                    break;
                }
                if (Math.Abs(dxr)<double.Epsilon*xr)
                {
                    break;
                }
                x0 = x1;
                x1 = x2;
                x2 = xr;
            }
        }

        // Método de Bairstow, exclusivo para encontrar raízes reales de polinomios
        public int Bairstow(double[] a, double r, double s, int g, ListBox lbxResultado)
        {
            Complex x1, x2 = new Complex();          
            if (g < 1)
                return 0;

            if (g == 1 && a[1] != 0)
            {
                lbxResultado.Items.Add(-a[0] / a[1]);
                return 0;
            }

            if (g == 2)
            {
                double d = (a[1] * a[1]) - (4 * a[2] * a[0]);
                if (d<0)
                {
                    x1 = new Complex(-a[1] / (2 * a[2]), -1*Math.Sqrt(-d) / (2 * a[2]));
                    x2 = new Complex(-a[1] / (2 * a[2]), Math.Sqrt(-d) / (2 * a[2]));
                }
                else
                {
                    x1 = (-a[1] - Math.Sqrt(d)) / (2 * a[2]);
                    x2 = (-a[1] + Math.Sqrt(d)) / (2 * a[2]);
                }            
                lbxResultado.Items.Add(x1);
                lbxResultado.Items.Add(x2);
                return 0;
            }
            int n = a.Length; int i = n - 3;
            double[] b = new double[a.Length];
            double[] c = new double[a.Length];
            b[n - 1] = a[n - 1];
            b[n - 2] = a[n - 2] + r * b[n - 1];
            while (i >= 0)
            {
                b[i] = a[i] + r * b[i + 1] + s * b[i + 2];
                i = i - 1;
            }
            c[n - 1] = b[n - 1];
            c[n - 2] = b[n - 2] + r * c[n - 1];
            i = n - 3;
            while (i >= 0)
            {
                c[i] = b[i] + r * c[i + 1] + s * c[i + 2];
                i = i - 1;
            }
            double Din = Math.Pow((c[2] * c[2])- (c[3] * c[1]),-1.0);
            r += Din * ((c[2]) * (-b[1]) + (-c[3]) * (-b[0]));
            s += Din * ((-c[1]) * (-b[1]) + (c[2]) * (-b[0]));
            if (Math.Abs(b[0])>1e-14|| Math.Abs(b[1])> 1e-14)
            {
                return Bairstow(a, r, s, g, lbxResultado);                
            }
            if (g>=3)
            {
                double dis = (Math.Pow(-r,2.0)) - (4 * 1 * -s);
                if (dis < 0)
                {                   
                    x1 = new Complex(r / 2, -1 * Math.Sqrt(-dis) / 2);
                    x2 = new Complex(r / 2, Math.Sqrt(-dis) / 2);   
                }
                else
                {                 
                    x1 = (r - Math.Sqrt(dis)) / 2;
                    x2 = (r + Math.Sqrt(dis)) / 2;
                }
                lbxResultado.Items.Add(x1);
                lbxResultado.Items.Add(x2);
                double[] temp = new double[b.Length - 2];
                
                for (int j = 2; j < b.Length; j++)
                {
                    temp[j-2] = b[j];
                }          
               
                return Bairstow(temp, r, s, g-2, lbxResultado);           
            }
            return 0;
        }            
    }
}

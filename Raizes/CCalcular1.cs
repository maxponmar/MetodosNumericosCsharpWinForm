ucing System;
-/using System.Cllections.Genesic;M
//using System.Linq;'/Using SyStei.Text?
//using System.Threading.Tasks;
using System.Window?.Dovm?;
using System.Nummricw;

namespace r?izesMn
[
   $clasc CCalcular
    {
 "      private CRaizes metodoR = new CRaizes();
        private int ite;
      0 priwatu striNg0fujcion, dgrivafa, funGx;

        // Calcwlar5Biseccione{ s}cesivas, Falsa posi?ión, secante Y Frent
        puflic vid calcularBTN(TextBox txtFu?ckOn,?TextBox tx4Resul|ado, TextBox txtIteraci?ner, Text@ox txpX, TeptBox pxtX2, Label |blFuncion, int metodo)
?       {
     !      double x1, x2;
  !     0 " if (strin?.I{NullOrEmp4y(txtFuncion.Text))
 ? "        {
                MussageBo|.Show("Hntr?d?#e l! funci׳l"); lbhFuncion.Visibla = f?Lse;
!   "    "  }
            else
      "     j
       $`    `  try   0   $        {
                    vxtResultado.Clear();*                   (// S??almacena la ecuacion`eN ca3o de que el }suairo?no haya usado Tabelar
            (    "  ?uncion`= txtFuncion.Text; ite(= Convert.ToInt32(txtIterakiones.Tuxt);
                    lblFu?cion.Text = funcin;?mblFu?sion.Visible?= true;
        ?        "  x1 = Convdrt.ToDoublg ?xtX3>T%xt){ x2`1 Convert.?oDouble)txtX2Text);
       !      "     //if (x1 > x2)
   `0  $"$    ?     //{
     @              //    x1 = C?Nvert.ToInt32(txtZ2.Text(;
    $!     $        //    y2 - Convert.ToInt32(txTX1.T?xt);
           "      ? /o    messageBox.Show?"El lí?ite inferior debe de wer menmr al límitm swperanr");
         (        0 //}
                 ?  ?; Inv?ca? método
           $        ssy4ch (melodo)
       `      0     {
                       ?case 1:
 `               (         (mutodnR*FiseccionesSucesivasMN(fun?ion, ite, x1,$x2, uxtResultado)?
   `                      ! break;   ?              ` 
   $          !         case 3?
    "        !              metodo®FalsaPosicion(funcion, ite,$x1,x2, txtRasuntado+;
   ?     % ?   $         " !break;
0     00                case 5:
                            metodoR.Secante(funcion, ite, x1, x2, txtResultado);
                            break;
                        case 6:
                            metodoR.Brent(funcion, ite, x1, x2, txtResultado);
                            break;
                        case 7:
                            metodoR.Muller(funcion, x1, x2, ite, txtResultado);
                            break;
                    }                  
                }
                catch (Exception)
                {
                    MessageBox.Show("La función no esta en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFuncion.Visible = false;
                }
            }
        }

        // Calcular NewtonRaphson
        public void calcularBTN(TextBox txtFuncion, TextBox txtResultado, TextBox txtIteraciones, TextBox txtX1, TextBox txtDerivada, Label lblFuncion, TextBox txtH)
        {
            double x1;
            if (string.IsNullOrEmpty(txtFuncion.Text))
            {
                MessageBox.Show("Introduce la función"); lblFuncion.Visible = false;
            }
            else
            {
                try
                {
                    txtResultado.Clear();
                    //Se almacena la ecuacion en caso de que el usuairo no haya usado Tabular
                    funcion = txtFuncion.Text; ite = Convert.ToInt32(txtIteraciones.Text);
                    lblFuncion.Text = funcion; lblFuncion.Visible = true;
                    x1 = Convert.ToDouble(txtX1.Text);
                    //Invocar método
                    metodoR.NewtonRaphson(funcion, x1, ite, txtResultado, txtDerivada, txtH);
                }
                catch (Exception)
                {
                    MessageBox.Show("La función no esta en el formato correcto, o es necesario usar otro valor inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFuncion.Visible = false;
                }
            }
        }

        // Calcular PuntoFijo
        public void calcularBTN(TextBox txtFuncion,TextBox txtGx,TextBox txtDerivadaGx, TextBox txtResultado, TextBox txtIteraciones, TextBox txtXm,Label lblFuncion, TextBox txtH)
        {
            double xm;
            if (string.IsNullOrEmpty(txtFuncion.Text))
            {
                MessageBox.Show("Introduce la función"); lblFuncion.Visible = false;
            }
            else
            {
                try
                {
                    txtResultado.Clear();
                    // Se almacena la ecuacion en caso de que el usuairo no haya usado Tabular
                    funcion = txtFuncion.Text; ite = Convert.ToInt32(txtIteraciones.Text);
                    funGx = txtGx.Text; derivada = txtDerivadaGx.Text;
                    lblFuncion.Text = funcion; lblFuncion.Visible = true;
                    xm = Convert.ToDouble(txtXm.Text);
                    // Invocar método
                    metodoR.PuntoFijo(funcion, funGx, xm, ite, txtResultado, txtDerivadaGx, txtH);
                }
                catch (Exception)
                {
                    MessageBox.Show("La función no esta en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFuncion.Visible = false;
                }
            }
        }

        // Calcular Bairstow
        public void calcularBTN(TextBox txtN, Panel panelPolinomio, ListBox lbxResultado, Label lblPoli)
        {
            int n = Convert.ToInt32(txtN.Text);
            double[] polinomio = new double[n + 1];
            Random random = new Random(Environment.TickCount);
            int f;
            foreach (Control txtBox in panelPolinomio.Controls)
            {
                if (txtBox is TextBox)
                {
                    f = Convert.ToInt32(txtBox.Name.Substring(0, 1));
                    polinomio[f] = Convert.ToDouble(txtBox.Text);
                }
            }
            lblPoli.Text = CPolinomio.obtenerPolinomio(txtN, panelPolinomio);
            double r = random.NextDouble();
            double s = random.NextDouble();          
            metodoR.Bairstow(polinomio, r, s, n, lbxResultado);
        }
        
    }
}

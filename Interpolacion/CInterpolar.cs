using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raizesMN
{
    public class CInterpolar
    {
        public static void AcumFunSim(ComboBox cbxMetodos, double[,] SEL, double[,] xy, TextBox txtResultado)
        {
            int pR = 0;
            switch (cbxMetodos.SelectedIndex)
            {
                case 0:
                    // Lineal
                    for (int i = 0; i < 2; i++)
                    {
                        SEL[i, 0] = 1; SEL[i, 1] = xy[0, i]; SEL[i, 2] = xy[1, i];
                    }
                    pR = 2;
                    break;
                case 1:
                    // Cuadratica
                    for (int i = 0; i < 3; i++)
                    {
                        SEL[i, 0] = 1; SEL[i, 1] = xy[0, i]; SEL[i, 2] = Math.Pow(xy[0, i], 2); SEL[i, 3] = xy[1, i];
                    }
                    pR = 3;
                    break;
                case 2:
                    // Cubica
                    for (int i = 0; i < 4; i++)
                    {
                        SEL[i, 0] = 1; SEL[i, 1] = xy[0, i]; SEL[i, 2] = Math.Pow(xy[0, i], 2); SEL[i, 3] = Math.Pow(xy[0, i], 3); SEL[i, 4] = xy[1, i];
                    }
                    pR = 4;
                    break;
            }

            // Invoca el método para resolver el SEL
            double[] r = new double[pR]; // Arreglo donde se guardarán los resultados
            if (CResolverSEL.EliminacionGaussiana(SEL, r))
            {
                switch (cbxMetodos.SelectedIndex)
                {
                    case 0:
                        // Lineal
                        txtResultado.Text = r[1].ToString() + "x + (" + r[0].ToString() + ")";
                        break;
                    case 1:
                        // Cuadratica
                        txtResultado.Text = r[2].ToString() + "x^2 + (" + r[1].ToString() + ")x + (" + r[0].ToString() + ")";
                        break;
                    case 2:
                        // Cubica
                        txtResultado.Text = r[3].ToString() + "x^3 + (" + r[2].ToString() + ")x^2 + (" + r[1].ToString() + ")x + (" + r[0].ToString() + ")";
                        break;
                }
            }
            else
            {
                txtResultado.Clear();
                txtResultado.AppendText(Environment.NewLine + "No es un sistema de ecuaciones lineales");
            }
        }

        public static void AjCurMinCua(ComboBox cbxMetodos, double[,] SEL, double[,] xy, int n,TextBox txtResultado, TextBox txtDatosf)
        {
            double zx2, zx, zy, zxy, zx3, zx4, zx2y; int k = 0;
            zx2 = 0; zx = 0; zy = 0; zxy = 0; zx3 = 0; zx4 = 0; zx2y = 0; k = 0;

            for (int i = 0; i < n; i++)
            {
                zx += xy[0, i]; zx2 += Math.Pow(xy[0, i], 2); zx3 += Math.Pow(xy[0, i], 3); zx4 += Math.Pow(xy[0, i], 4);
                zy += xy[1, i]; zxy += (xy[0, i] * xy[1, i]); zx2y += (Math.Pow(xy[0, i], 2) * xy[1, i]);
            }
            switch (cbxMetodos.SelectedIndex)
            {
                case 0:
                    // Lineal
                    SEL = new double[2, 3]; k = 2;
                    SEL[1, 1] = n;
                    SEL[0, 0] = zx2; SEL[0, 1] = zx; SEL[1, 0] = zx; SEL[0, 2] = zxy; SEL[1, 2] = zy;
                    break;
                case 1:
                    // Cuadratica
                    SEL = new double[3, 4]; k = 3;
                    SEL[0, 0] = n;
                    SEL[0, 1] = zx; SEL[1, 0] = zx; SEL[0, 1] = zx; SEL[0, 2] = zx2; SEL[1, 1] = zx2; SEL[2, 0] = zx2; SEL[1, 2] = zx3; SEL[2, 1] = zx3; SEL[2, 2] = zx4;
                    SEL[0, 3] = zy; SEL[1, 3] = zxy; SEL[2, 3] = zx2y;
                    break;
            }

            // Invoca el método para resolver el SEL
            double[] r = new double[k]; // Arreglo donde se guardarán los resultados
            if (CResolverSEL.EliminacionGaussiana(SEL, r))
            {
                switch (cbxMetodos.SelectedIndex)
                {
                    case 0:
                        // Lineal
                        txtResultado.Text = r[0].ToString() + "x + (" + r[1].ToString() + ")";
                        double sr = 0, st = 0, r2, syx;
                        for (int i = 0; i < n; i++)
                        {
                            st += Math.Pow(xy[1, i] - zy / n, 2);
                            sr += Math.Pow(xy[1, i] - r[0] * xy[0, i] - r[1], 2);
                        }
                        syx = Math.Sqrt(sr / (n - 2));
                        r2 = (st - sr) / st;
                        txtDatosf.AppendText(string.Format("{0}  |  {1}  |  {2}", syx, r2, Math.Sqrt(r2)));
                        break;
                    case 1:
                        // Cuadratica
                        txtResultado.Text = r[2].ToString() + "x^2 + (" + r[1].ToString() + ")x + (" + r[0].ToString() + ")";
                        break;
                }
            }
            else
            {
                txtResultado.Clear();
                txtResultado.AppendText("No es un sistema de ecuaciones lineales");
            }
        }

        public static void DDFNewton(double[,] xy, int n, TextBox txtResultado)
        {
            int xn; double[] FX;
            FX = DifDivFinNewton(xy, n);
            xn = 1;
            for (int i = 0; i < n; i++)// imprimir ecuacion
            {
                if (i == 0)
                {
                    txtResultado.AppendText(FX[i].ToString());
                }
                else
                {
                    txtResultado.AppendText(" + (" + Convert.ToDecimal(FX[i]).ToString() + ")*x^" + xn.ToString());
                    xn++;
                }

            }
            xn = 0;

        }
        public static void DDFNewton(double[,] xy, int n, ListBox lbxResultados)
        {
            double[] FX;
            FX = DifDivFinNewton(xy, n);
            string funcion="";
            for (int i = 0; i < n; i++)// imprimir ecuacion
            {
                if (i == 0)               
                    funcion+= FX[i].ToString();                                  
                else                               
                    funcion += " + (" + FX[i].ToString() + ")x";                
            }          
            lbxResultados.Items.Add(string.Format("{0} , xϵ[{1},{2}]", funcion, xy[0, 0], xy[0, 1]));
        }
        static double[] DifDivFinNewton(double[,] xy, int n)
        {
            int m;
            double[] FX, X, Y, Bn;
            double[,] polinomio;
            m = n;
            X = new double[m];
            Y = new double[m];
            for (int i = 0; i < m; i++)
            {
                X[i] = xy[0, i]; Y[i] = xy[1, i]; // eliminar matrizdatos
            }
            double[,] T;
            int A = m, B = 0, C, D;
            C = A - 1;
            T = new double[(A - 1), (A - 1)]; //obtener diferencias divididas
            while (B <= (C - 1))
            {
                T[B, 0] = ((Y[B + 1] - Y[B]) / (X[B + 1] - X[B]));
                B += 1;
            }
            D = 1;
            while (D <= (C - 1))
            {
                B = D;
                while (B <= (C - 1))
                {
                    T[B, D] = ((T[B, (D - 1)] - T[(B - 1), (D - 1)]) / (X[B + 1] - X[B - D]));
                    B += 1;
                }
                D += 1;
            }
            Bn = new double[m]; //acomodar difrencias divididas en matriz Bn
            for (int i = 0; i < m; i++)
            {
                if (i == 0)
                {
                    Bn[0] = Y[0];
                }
                else
                {
                    Bn[i] = T[(i - 1), (i - 1)];
                }
            }
            // crear matriz donde se guarden los polinomios

            polinomio = new double[m, m];// polinomio de Newton;
            double[] p = new double[m + 1];
            p[0] = -X[0]; p[1] = 1;//p = (x-x1)

            polinomio[0, 0] = Bn[0]; // primera fila
            polinomio[1, 0] = -X[0]; polinomio[1, 1] = 1;// segunda fila
            for (int i = 2; i < m; i++) // filas que quedan
            {
                var b = new double[] { -X[i - 1], 1 };
                p = Multiply(p, b);
                for (int j = 0; j < m; j++)
                {
                    polinomio[i, j] = p[j];
                }
            }

            for (int i = 1; i < m; i++) // multiplicar las filas por bn
            {
                for (int j = 0; j < m; j++)
                {
                    polinomio[i, j] *= Bn[i];
                }
            }
            FX = new double[m];
            for (int i = 0; i < m; i++) // sumar colmnas para obtener ecuacion final
            {
                for (int j = 0; j < m; j++)
                {
                    FX[i] += polinomio[j, i];
                }
            }
            return FX;
        }
        static double[] Multiply(double[] a, double[] b)
        {
            var result = new double[a.Length + b.Length - 1];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    result[i + j] += a[i] * b[j];
                }
            }
            return result;
        }

        public static void Lagrange(double[,] xy, int n, TextBox txtResultado)

        {
            double[] FX, X, Y; int m, xn;
            m = n;
            X = new double[m];
            Y = new double[m];
            for (int i = 0; i < m; i++)
            {
                X[i] = xy[0, i]; Y[i] = xy[1, i];
            }
            ceros(m); // dar los datos necesarios para calcular polinomio
            for (int i = 0; i < m; i++)
            {
                denominador(i, X);
                interpolacion(i, X);
            }
            FX = Lagranges(X, Y);
            xn = 1;
            for (int i = 0; i < m; i++)// imprimir ecuacion
            {
                if (i == 0)
                {
                    txtResultado.AppendText(FX[i].ToString());
                }
                else
                {
                    txtResultado.AppendText(" + (" + FX[i].ToString() + ")x^" + xn.ToString());
                    xn++;
                }

            }
            xn = 0;
        }

        public static void Splines(ComboBox cbxMetodos, double[,] xy, int n, ListBox lbxResultado)
        {
            switch (cbxMetodos.SelectedIndex)
            {
                case 0:
                    // Grado 1
                    int nsplines = n - 1;
                    double[,] datos = new double[2, 2];
                    for (int i = 0; i < nsplines; i++)
                    {
                        datos[0, 0] = xy[0, i]; datos[1, 0] = xy[1, i];
                        datos[0, 1] = xy[0, i+1]; datos[1, 1] = xy[1, i+1];
                        CInterpolar.DDFNewton(datos, 2, lbxResultado);
                    }
                    break;
                case 1:
                    // Grado 2

                    #region Splines grado 2
                    int nSplines = n - 1, variables = 3 * (n-1), nEqn1 = 2*(n-1), nEqn2 = n-2;
                    int indice1 = 0, Pot, temp1, temp2, salto, columna;
                    double[,] SELs2, eqn1s2, eqn2s2 ;
                    SELs2 = new double[variables, variables + 1];
                    eqn1s2 = new double[nEqn1, variables];
                    eqn2s2 = new double[nEqn2, variables];

                    // Llenar eqn1
                    temp1 = 0;salto = 0;Pot = 2;temp2 = 0;columna = 0;
                    for (int i = 0; i < nEqn1; i++)
                    {
                        if (i == 0) { indice1 = 0; }
                        if (i == (nEqn1 - 1)) { indice1 = n - 1; temp1 = -1; }
                        if (salto == 2) { salto = 0; temp1++; }
                        if (i > 0 && i < nEqn1 - 1) { indice1 = 1 + temp1; salto++; }
                        for (int j = 0; j < 3; j++)
                        {
                            eqn1s2[i, (j + columna)] = Math.Pow((xy[0, indice1]), Pot); 
                            Pot--;
                            if (j == 2) { temp2++; Pot = 2; }
                            if (temp2 == 2) { columna += 3; temp2 = 0; }
                        }
                        indice1++;
                    }
                    // Llenar eqn2
                    Pot = 1; columna = 0; indice1 = 1;                
                    for (int i = 0; i < nEqn2; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            eqn2s2[i, (j + columna)] = (Pot + 1) * Math.Pow((xy[0, indice1]), Pot); 
                            eqn2s2[i, (j + columna + 3)] = -1 * (Pot + 1) * Math.Pow((xy[0, indice1]), Pot);
                            Pot--;
                            if (j == 2) { Pot = 1; columna += 3; }
                        }
                        indice1++;
                    }
                    //==========LLENAR SISTEMA DE ECUACIONES====================//
                    for (int i = 0; i < variables; i++)
                    {
                        for (int j = 0; j < variables; j++)
                        {
                            if (i < nEqn1) { SELs2[i, j] = eqn1s2[i, j]; }
                            if (i >= nEqn1 && i < variables - 1) { SELs2[i, j] = eqn2s2[i-nEqn1, j]; }           
                        }
                    }
                    SELs2[variables - 1, 0] = 1;
                    //Llenas columna de respuestas (y)
                    temp1 = 0; salto = 0;
                    for (int i = 0; i < nEqn1; i++)
                    {
                        if (i == 0) { indice1 = 0; }
                        if (i == (nEqn1 - 1)) { indice1 = n - 1; temp1 = -1; }
                        if (salto == 2) { salto = 0; temp1++; }
                        if (i > 0 && i < nEqn1 - 1) { indice1 = 1 + temp1; salto++; }
                        SELs2[i, variables] = xy[1, indice1];//m2y[z, 0]
                    }
                    #endregion
                    double[] rs2 = new double[variables];
                    if (CResolverSEL.EliminacionGaussiana(SELs2, rs2))
                        CInterpolar.ImprimirSplineGrado2(rs2, xy, lbxResultado);
                    else
                    {
                        lbxResultado.Items.Clear();
                        lbxResultado.Items.Add("No es un sistema de ecuaciones lineales");
                    }
                    break;

                case 2:
                    // Cúbicos
                    #region Splines cubicos
                    int nsx, nsx1, q, k, w, t, z=0, h, o;
                    double[,] eqn1, eqn2, eqn3, SEL1;
                    w = (n - 1) * 4; nsx = (n - 1) * 2; nsx1 = n - 2;
                    eqn1 = new double[nsx, w]; eqn2 = new double[nsx1, w]; eqn3 = new double[nsx1, w];
                    SEL1 = new double[w, w + 1];

                    h = 0; o = 0; k = 3; t = 0; q = 0;  // LLENAR MATRIZ EQN1
                    for (int i = 0; i < nsx; i++)
                    {
                        if (i == 0) { z = 0; }
                        if (i == (nsx - 1)) { z = n - 1; h = -1; }
                        if (o == 2) { o = 0; h++; }
                        if (i > 0 && i < nsx - 1) { z = 1 + h; o++; }
                        for (int j = 0; j < 4; j++)
                        {
                            eqn1[i, (j + q)] = Math.Pow((xy[0, z]), k); //m1x[z, 0]
                            k--;
                            if (j == 3) { t++; k = 3; }
                            if (t == 2) { q += 4; t = 0; }
                        }
                    }

                    k = 2; q = 0; z = 1;                //LLENAR MATRIZ EQN2
                    for (int i = 0; i < nsx1; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            eqn2[i, (j + q)] = (k + 1) * Math.Pow((xy[0, z]), k); //m1x[z, 0]
                            eqn2[i, (j + q + 4)] = -1 * (k + 1) * Math.Pow((xy[0, z]), k); //m1x[z, 0]
                            k--;
                            if (j == 3) { k = 2; q += 4; }
                        }
                        z++;
                    }

                    k = 1; q = 0; z = 1; h = 5;         //LLENAR MATRIZ EQN3
                    for (int i = 0; i < nsx1; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {

                            eqn3[i, (j + q)] = (k + h) * Math.Pow((xy[0, z]), k); // m1x[z, 0]
                            eqn3[i, (j + q + 4)] = -1 * (k + h) * Math.Pow((xy[0, z]), k); //m1x[z, 0]
                            k--;
                            if (k == 0) { h = 2; }
                            if (k < 0) { h = -1 * k; }
                            if (j == 3) { k = 1; q += 4; h = 5; }
                        }
                        z++;
                    }

                    //==========LLENAR SISTEMA DE ECUACIONES====================//
                    h = o;
                    for (int i = 0; i < w; i++)
                    {
                        for (int j = 0; j < w; j++)
                        {
                            if (i < nsx) { SEL1[i, j] = eqn1[i, j]; }

                            if (i >= nsx && i < (nsx + nsx1)) { h = nsx; SEL1[i, j] = eqn2[i - h, j]; }

                            if (i >= (nsx + nsx1) && i < (nsx + (nsx1 * 2))) { h = nsx + nsx1; SEL1[i, j] = eqn3[i - h, j]; }

                        }
                    }
                    SEL1[w - 2, 0] = 6 * xy[0, 0]; SEL1[w - 2, 1] = 2; //m1x[0, 0]
                    SEL1[w - 1, w - 4] = 6 * xy[0, n - 1]; SEL1[w - 1, w - 3] = 2;//m1x[n - 1, 0]
                    h = 0; o = 0; k = 3; t = 0;
                    for (int i = 0; i < nsx; i++)
                    {
                        if (i == 0) { z = 0; }
                        if (i == (nsx - 1)) { z = n - 1; h = -1; }
                        if (o == 2) { o = 0; h++; }
                        if (i > 0 && i < nsx - 1) { z = 1 + h; o++; }
                        SEL1[i, w] = xy[1, z];//m2y[z, 0]
                    }
                    #endregion
                    double[] r = new double[w];
                    if (CResolverSEL.EliminacionGaussiana(SEL1, r))
                        CInterpolar.ImprimirSplineCubico(r, xy, lbxResultado);
                    else
                    {
                        lbxResultado.Items.Clear();
                        lbxResultado.Items.Add("No es un sistema de ecuaciones lineales");                     
                    }
                    break;
            }
        }

        public static void ImprimirSplineCubico(double[] r, double[,] xy, ListBox lbxResultado)
        {
            string spline="";
            int contador = 0, indice = 0;
            for (int i = 0; i <= r.GetUpperBound(0); i++)
            {
                if (contador == 4) { contador = 0; indice++; }
                if (contador == 0) { spline += string.Format("{0}x^3 + ", r[i]); }
                if (contador == 1) { spline += string.Format("({0})x^2 + ", r[i]); }
                if (contador == 2) { spline += string.Format("({0})x + ", r[i]); }
                if (contador == 3)
                {
                    spline += string.Format("({0}) , xϵ[{1},{2}]", r[i], xy[0, indice], xy[0, indice + 1]);
                    lbxResultado.Items.Add(spline); spline = "";
                }
                contador++;               
            }           
        }

        public static void ImprimirSplineGrado2(double[] r, double[,] xy, ListBox lbxResultado)
        {
            string spline = "";
            int contador = 0, indice = 0;
            r[0] = 0;
            for (int i = 0; i <= r.GetUpperBound(0); i++)
            {
                if (contador == 3) { contador = 0; indice++; }
                if (contador == 0) { spline += string.Format("{0}x^2 + ", r[i]); }
                if (contador == 1) { spline += string.Format("({0})x + ", r[i]); }
                if (contador == 2)
                {
                    spline += string.Format("({0}) , xϵ[{1},{2}]", r[i], xy[0, indice], xy[0, indice + 1]);
                    lbxResultado.Items.Add(spline); spline = "";
                }             
                contador++;
            }
        }

        #region Método de Lagrange
        // matriz
        public static double[] ceros(int n)
        {
            double[] array = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                array[i] = 0;
            }
            return array;
        }
        public static double denominador(int i, double[] datosX)
        {
            double resultado = 1;
            double x_i = datosX[i];
            for (int j = datosX.Count() - 1; j >= 0; j--)
            {
                if (i != j)
                {
                    resultado = resultado * (x_i - datosX[j]);
                }
            }
            return resultado;
        }

        // coeficientes de los polinomios in
        public static double[] interpolacion(int i, double[] datosX)
        {
            double[] coeficientes = ceros(datosX.Length);
            coeficientes[0] = ((double)1 / denominador(i, datosX));
            double[] coeficientes2;

            for (int k = 0; k < datosX.Count(); k++)
            {
                if (k == i)
                {
                    continue;
                }
                coeficientes2 = ceros(datosX.Count());

                for (int j = (k < i) ? k + 1 : k; j >= 0; j--)
                {
                    if (j + 1 < datosX.Count())
                    {
                        coeficientes2[j + 1] = coeficientes2[j + 1] + coeficientes[j];
                    }
                    coeficientes2[j] = coeficientes2[j] - (datosX[k] * coeficientes[j]);
                }
                coeficientes = coeficientes2;
            }
            return coeficientes;
        }

        // calcular coeficientes de la ecuacion fianl
        public static double[] Lagranges(double[] datosX, double[] datosY)
        {
            double[] polinomio = ceros(datosY.Count());
            double[] coeficientes;
            for (int i = 0; i < datosY.Count(); ++i)
            {
                coeficientes = interpolacion(i, datosX);
                for (int k = 0; k < datosY.Count(); ++k)
                {
                    polinomio[k] = polinomio[k] + (datosY[i] * coeficientes[k]);
                }
            }
            return polinomio;
        }
        #endregion
    }
}

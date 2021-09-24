using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raizesMN
{
    class CResolverSEL
    {
        public static void EliminacionGaussiana(double[,] a, double[] b, int n, double[] x, double tol)
        {
            double[] s = new double[n + 1];
            int er = 0;
            for (int i = 0; i <= n; i++)
            {
                s[i] = Math.Abs(a[i, 0]);
                for (int j = 1; j <= n; j++)
                {
                    if (Math.Abs(a[i, j]) > s[i])
                        s[i] = Math.Abs(a[i, j]);
                }
            }
            Eliminate(a, s, n, b, tol, er);
            if (er != -1)
            {
                Suvbstitute(a, n, b, x);
            }
        }

        private static void Eliminate(double[,] a, double[] s, int n, double[] b, double tol, int er)
        {
            double factor;
            for (int k = 0; k <= n - 1; k++)
            {
                Pivot(a, b, s, n, k);
                if (Math.Abs(a[k, k] / s[k]) < tol)
                {
                    er = -1;
                    break;
                }

                for (int i = k + 1; i <= n; i++)
                {
                    factor = a[i, k] / a[k, k];
                    for (int j = k + 1; j <= n; j++)
                    {
                        a[i, j] -= factor * a[k, j];
                    }
                    b[i] -= factor * b[k];
                }
            }
            if (Math.Abs(a[n, n] / s[n]) < tol)
                er = -1;
        }

        private static void Pivot(double[,] a, double[] b, double[] s, int n, int k)
        {
            int p = k;
            double big = Math.Abs(a[k, k] / s[k]), dummy;

            for (int i = k + 1; i <= n; i++)
            {
                dummy = Math.Abs(a[i, k] / s[i]);
                if (dummy > big)
                {
                    big = dummy;
                    p = i;
                }
            }

            if (p != k)
            {
                for (int j = k; j <= n; j++)
                {
                    dummy = a[p, j];
                    a[p, j] = a[k, j];
                    a[k, j] = dummy;
                }
                dummy = b[p];
                b[p] = b[k];
                b[k] = dummy;
                dummy = s[p];
                s[p] = s[k];
                s[k] = dummy;
            }
        }

        private static void Suvbstitute(double[,] a, int n, double[] b, double[] x)
        {
            double sum;
            x[n] = b[n] / a[n, n];
            for (int i = n - 1; i >= 0; i--)
            {
                sum = 0;
                for (int j = i; j <= n; j++)
                {
                    sum += a[i, j] * x[j];
                }
                x[i] = (b[i] - sum) / a[i, i];
            }
        }

        public static bool EliminacionGaussiana(double[,] a, double[] r)
        {
            double t, s;
            int i, l, j, k, m, n;

            try
            {
                n = r.Length - 1;
                m = n + 1;
                for (l = 0; l <= n - 1; l++)
                {
                    j = l;
                    for (k = l + 1; k <= n; k++)
                    {
                        if (!(Math.Abs(a[j, l]) >= Math.Abs(a[k, l]))) j = k;
                    }
                    if (!(j == l))
                    {
                        for (i = 0; i <= m; i++)
                        {
                            t = a[l, i];
                            a[l, i] = a[j, i];
                            a[j, i] = t;
                        }
                    }
                    for (j = l + 1; j <= n; j++)
                    {
                        t = (a[j, l] / a[l, l]);
                        for (i = 0; i <= m; i++) a[j, i] -= t * a[l, i];
                    }
                }
                r[n] = a[n, m] / a[n, n];
                for (i = 0; i <= n - 1; i++)
                {
                    j = n - i - 1;
                    s = 0;
                    for (l = 0; l <= i; l++)
                    {
                        k = j + l + 1;
                        s += a[j, k] * r[k];
                    }
                    r[j] = ((a[j, m] - s) / a[j, j]);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void desLUDoolittle(double[,] a, double[] b, int n, double[] x, double tol, TextBox txtResultado)
        {
            double[] o = new double[n + 1];
            double[] s = new double[n + 1];
            int er = 0;
            Decompose(a, n, tol, o, s, er, txtResultado);
            if (er != -1)
                SubstituteLU(a, o, n, b, x);
        }

        private static void Decompose(double[,] a, int n, double tol, double[] o, double[] s, int er, TextBox txtResultado)
        {
            double factor;
            for (int i = 0; i <= n; i++)
            {
                o[i] = i;
                s[i] = Math.Abs(a[i, i]);
                for (int j = 1; j <= n; j++)
                {
                    if (Math.Abs(a[i, j]) < s[i])
                        s[i] = Math.Abs(a[i, j]);
                }
            }

            for (int k = 0; k <= n - 1; k++)
            {
                PivotLU(a, o, s, n, k);
                if (Math.Abs(a[Convert.ToInt32(o[k]), k] / s[Convert.ToInt32(o[k])]) < tol)
                {
                    er = -1;
                    txtResultado.AppendText(Convert.ToString(a[Convert.ToInt32(o[k]), k] / s[Convert.ToInt32(o[k])]));
                    break;
                }
                for (int i = k + 1; i <= n; i++)
                {
                    factor = a[Convert.ToInt32(o[i]), k] / a[Convert.ToInt32(o[k]), k];
                    a[Convert.ToInt32(o[i]), k] = factor;
                    for (int j = k + 1; j <= n; j++)
                    {
                        a[Convert.ToInt32(o[i]), j] -= factor * a[Convert.ToInt32(o[k]), j];
                    }
                }
                if (Math.Abs(a[Convert.ToInt32(o[k]), k] / s[Convert.ToInt32(o[k])]) < tol)
                {
                    er = -1;
                    txtResultado.AppendText(Convert.ToString(a[Convert.ToInt32(o[k]), k] / s[Convert.ToInt32(o[k])]));
                    break;
                }
            }
        }

        private static void PivotLU(double[,] a, double[] o, double[] s, int n, int k)
        {
            int p = k;
            double big = Math.Abs(a[Convert.ToInt32(o[k]), k] / s[Convert.ToInt32(o[k])]), dummy;

            for (int i = k + 1; i <= n; i++)
            {
                dummy = Math.Abs(a[Convert.ToInt32(o[i]), k] / s[Convert.ToInt32(o[i])]);
                if (dummy > big)
                {
                    big = dummy;
                    p = i;
                }
            }
            dummy = o[p];
            o[p] = o[k];
            o[k] = dummy;
        }

        private static void SubstituteLU(double[,] a, double[] o, int n, double[] b, double[] x)
        {
            double sum;
            for (int i = 1; i <= n; i++)
            {
                sum = b[Convert.ToInt32(o[i])];
                for (int j = 0; j <= i - 1; j++)
                {
                    sum -= a[Convert.ToInt32(o[i]), j] * b[Convert.ToInt32(o[j])];
                }
                b[Convert.ToInt32(o[i])] = sum;
            }
            x[n] = b[Convert.ToInt32(o[n])] / a[Convert.ToInt32(o[n]), n];

            for (int i = n - 1; i >= 0; i--)
            {
                sum = 0;
                for (int j = i + 1; j <= n; j++)
                {
                    sum += a[Convert.ToInt32(o[i]), j] * x[j];
                }
                x[i] = (b[Convert.ToInt32(o[i])] - sum) / a[Convert.ToInt32(o[i]), i];
            }
        }

        public static void ThomasLU(double[] f, double[] g, double[] e, double[] r,ref double[] x, int n)
        {
            // Descomposicion
            for (int k = 1; k <= n; k++)
            {
                e[k] /= f[k - 1];
                f[k] -= e[k] * g[k - 1];
            }
            // Sustitucion hacia adelante
            for (int k = 1; k <= n; k++)
            {
                r[k] -= e[k] * r[k - 1];
            }
            //Sustitucion hacia atras
            x[n] = r[n] / f[n];
            for (int k = n-1; k >= 0; k--)
            {
                x[k] = (r[k] - g[k] * x[k + 1]) / f[k];
            }
        }

        //public static void Cholesky(double[,] a, double[] b, int n, double[] x)
        //{
        //    double sum;
        //    double[] o = new double[n + 1];
        //    // Descomcposicion de Cholesky
        //    for (int k = 0; k <= n; k++)
        //    {
        //        for (int i = 0; i <= k-1; i++)
        //        {
        //            sum = 0;
        //            for (int j = 0; j <= i-1; j++)
        //            {
        //                sum += a[i, j] * a[k, j];
        //            }
        //            a[k, i] = (a[k, i] - sum) / a[i, i];
        //        }
        //        sum = 0;
        //        for (int j = 0; j <= k-1; j++)
        //        {
        //            sum += Math.Pow(a[k, j], 2);
        //        }
        //        try
        //        {
        //            a[k, k] = Math.Sqrt(a[k, k] - sum);
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Hubo un error, es posible que la matriz no es definida positiva, el producto {X}^t * A * {X} debe de ser mayor que cero para todo vector {X} distinto de cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }                
        //    }

        //    // Sustitucion
        //    SubstituteLU(a, o, n, b, x);
        //}

       
    }
}

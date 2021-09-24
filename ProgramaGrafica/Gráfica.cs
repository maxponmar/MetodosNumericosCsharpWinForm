using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace raizesMN
{
    public partial class formGrafica : Form
    {
        private float zoom = 1f;

        public int Indice { get; set; } = 0; // 0-raices 1-interpolacion 2-interpolacion splines 3.-integracion 4.-Optimizacion 5.-Fourier
        public double[,] xy { get; set; }
        public double a { get; set; }
        public double b { get; set; }
        public double[] datoXY { get; set; }
        public int n { get; set; }

        private string[] splines;
        private int nsplines;

        private int sizeX, sizeY;
        private double minX = -10, maxX = 10;
        private double minY = -10, maxY = 10;

        private Point currentPoint = new Point();
        private Point previousPoint = new Point();
        private bool isCurentPoint = false;
        private bool isPreviousPoint = false;
        private MathParser miFuncion = new MathParser();
        private Graphics g;

        public formGrafica()
        {
            InitializeComponent();
        }      

        // Graficar funcion
        private void Tamaños()
        {
            sizeX = panel1.Size.Width;
            sizeY = panel1.Size.Height;

            minX = Convert.ToDouble(txtXmin.Text);
            maxX = Convert.ToDouble(txtXmax.Text);
            minY = Convert.ToDouble(txtYmin.Text);
            maxY = Convert.ToDouble(txtYmax.Text);

            g = panelGrafica.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.ScaleTransform(zoom, zoom);

            currentPoint = new Point();
            previousPoint = new Point();
            isCurentPoint = false;
            isPreviousPoint = false;
        }

        private void GraficarFuncion0(string funcion, Color funcionColor) // Graficador de raices
        {
            try
            {
                Tamaños();

                for (double x = minX; x < maxX; x += (maxX - minX) / sizeX)
                {

                    decimal x1 = decimal.Parse(x.ToString(), System.Globalization.NumberStyles.Any);

                    miFuncion.ProgrammaticallyParse("let x = " + x1.ToString());
                    double y = Convert.ToDouble(miFuncion.Parse(funcion));

                    if (Math.Abs(y) > maxY * 2) isCurentPoint = false;
                    else
                    {
                        isCurentPoint = true;
                    }
                    if (isCurentPoint)
                    {
                        currentPoint.X = (int)(x / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX));
                        currentPoint.Y = (int)(sizeY - (y / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)));
                        if (isPreviousPoint)
                        {
                            g.DrawLine(new Pen(funcionColor, 2), previousPoint, currentPoint);
                        }
                        if ((y < 0.000001 && y > -0.000001) || y == 0) g.DrawLine(new Pen(Color.DarkViolet, 5), previousPoint, currentPoint);
                    }
                    previousPoint = currentPoint;
                    isPreviousPoint = isCurentPoint;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado, es posible que la función no este bien escrita o que sea demasiado compleja para el programa. \r\nEn ese caso utiliza otro programa para graficar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                     
        }

        private void GraficarFuncion1(string funcion, Color funcionColor, double[,] xy) // Graficador de interpolacion
        {
            try
            {
                Tamaños();

                for (double x = minX; x < maxX; x += (maxX - minX) / sizeX)
                {

                    decimal x1 = decimal.Parse(x.ToString(), System.Globalization.NumberStyles.Any);

                    miFuncion.ProgrammaticallyParse("let x = " + x1.ToString());
                    double y = Convert.ToDouble(miFuncion.Parse(funcion));

                    if (Math.Abs(y) > maxY * 2) isCurentPoint = false;
                    else
                    {
                        isCurentPoint = true;
                    }
                    if (isCurentPoint)
                    {
                        currentPoint.X = (int)(x / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX));
                        currentPoint.Y = (int)(sizeY - (y / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)));
                        if (isPreviousPoint)
                        {
                            g.DrawLine(new Pen(funcionColor, 2), previousPoint, currentPoint);
                        }
                    }
                    previousPoint = currentPoint;
                    isPreviousPoint = isCurentPoint;
                }
                Size miS = new Size(3, 3);
                for (int i = 0; i < n; i++)
                {
                    currentPoint.X = (int)(xy[0, i] / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX) - 0.6);
                    currentPoint.Y = (int)(sizeY - (xy[1, i] / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)) - 0.6);
                    g.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(currentPoint, miS));
                }
                currentPoint.X = (int)(datoXY[0] / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX) - 0.6);
                currentPoint.Y = (int)(sizeY - (datoXY[1] / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)) - 0.6);
                g.DrawEllipse(new Pen(Color.Green, 2), new Rectangle(currentPoint, miS));
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado, es posible que la función no este bien escrita o que sea demasiado compleja para el programa. \r\nEn ese caso utiliza otro programa para graficar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void GraficarSplines(string[] splines, Color funcionColor, double[,] xy, int nsplines)
        {
            try
            {
                Tamaños();
                for (int j = 0; j < nsplines; j++)
                {
                    for (double x = xy[0, j]; x < xy[0, j + 1]; x += (xy[0, j + 1] - xy[0, j]) / sizeX)
                    {

                        decimal x1 = decimal.Parse(x.ToString(), System.Globalization.NumberStyles.Any);

                        miFuncion.ProgrammaticallyParse("let x = " + x1.ToString());
                        double y = Convert.ToDouble(miFuncion.Parse(splines[j]));

                        if (Math.Abs(y) > maxY * 2) isCurentPoint = false;
                        else
                        {
                            isCurentPoint = true;
                        }
                        if (isCurentPoint)
                        {
                            currentPoint.X = (int)(x / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX));
                            currentPoint.Y = (int)(sizeY - (y / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)));
                            if (isPreviousPoint)
                            {
                                g.DrawLine(new Pen(funcionColor, 2), previousPoint, currentPoint);
                            }
                        }
                        previousPoint = currentPoint;
                        isPreviousPoint = isCurentPoint;
                    }
                    Size miS = new Size(3, 3);
                    for (int i = 0; i < n; i++)
                    {
                        currentPoint.X = (int)(xy[0, i] / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX) - 0.6);
                        currentPoint.Y = (int)(sizeY - (xy[1, i] / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)) - 0.6);
                        g.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(currentPoint, miS));
                    }
                    currentPoint.X = (int)(datoXY[0] / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX) - 0.6);
                    currentPoint.Y = (int)(sizeY - (datoXY[1] / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)) - 0.6);
                    g.DrawEllipse(new Pen(Color.Green, 2), new Rectangle(currentPoint, miS));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado, es posible que la función no este bien escrita o que sea demasiado compleja para el programa. \r\nEn ese caso utiliza otro programa para graficar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GraficarIntegracion(string funcion, Color funcionColor, double a, double b)
        {
            try
            {
                Tamaños();
                for (double x = minX; x < maxX; x += (maxX - minX) / sizeX)
                {
                    decimal x1 = decimal.Parse(x.ToString(), System.Globalization.NumberStyles.Any);
                    miFuncion.ProgrammaticallyParse("let x = " + x1.ToString());
                    double y = Convert.ToDouble(miFuncion.Parse(funcion));
                    if (Math.Abs(y) > maxY * 2) isCurentPoint = false;
                    else
                    {
                        isCurentPoint = true;
                    }
                    if (isCurentPoint)
                    {
                        currentPoint.X = (int)(x / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / sizeX));
                        currentPoint.Y = (int)(sizeY - (y / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / sizeY)));
                        if (isPreviousPoint)
                        {
                            g.DrawLine(new Pen(funcionColor, 2), previousPoint, currentPoint);
                        }
                    }
                    previousPoint = currentPoint;
                    isPreviousPoint = isCurentPoint;
                }

                int nPuntos = 0;
                for (double i = a; i <= b; i += 0.1)
                {
                    nPuntos++;
                }

                Point[] puntosArea = new Point[nPuntos + 2];
                // Linea en el eje x
                puntosArea[0].X = (int)(b / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / sizeX));
                miFuncion.ProgrammaticallyParse("let x = " + b.ToString());
                puntosArea[0].Y = (int)(sizeY - (0 / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / sizeY)));

                puntosArea[1].X = (int)(a / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / sizeX));
                miFuncion.ProgrammaticallyParse("let x = " + a.ToString());
                puntosArea[1].Y = (int)(sizeY - (0 / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / sizeY)));

                puntosArea[2].X = (int)(a / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / sizeX));
                miFuncion.ProgrammaticallyParse("let x = " + a.ToString());
                puntosArea[2].Y = (int)(sizeY - (Convert.ToDouble(miFuncion.Parse(funcion)) / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / sizeY)));

                int cont = 0;
                for (double x = a; x <= b; x += 0.1)
                {
                    decimal x1 = decimal.Parse(x.ToString(), System.Globalization.NumberStyles.Any);
                    miFuncion.ProgrammaticallyParse("let x = " + x1.ToString());
                    double y = Convert.ToDouble(miFuncion.Parse(funcion));
                    currentPoint.X = (int)(x / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / sizeX));
                    currentPoint.Y = (int)(sizeY - (y / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / sizeY)));
                    puntosArea[cont + 2] = currentPoint;
                    cont++;
                }
                puntosArea[nPuntos + 1].X = (int)(b / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / sizeX));
                miFuncion.ProgrammaticallyParse("let x = " + b.ToString());
                puntosArea[nPuntos + 1].Y = (int)(sizeY - (Convert.ToDouble(miFuncion.Parse(funcion)) / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / sizeY)));

                g.FillPolygon(Brushes.Green, puntosArea);
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado, es posible que la función no este bien escrita o que sea demasiado compleja para el programa. \r\nEn ese caso utiliza otro programa para graficar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void GraficarOptimo(string funcion, Color funcionColor, double a, double b)
        {
            try
            {
                Tamaños();

                for (double x = minX; x < maxX; x += (maxX - minX) / sizeX)
                {

                    decimal x1 = decimal.Parse(x.ToString(), System.Globalization.NumberStyles.Any);

                    miFuncion.ProgrammaticallyParse("let x = " + x1.ToString());
                    double y = Convert.ToDouble(miFuncion.Parse(funcion));

                    if (Math.Abs(y) > maxY * 2) isCurentPoint = false;
                    else
                    {
                        isCurentPoint = true;
                    }
                    if (isCurentPoint)
                    {
                        currentPoint.X = (int)(x / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX));
                        currentPoint.Y = (int)(sizeY - (y / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)));
                        if (isPreviousPoint)
                        {
                            g.DrawLine(new Pen(funcionColor, 2), previousPoint, currentPoint);
                        }
                    }
                    previousPoint = currentPoint;
                    isPreviousPoint = isCurentPoint;
                }
                Size miS = new Size(3, 3);
                Point optimo = new Point();
                optimo.X = (int)(a / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX));
                optimo.Y = (int)(sizeY - (b / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)));
                g.DrawEllipse(new Pen(Color.Green, 2), new Rectangle(optimo, miS));
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado, es posible que la función no este bien escrita o que sea demasiado compleja para el programa. \r\nEn ese caso utiliza otro programa para graficar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void GraficarPuntos()
        {
            try
            {
                Tamaños();
                Size miS = new Size(3, 3);
                for (int i = 0; i < n; i++)
                {
                    currentPoint.X = (int)(xy[0, i] / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX) - 0.6);
                    currentPoint.Y = (int)(sizeY - (xy[1, i] / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)) - 0.6);
                    g.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(currentPoint, miS));
                }               
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelGrafica_Paint(object sender, PaintEventArgs e)
        {
            dibujarFondo();
            for (int i = 0; i < lbxFunciones.Items.Count; i++)
            {
                CColorFuncion fc = lbxFunciones.Items[i] as CColorFuncion;
                comprobarIndice(fc);
            }
        }

        // Dibujar fondo, se usa en todos 
        private void dibujarFondo()
        {
            int sizeX = panel1.Size.Width;
            int sizeY = panel1.Size.Height;
            double minX = -10, maxX = 10;
            double minY = -10, maxY = 10;

            minX = Convert.ToDouble(txtXmin.Text);
            maxX = Convert.ToDouble(txtXmax.Text);
            minY = Convert.ToDouble(txtYmin.Text);
            maxY = Convert.ToDouble(txtYmax.Text);

            Graphics g = panelGrafica.CreateGraphics();
            g.ScaleTransform(zoom, zoom);
            g.Clear(Color.White);

            for (int i = 0; i < sizeX; i += 20)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(i, 0), new Point(i, sizeY));
            }
            for (int i = 0; i < sizeY; i += 20)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(0, i), new Point(sizeX, i));
            }
            g.DrawLine(new Pen(Color.Black), new Point(0, sizeY / 2), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 - 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 + 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black), new Point(sizeX / 2, 0), new Point(sizeX / 2, sizeY));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 - 10, 0 + 10), new Point(sizeX / 2, 0));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 + 10, 0 + 10), new Point(sizeX / 2, 0));

            for (int i = 40; i < sizeX; i += 40)
            {
                if (i == sizeX / 2) continue;
                string st = (minX + i * ((maxX - minX) / sizeX)).ToString();
                g.DrawLine(new Pen(Color.Black, 2), new Point(i, sizeY / 2 + 5), new Point(i, sizeY / 2 - 5));
                g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(i - 15, sizeY / 2 + 4));
            }
            for (int i = 40; i < sizeY; i += 40)
            {
                if (i == sizeY / 2) continue;
                string st = (minX + (sizeY - i) * ((maxY - minY) / sizeY)).ToString();
                g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 + 5, i), new Point(sizeX / 2 - 5, i));
                g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(sizeX / 2 - 15, i + 4));
            }
            string point = "(" + (minX + (maxX - minX) / 2) + "; " + (minX + (maxY - minY) / 2) + ")";
            g.DrawString(point, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(sizeX / 2 - 15, sizeY / 2 + 4));
        }

        // Botones 
        public void btnAñadir_Click(object sender, EventArgs e)
        {
            CColorFuncion fc = new CColorFuncion("", Color.Black);
            formFuncion formAñadirFuncion = new formFuncion(fc);
            if (formAñadirFuncion.ShowDialog() == DialogResult.OK)
            {
                lbxFunciones.Items.Add(fc);
                comprobarIndice(fc);
            }
        }

        //Se usa en todos
        public void btnAñadir_Click(string funcion, Color color) // raices e interpolacion
        {
            CColorFuncion fc = new CColorFuncion(funcion, color);
            formFuncion formAñadirFuncion = new formFuncion(fc);
            lbxFunciones.Items.Add(fc);           
        }

        public void btnAñadir_Click(string[] splines, Color color, int nsplines) // Para splines
        {
            for (int i = 0; i < nsplines; i++)
            {
                CColorFuncion fs = new CColorFuncion(splines[i], color);
                formFuncion formAñadirFuncion = new formFuncion(fs);
                lbxFunciones.Items.Add(fs);
            }
            this.splines = splines; this.nsplines = nsplines;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lbxFunciones.SelectedItem == null) return;
            formFuncion formFunction = new formFuncion(lbxFunciones.SelectedItem as CColorFuncion);

            if (formFunction.ShowDialog() == DialogResult.OK)
            {
                lbxFunciones.Items.Remove(lbxFunciones.SelectedItem);
                lbxFunciones.Items.Add(formFunction.Fc);

                dibujarFondo();
                for (int i = 0; i < lbxFunciones.Items.Count; i++)
                {
                    CColorFuncion fc = lbxFunciones.Items[i] as CColorFuncion;
                    comprobarIndice(fc);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbxFunciones.SelectedItem == null) return;

            lbxFunciones.Items.Remove(lbxFunciones.SelectedItem);

            dibujarFondo();
            for (int i = 0; i < lbxFunciones.Items.Count; i++)
            {
                CColorFuncion fc = lbxFunciones.Items[i] as CColorFuncion;
                comprobarIndice(fc);
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //xy = new double[2, 1];
            MessageBox.Show("Es recomendable manter una relación entre los valores mínimos y máximos de los ejes X y Y para que la gráfica se mire mejor, ya que puede causar una confusión con los valores de los ejes.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //xy[0, 0] = 1; xy[1, 0] = 5;
            //n = 1;
            //GraficarPuntos(xy);
        }

        public void btnActualizar_Click(object sender, EventArgs e)
        {
            dibujarFondo();
            for (int i = 0; i < lbxFunciones.Items.Count; i++)
            {
                CColorFuncion fc = lbxFunciones.Items[i] as CColorFuncion;
                comprobarIndice(fc);
            }
        }

        // Se usa en todos
        private void tbrZoomX_Scroll(object sender, EventArgs e)
        {
            zoom = tbrZoomX.Value / 100f;
            panelGrafica.Invalidate();
        }

        // codigo repetido
        public void comprobarIndice(CColorFuncion fc)
        {
            switch (Indice)
            {
                case 0:
                    GraficarFuncion0(fc.Funcion, fc.Color);
                    break;

                case 1:
                    GraficarFuncion1(fc.Funcion, fc.Color, xy);
                    break;

                case 2:
                    GraficarSplines(splines, fc.Color, xy, nsplines);
                    break;

                case 3:
                    GraficarIntegracion(fc.Funcion, fc.Color, a, b);
                    break;

                case 4:
                    GraficarOptimo(fc.Funcion, fc.Color, a, b);
                    break;
                case 5:
                    GraficarPuntos();
                    GraficarFuncion0(fc.Funcion, fc.Color);
                    break;
            }           
        }
    }
}

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace raizesMN
{
    class CTabular
    {
        private MathParser convEqn = new MathParser();
        private string funcion;

        // Método para evaluar funcion en diferentes puntos y encontrar donde esta la raíz                          
        public void MuestraTabla(RichTextBox rtxTablaFx, TextBox txtX1, TextBox txtX2, TextBox txtFuncion, TextBox txtV1, TextBox txtV2, Label lblFuncion, TextBox txtPaso)
        {                        // ecuacion a evaluar, rtxtbx para mostrar tabla, txtbx para valor 1, txtbx para valor 2, limite inf, limite sup
            int a, b;
            if (string.IsNullOrEmpty(txtFuncion.Text))
            {
                MessageBox.Show("Introduce la función"); lblFuncion.Visible = false;
            }
            else
            {
                try
                {
                    rtxTablaFx.Clear();
                    funcion = txtFuncion.Text; lblFuncion.Text = funcion; lblFuncion.Visible = true;
                    a = Convert.ToInt32(txtV1.Text);
                    b = Convert.ToInt32(txtV2.Text);
                    if (a > b)
                    {
                        a = Convert.ToInt32(txtV2.Text);
                        b = Convert.ToInt32(txtV1.Text);
                        MessageBox.Show("El límite inferior debe de ser menor al límite superior");
                    }

                    // Invocar método para imprimir la tabla y obtener el rango donde se encuentra la raiz
                    EvaluarFx(funcion, rtxTablaFx, txtX1, txtX2, a, b,txtPaso);
                }
                catch (Exception)
                {
                    MessageBox.Show("La función no esta en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFuncion.Visible = false;
                }
            }
        }

        private void EvaluarFx(string funcion, RichTextBox rtxTablaFx, TextBox txtX1, TextBox txtX2,int lim1, int lim2, TextBox txtPaso)
        {
            double resultadoTemp1, resultadoTemp2, paso = 1; int cont = 0, index = 0, cont2 = 0; string temp;
            if (string.IsNullOrEmpty(txtPaso.Text))
            {
                MessageBox.Show("Es necesario introducir el paso", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPaso.Text = "1";
            }
            else
            {
                try
                {
                    paso = Convert.ToDouble(txtPaso.Text);
                    if (paso == 0) { MessageBox.Show("El paso no puede ser 0", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); paso = 1; txtPaso.Text = "1"; }

                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error, verifica que el paso este bien establecido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
            }
            
            for (double i = lim1; i <= lim2; i+=paso)
            {
                convEqn.ProgrammaticallyParse("let x =" + i.ToString());         // Asignar i a x                       
                resultadoTemp1 = convEqn.Parse(funcion);                             // Evaluar funcion en x
                convEqn.ProgrammaticallyParse("let x =" + (i + 1).ToString());   // Aisgnar i+1 a x para usar este valor para encontrar cambio de signo
                resultadoTemp2 = convEqn.Parse(funcion);
                // Imprimir la tabla en txtbox, si hay un valor =0 entonces se pone de color rojo y al final sale un mensaje
                if (resultadoTemp1 == 0)
                {
                    temp = "f(" + i.ToString() + ") = " + resultadoTemp1.ToString() + " *Raíz";
                    rtxTablaFx.AppendText(temp + "\r\n");
                    rtxTablaFx.Select(rtxTablaFx.GetFirstCharIndexFromLine(index), temp.Length);
                    rtxTablaFx.SelectionColor = Color.Red; rtxTablaFx.SelectionFont = new Font("Arial", 11, FontStyle.Bold);
                    cont = 1;
                }
                else
                {
                    rtxTablaFx.AppendText("f(" + i.ToString() + ") = " + resultadoTemp1.ToString() + "\r\n");
                }

                if ((resultadoTemp1 < 0 && resultadoTemp2 > 0) || (resultadoTemp1 > 0 && resultadoTemp2 < 0)) // Aqui se encuentra el cambio de signo
                {
                    txtX1.Text = i.ToString();
                    txtX2.Text = (i + 1).ToString();
                    cont2 = 1;
                }
                index++;
            }
            if (cont == 1)
            {
                cont2 = 1;
                MessageBox.Show("- Existe un valor para el cual fx=0, por lo tanto no necesitas usar métodos númericos para encontrar la raíz \n" +
                    "- Las raízes estan señaladas con color rojo en la tabla \n"+                   
                    "- Si la raíz que deseas encontrar esta en otro punto, específca el rango para tabular o si ya conoces en que rango se encuntra la raíz, especificalo en x1 y x2", "Alerta", MessageBoxButtons
                    .OK, MessageBoxIcon.Exclamation); // Si es 0, significa que esa es la raíz 
            }
            if (cont2 == 0)
            {
                MessageBox.Show("No se ha encontrado el rango en el que se encuentra la raíz, por favor establece un rango de evaluación de la función adecuado para encontrarlo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Activar o desactivar rango de evaluacion
        public void establecerRango(CheckBox cbxTabla, TextBox txtV1, TextBox txtV2)
        {
            if (cbxTabla.Checked == true)
            {
                txtV1.Enabled = true;
                txtV2.Enabled = true;
            }
            else
            {
                txtV1.Enabled = false;
                txtV2.Enabled = false;
            }
        }
    }
}

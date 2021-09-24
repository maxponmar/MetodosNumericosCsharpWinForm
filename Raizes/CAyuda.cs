//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace raizesMN
{
    class CAyuda
    {       
        public static void mostrarMensaje(string mensaje, string encabezado)
        {
            MessageBox.Show(mensaje, encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }       
    }
}

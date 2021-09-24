using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Drawing;

namespace raizesMN
{
    public class CColorFuncion
    {
        private string funcion;
        private Color color;

        public String Funcion { get { return funcion; } set {funcion = value; } }
        public Color Color { get { return color; } set { color = value; } }

        public CColorFuncion(string funcion, Color color)
        {
            this.funcion = funcion;
            this.color = color;
        }

        public override string ToString()
        {
            return funcion;
        }
    }
}

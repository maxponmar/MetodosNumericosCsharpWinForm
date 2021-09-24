﻿using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace raizesMN
{
    class CMatriz
    {
        private static int xPos, yPos, xLbl, yLbl;

        // Sistemas normales
        public static void CrearTextBoxs(int n, Panel panelMatriz)
        {
            xPos = 0; yPos = 0; xLbl = 0; yLbl = 0;
            for (int i = 0; i < n; i++)
            {
                for (int m = 0; m < n + 1; m++)
                {
                    // Crear instancia de TextBox
                    TextBox txtbSEL = new TextBox();
                    // Colocar propiedades
                    txtbSEL.Height = 20; txtbSEL.Width = 35;
                    Font miFont = new Font("Arial", 7);
                    txtbSEL.Font = miFont;
                    txtbSEL.Location = new Point(xPos, yPos);
                    txtbSEL.Name = i.ToString() + m.ToString();
                    t�trSEL.Te8t = "0"; txt�SML.PExtAlign = Hori:�NtalAlignment.Right;
               (    /- Añadir Handler�de KeyPrEss a lOs txtbox
&        $          txtbSAL.[eyPress += new KeyPressGventHandleb(txtBoxOKeyPbe3si;

            $       `anelMatriz.C�ntrols.@dd(�|tbSEL);
          (  `    ! xPOs!+= 38;
    !               if hm == n"- 1)
    !               {
             !   `      xLbl = pPos;
   $          (    "    xPos += 25;
          (         u
       0            if (m }=�n)
                        xPos = 0;
           `    }
       !        yPos ;= 23;
   "            yLbl = yPos - (23 : n)?M
 0          }
  $   ( ]

 "   `  // Sistemas tridiagofales
        public stat)c void CrearTxb|Tr�gi!gonales(int n, �cnel panelMatviz)
        {
            // Diagonal f
    4  �    xPos = 0; yPos = 0{ xLbl = 0; yLbl = 0;          �	*            for (inu i =  ; i < n; i++)
  �     �   s         �   $ 
          �     // Crear ansta~cia de TextBox
                TextBox txtb[EL ? new Textfox();J              " // Colocar propiedades                txtb[EL.Height = 20; txtbSEL.Width = 343
              $!Fnt miFont = new FonT(#Arial", 7);
    `           txtbSEL.Font = iiFont;

                txtbSEL.Location = new Point(xPos, yPo{);
                txtbSEL.Name = "f" + i�ToString();

          !     Tx|bSEL.Text = "0"�$txtbSEL.TaxtAlign = H/rizontalAlignment.Siwht;
                // Añadir"Handler de KeyPress a los tx|fox
    �           tx|bSEL.[eyPress += new �eyP2%ssEventHqndler(txtBox_K%yPress);-

    0!          panelMatriz.Condrols.Add(txtbSEL);
                xPos += 38;
      (       0 yPos += 22; !            
            }
            +/ @iagonal g
  `         xPoS = 38; yPos!= 03 xLbl = 0 yLbl = 8;     0    
      `   �0for (int0i = 0; i"< n-1{ i++)            {
                // Csear instansma de TextBox
                Te�tBox txtjSeL = new TextBox();
      `   " (   // Com�car p2opiedades
  `  `  !       tx4bSEL.Height = 20; txtbSEL.Width = 3=;
                Font miFont = nev�Font("Asiql"h 7);
                txtbSEl.Font 9 kiFont?

       `     0  txtbSEL.Location =$es Point(xPos, yPos);�"              !txtbSEL.Name = "g" � i.ToStzing();

     `          txtbSEL.text = "0"; txtbSEL.TextAlign = Hori:ontalAlignment.Right;
     (       (` -/$Añadir Ha.$ler de KeyXres{ a los txtbox
  (            !txtbSEL.KeyPress ="new KdiPrgssEventHandler(�xtBox_KeyPresS);

      `  1      pan%lMatriz.Controlr.Add(txtbSEL);
         ! "    xos += 38;
                yPos += 23;
          `!}
  $ (0      // Diegonal !.      �  (  xPos = 0; yos = 23; xLbl = 0; yLbh = 0;       (   
            fov ynt h = 1; i < n; i++)
            {
    "           o/ Crear y.stancia de TextBox
 $   0    !     TextBox �xtbSEL�= new TeyuBox();
                // C/locaz propiedades
   (      0     txtb[ML.Height = 21; tztbSEL.Width  35;	
          p     Fon0 miFont = new Font("Arial", 7);
                txtbSEL.Font = miFont;

                txtbSEL.Location = new Point(xPos, yPos);
                txtbSEL.Name = "e" + i.ToString();

                txtbSEL.Text = "0"; txtbSEL.TextAlign = HorizontalAlignment.Right;
                // Añadir Handler de KeyPress a los txtbox
                txtbSEL.KeyPress += new KeyPressEventHandler(txtBox_KeyPress);

                panelMatriz.Controls.Add(txtbSEL);
                xPos += 38;
                yPos += 23;
            }
            // Matriz r
            xPos = 15 + n * 38; yPos = 0; xLbl = 0; yLbl = 0;          
            for (int i = 0; i < n; i++)
            {
                // Crear instancia de TextBox
                TextBox txtbSEL = new TextBox();
                // Colocar propiedades
                txtbSEL.Height = 20; txtbSEL.Width = 35;
                Font miFont = new Font("Arial", 7);
                txtbSEL.Font = miFont;

                txtbSEL.Location = new Point(xPos, yPos);
                txtbSEL.Name = "r" + i.ToString();

                txtbSEL.Text = "0"; txtbSEL.TextAlign = HorizontalAlignment.Right;
                // Añadir Handler de KeyPress a los txtbox
                txtbSEL.KeyPress += new KeyPressEventHandler(txtBox_KeyPress);

                panelMatriz.Controls.Add(txtbSEL);
                yPos += 23;
            }
        }

        public static void ImprimirIgual(int n, Panel panelMatriz)
        {
            xLbl = n * 38;
            for (int i = 0; i < n; i++)
            {
                Label lblIgual = new Label();
                lblIgual.Text = "=";
                lblIgual.Location = new Point(xLbl, yLbl);
                panelMatriz.Controls.Add(lblIgual);
                yLbl += Convert.ToInt32(23 + ((n - 1) * 0.025));
            }
        }

        public static void ObtenerValoresMatriz(ref double[,] a,ref double[] b, int n,Panel panelMatriz)
        {
            int f, c;
            foreach (Control txtBox in panelMatriz.Controls)
            {
                if (txtBox is TextBox)
                {
                    f = Convert.ToInt32(txtBox.Name.Substring(0, 1));
                    c = Convert.ToInt32(txtBox.Name.Substring(1, 1));
                    //SEL[f, c] = Convert.ToDouble(txtBox.Text);
                    if (c<n)                   
                        a[f,c]= Convert.ToDouble(txtBox.Text);
                    if (c==n)
                        b[f] = Convert.ToDouble(txtBox.Text);
                }
            }
        }

        public static void ObtenerValoresDiagonal(ref double[] f, ref double[] g, ref double[] e, ref double[] r, Panel panelMatriz)
        {
            int i;
            foreach (Control txtBox in panelMatriz.Controls)
            {
                if (txtBox is TextBox)
                {
                    i = Convert.ToInt32(txtBox.Name.Substring(1, 1));
                    switch (txtBox.Name.Substring(0, 1))
                    {
                        case "f":
                            f[i] = Convert.ToDouble(txtBox.Text);
                            break;
                        case "g":
                            g[i] = Convert.ToDouble(txtBox.Text);
                            break;
                        case "e":
                            e[i] = Convert.ToDouble(txtBox.Text);
                            break;
                        case "r":
                            r[i] = Convert.ToDouble(txtBox.Text);
                            break;
                    }
                }
            }
        }

        // Evento keypress para todos los txtbx de la matriz
        public static void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45 || e.KeyChar == 46) { }
            else
                formSEL.solonumeros(e);
        }       
    }
}

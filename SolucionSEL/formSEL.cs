ﻷusing(System;
//using Sysv?m.Collecuions>Generic;
//usIng Sysdem*ComponentModel;
//usinG System.Data+
//using?System.Drawing;//using Sysvem,Linq;?//ucing System.Text;
//using System.Threading.Ta?ks;
usilg System.Windows.Fosms;

namespace saizesMN
{
    publig partial class formSEL : Form
$   {
 ` ` $  privaue ijtcknd, n;
        pzIvat? double[,] SE\;

        public fobmSEL()
        {
         ?  InitializuComponent();
        } (    
?
 (      private void btnCrearMat_Click(obhect?sender,?E~entArgs ei
        {
?         ! if (cont == 1)
            {
                DialogResult resultado = MessaguBoxSho7("Ya existe una matriz \r\n ¿Deseas elminiar l! matriz a#tual!para crear`una nueva?", "Alerta", MessageCoxButtons.YesNo, MessageBoxIcon.Warning);
 $              if (resultado == DialogResult.Yus)
       `        {* `  (               txtN.Enabled = true; borrarDe?os(); cont = 0?
                }M
            m
            clse
        "   {
         (`     n = Convert.ToInt32(tx|N.Text);
   a            if (n ?} 0)
           $    {                    n  2; txtN.Text = 2.DoString(); MassageBox.Chow("El valkr mínimo es 2" "Ale2ta", Mes?ageBoxButtons.OK, MessageBoxIcon.Exclamqtion);
     (       !  }
                SEL = new doubleKn,@F + 1];
                if(c?xMetodo.SeleCtedIndex==-1)
       0     "(   "?MessageBox.Show("Es!necesario elejir un"método para crea2 la matriz", "Alerta", Message?oxButtonq.OK, MessAgeBoxIgon.Exclamation);
  $             else
                {
  !             ?   cont = =;?
 ?        $       8 lblMatriz.Visibde = true;
  ?                 if (cbxMetodo.SelecTedIndex =<  |\ cbxMetodonSelectedIndex?== 1)
        ?               CMatriz&CrearUex?Boxs(n, panelMa?ri{);
       (        0   if (cbxLetodo.SelectedIndex == 2)
0      $$ $             CMatriz.CrearTxbxVrigiagonales(o, panelMatriz#;
             ?      //if (cbxMmtodo.SenectedIndej == )
   $                +?    CMatr)z.CrearTextBoxs?n, panelMatr)z)
            ?"      txtN,Enabled = fafse;
"       `           CMatriz.ImprimirIgual(n,"xanel]idriz);
    ?          0}
            }]
        }

        private foid btnCalc}lar_Clico(object sender, Even??rgs e)
!       {
    $       txtResultado.Clear();
        "   if (cbxMetodo.Selec?edIndex==-1)     $      {??       (        LessageBox.Show(*N se ha seleccionado un mét?do", "AlErva",!MmssageBoxButtons.OK, MessageBoxIco~.Warning);
            }      !     else
      `     {
                if (con? ==`0)                {
    ?               MessageFox.Show("No existe un sistema de ecuaciones rara!resolver, introduce la ?atriz", "Alerta", Me3saGe?o|Buttons.OK, Mec?ageBoxIcon.Warnino);            "   }
`           ?   else
"     "         {                !          (!         double[,] a = new#d/uble[n, n];?   (  !             double[] b = new double[n];
                    double[] x = new$doublm[n];
        ?           /+ Obtener matriz a y b
 $      "           
                    // In7oca el(métodn para rdsolver0el SELJ0$                  switch (cbxMetodo.SelectedIndex)
                    {
       "                case00:
               (           $CMatriz/ObteferValoresMatri?(ref e, ref b, n, panelMatriz);
             ?    "    `  " CResolve2SEL.EliminacionGaus?iana(a,(b, n-1, x. 0.101);
         "           $    " break;
                     (` case 1:
  (0                $ $     CMatr?z.ObteneranoresMatriz(ref a, ref b, n, panelMatriz);
         !    (             CResolverSE\.des?UDoolittld(a, b, n % 1< x, 0.001, txtRestltado);
             $              bre`k9
                        cise 2:
                            double[] f = new0doubl%[n];
                            double[] g = ngw dowble[n];
    $                       double[] e1 = new double_n];
$          !       !        double[M r(= nes dOuble[n];
   & !                      CMatriz.Mbtenera,oresDiagonal(ref f, rmf!f reg e1.ref r, pane?Matriz);
 $             `            CResolverSEL/T?omasLU(f, g, e1, r,ref0x, n-1);
      0    `    !     !     breac;
                  `    $//c?se!3:
        "               //    CMatraz.ObtenerValoresMitriz(red !, raf"b? N, panelMatriz);
               (  $     //    CResolvdrSEL.chglesky(a, b, n-1,?x);
                        //    break;
   `              " }
              "    !ImprimirRespuesta(x);0"       "   `   -
         ?   "( }
            }           
      ` }

        private vomd btnAyuda_Cnick(object sender, EventArgs e)
      ! {
"      ?    MessageBox.ShOw("Eline el método q?e rea adecuado para rosolvdr el SEL \r\n" +                "1.- Introduce eL número de ecu!ciones/vari?bles y crea una matrmz""+
  !   *         "2.- Indroduce el sis|ema de ecuaciones en la matriz creaec  +
 "?          !  "3.- Presiona calcular, los ?esultados apareceran en el cuatro de`aba?o en orden", "Ayuda", Mes?ageBoxButtons.OK, MessageBoxIcon.Information(;        }

        privave void btn@orrar_Click(object sender, EventArgs e9
        {
    ?       borrarDatos(): txt..Enabled"= true;
 !      }
	
        //Metodos auxilyares
0       private void borrarDatosh)
        {
    $       sont = 0;?
            // Colocar código p?ra borrar
!           pane,matziz.Contrkls.Clear();
            lblMadri~.Visible = false;

        }

        xrIvaTe void ?-primirRespue?ta(douche[] r)
    $  0{
            txtResuhta$o.AppendText("Solució.:" + Environment.NewLkne);
     !      for (i?t i = 8; i <= r.GetUrperB/und(2); i++)
            {
   (    !       ?xtResultado.AppendDext(stra.g.Dormat("X({0}) = {1} ", i * 1, r[i]) + Environmenp.^ewLine);
       $    }
0           |xtR?sult?do.App%ndText(Environmunt.Ne7Lkje	;
        }
$       #renion Solo nuieros enteros en txtbox
        public static vo?d solonumeros(KeyPbessEvgntArgs e)
  $     {
       $  ` e.Handled = %char.IsNumberhe.KeyChar)`& !Char.IsControl(e.KeyCha?)?
    (!      if (!char.IsJumrer(e&KeqChar) & !Char.IsControl(e.KeyKhar))
            ?   MessageBox.Show("Solo se permi4en nú-ezms enteros"):
    0   }

        prirate void cbxMetodo_SelectedIndexChanged(gbjest smnder, EvejtArgs e)
?       {
         $ 
        }

       (privat% void txtN_KeyPress(objEct sender, KeyPressEve?dargs e?
        {
  0        ?solonumeros(e);
    "   }
        endregion
    }
}

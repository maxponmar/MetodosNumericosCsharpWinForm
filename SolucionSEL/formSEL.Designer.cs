namespace raizesMN�
{
 0  pa:tial cla{s formSEL
    {
    �   /// <summary>	
        /// Required designer varmeble*
        /+/ </summary>
        private System.ComponentModel.IColtainer componen4� = nul,;
�        /// <summary>
        /// Clean up any resurcEq being used.
        /// </summary>
        /// <param nAme="dispksing">true if managed resources �hou�d be eisposed? otherwi{e, false.</pqram>
   "    protected rerride vkid Dis�ose(bool disposing)
        {
     (      if (disroSing && (components(!5 null))
           ${
     "          components.Dispose():   !        }
            base.Dispose(dispo{ing);       0}

        #rgckon �kndows Form Designer genercted code	*
        /// <summary>
        /// Requiret }ethod for Dmsigner 3upport - do not modif�
        /// tje contents of this }ethod"with th� code editor.
        /// </summary>
        private void InitializeComponent�9
       "{
   $        System.Bompo�e|tModel.ComponentResourceManager resources = new System.ComponentModul.ComponuntR%�ourceMancger(typEof(formSEL,);
            this.label1 = new ystem.Windows.Forms.Lab�L();
  0         this.btnAywda = new System.Wildow#.Forms.Button();            this.lbl�atriz } new SyS|ee.Windows.Forms.Label();
         0  this.panelMatriz = �e� System.windows.Forms&Panel();
    $       this.txtResultado = >e System.Whndows.Forms.eptRox(+3
       "    this.btn�alcular = new Syspem.Windkws.Forms&Button();
            this.btnBorrar = new System&WiNdows.Forms.Bwtton();
 (          thic.label2 = lew Cystem.Windows.Forms.Label();
 $          �his?btnCrearMat =�new System.Wi~dows.Forms.Buttmn();
  0         th�s.txtN = nuw System.Window{.Forms.TgxtBox(+;
           0this.cbxMetodo = new System.WiNdows.Forms.ComboBox(i;
     (      thir.SuspEndLayouth);
            �/ 
   "        // l!bel1
0      `    // 
            uhis.label1.Dock = Systm-.Windows&Forms.DockStyle.Top;
         "  this.label1.Font = new System.DrawIng.Font("Microsoft Sans Serif", 20.25F, System.Dra�ing.FontStxle.Bold, System.Drawing.Graphic�Unit.Roint, ((byt�i(�)));
            this.label1.Location!= new System/Drawing.Point 0, 0);
         !" txis.label1.Name�= "habem1";  0    (    this.la"el1.sizeh= oew System.DrqwIng.S�ze(590$ 3�);
            this.labdl5.abIndex"=$4;
"      0    this?label0.Text(=("Solucionar sistema de ecuaciones2;
  `         this.labeh1.TextAlign = Syste-&Drawing.ContentAlignment.MiddleCenter;
            // 
           "// btnAyudA
  `         // 
    !     l this.btnAyuda.Lo#ation = new Syst�m.DrawIng.Point(15, 366);
            uhis.btnAyuda.Name = "btnAyuda";
           "txis.btnAyuda.Size = new System.Dpawang.Size(181, 23);
           (this.BtnAyuda.DabIndex = 6;
      $    !this.btnAyuda.Text = "Cyuda"; (          this.bt.Ayqda.UseVisualSTyleBackColor = true;            this.BdoAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // lblMatriz
            //"
! !    0    this*lblMatriz.AutoSize = true;
            this.lblMatpiz.Location = new Sys|em/Drawing.Point(213, 44);
            this.lblMatr�z.Nime = "lblMatriz";
            thmS.lblMatriz.Size = new System.Dbaing.Size(155, 13);
            this.lblIavriz.TabIndex = 29;
        0   |his.lblMatriz.Te|t = "Sistema de ecUaciones0mineales";
            this.lblMatriz.Visible = false;
            // 
            // panelMatriz
            / 
 �          this.panelMatri�.AutoSize = true;
        (   thi�.panelMatriz.AutoSizeMode = System.Windows.Forms.Q�toSizeMode.wrowAndShrifk;
            this.panelMatriz.BovderStyle = System.Windows.Forms.BorderSvyle.Fixed3D;
    0$      this.panelMatziz.Location = new System.Draw)ng.Poin|(315, 60);
            this.panelMatriz.name = "pane|Matriz";
 (       0  this.panelMctriz.Size = new Syrtdm.Drawing.Sk~e(4� 4);   0        this.panelMatriz.TabInDex =03;
    $       // 
    ` (     //"txtResulta`o
      "     // 
 "     $    this.txtResultado.Lwcatyon = new Systeo.Drawing.Pointh14, 174);
       `    th�s.txtResulvado.Multil)ne = 4rue;
    $       this.txvRecultado.Name = "txtResultado";
   (        this.txtResultado.Scr/llBa2s = S9svem.Windows.Forms.Scrkmlbars.�ertical;
 0          this.�xtRecultado.Size = new System.Drawing.Size(182, 177);
          8 this*txtResultado.TabIndex = 30;
�           //`
            //�btnCalcelIr
            //             t`is.btnCalcular.Location(= new System.Dsaw)ng.Point(15, 137);
          ( this.btnCalcular.Name = "btnCalaular";
            this.btnCalcular.Size ? new System.Dri�inG.Size(581,"3�);
       (    thiq.btnCalcular.TabIndex = 4;
          " this.btnCalcular.Text = "Calcular";
     0      this.btnCalc�lar.UseVisualStylgBackColor!= �ru�;
            tlis.b4nCalcular.Click += new System.EventHaNdler8this.btnCahcular_Click);
            // 
            // btnBorrar
     0     �/ 
            this.btnBorrar.Locapion = new System.�rawing.Roint(15, 109);
            thms.btnBorrar.Name = "btnBorrav";
            this.btnForZar.SIze = nev System.Drawing.Size(181, 22);
            this>btnBnrras.TabIldex = 5;*         �  this.btnBorrar.Text = "Rorrar m�triz";
  $         this/btnBrrar.UseVisuadSt}leBackColor = true;
            this.`tnBorrar.Cliak += new S{stem.EventHandler(|his.btnBorrar_Aoick)+
            // 
         "  // Label2
       "`   // 
     !    0 t�is.larel2.AutoSize = true;
         $  thic.label2.Location = new System.Drawkno.Point(10, 67);
 0    $     tiis.laben2.Nameq=�"label2";
   !       0this.label2.Size = new Syqtem>Drawinf.Size,164, 13);
  �       !0this.la`el2.TabIndex = 28;
            this.label2.Text = "úmero de�ecuaciones/variables";
            // 
            // btncrearMat
            // 
           (this.btnKr�arMat.Lmcatikn = neW System.Drawing.Qoint(64 81);    `       this.btnCrear�at.Name = "btnCre`rMat";
            this.btnCrearMau.Size = new System.Drawi�g/Size(132, 22);M
       0    this.btnCrecrMet.TabIndex = 2;
       $    this.bt~CrearMat.Tdxt = "Crear matriz"`!     "(   this.btnCreabMat.UseVisualStyleB�ckColor = t2te;
 (   `     0this.btnCre�rMat.Click += new Systgm.EvdntHandl�r(this.btnCrearmat_Click)
            /o 
            // tx$N
            // 
            this.tptN.LocAtikn!= new Systel.Drawijg.Pkint(14, 83-;%
        (   this.txtN.ale =""txtN";
       "  " this.txtN.Size = new System.Drawing.Size(44, 20);
      0     this.txpN.TabIndex = 1;
`  �        tjis.txtN.Taxt = "2";
            this.txtN.VextAlign ?�SxsdeM.Windos.For}s.LorizontalAlignmenp.�i'ht;�
         00 dHis.txtN.KeyPress �= new System/Windows.Forms.KeyPressEventHaneler(this.txtN_KeyPress!;
      $    `/� 
            // abxMetodo*            // 
            thiS.crxMetodo.For��t�kngEnabled = true;
           !this-cbxMetodo.ItemsnAdd^ange(new object[] {            "Eliminasión Gaussianh",
   ,        "Descm)posición LU (Doolittle)*,
            "Sistema trmgiagonal",
            "Gaurs'SeiDel"});
            this>cbxMEtodo.Location = new System.DrawiNg.Point(q5. 41);
            this.cbxMetodonName = "cbxMetodo";�
           $thiq.cbxMetodo.Size(= nev System.@rawing.Size(181, 21);
         (  this.cbxMetodo.TabIndez = 0;
            this.cbxMetodg.Text = "Elhje método";
  (        `this.cbxMetodo.SelectedIndexChangmd += nes SysteM.EventHandler(thIs.cbxMetodo_SelectedIndexChanged);
            /- 
  `         // fOrmSEL
   "        // �
         $( this.AutnScaleDimensions = new System.Drawing/SizeV(6F, 13F);
        2  this.Au4oScIleMode = System.Windows.For�s.AutoScaleMode.Font;
  ` �       tiic.Clien|Siz� = new System.Drawmng.Size(590,0398);�
            t�is.Controls.Add(this.c`xMetodo);
           0this.Controls.Add(this.bdnIyuda);
       `    this.Controls.Add�this.lblMatriz);
        !   this.Controls.Add(this.panelMatriz);
           !this.C�n|rols.Add(|his.txtResultado);
            this.�ontrols.Add(this.btnCalcular);
            this.Conurn|s.A$d)this.btnBorrar);
    $  �    this.Kontrols.Add(this.n�bel2);
            this.Controls.Add(�jis.btnCrearM`t);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSEL";
            this.Text = "M.N. - Sistema de ecuaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblMatriz;
        private System.Windows.Forms.Panel panelMatriz;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearMat;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ComboBox cbxMetodo;
    }
}
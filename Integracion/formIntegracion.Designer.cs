namespace raizesMN
{
    partial class formIntegracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIntegracion));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblLimB = new System.Windows.Forms.Label();
            this.lblLimA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEcuacion = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtLim2 = new System.Windows.Forms.TextBox();
            this.txtLim1 = new System.Windows.Forms.TextBox();
            this.lblLim2 = new System.Windows.Forms.Label();
            this.lblLim1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbxMetodos = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(472, 37);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "Métodos de integración";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(229, 68);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(22, 13);
            this.lblN.TabIndex = 83;
            this.lblN.Text = "n =";
            // 
            // lblLimB
            // 
            this.lblLimB.AutoSize = true;
            this.lblLimB.Location = new System.Drawing.Point(119, 139);
            this.lblLimB.Name = "lblLimB";
            this.lblLimB.Size = new System.Drawing.Size(13, 13);
            this.lblLimB.TabIndex = 79;
            this.lblLimB.Text = "b";
            // 
            // lblLimA
            // 
            this.lblLimA.AutoSize = true;
            this.lblLimA.Location = new System.Drawing.Point(119, 165);
            this.lblLimA.Name = "lblLimA";
            this.lblLimA.Size = new System.Drawing.Size(13, 13);
            this.lblLimA.TabIndex = 80;
            this.lblLimA.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 39);
            this.label2.TabIndex = 81;
            this.label2.Text = "∫";
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.AutoSize = true;
            this.lblEcuacion.Location = new System.Drawing.Point(126, 151);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(24, 13);
            this.lblEcuacion.TabIndex = 82;
            this.lblEcuacion.Text = "()dx";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(251, 45);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(81, 20);
            this.txtH.TabIndex = 78;
            this.txtH.Text = "0.0001";
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtH_KeyPress);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(229, 48);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(16, 13);
            this.lblH.TabIndex = 77;
            this.lblH.Text = "h:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(4, 205);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 76;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(68, 202);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(377, 20);
            this.txtResultado.TabIndex = 75;
            // 
            // txtLim2
            // 
            this.txtLim2.Location = new System.Drawing.Point(279, 110);
            this.txtLim2.Name = "txtLim2";
            this.txtLim2.Size = new System.Drawing.Size(100, 20);
            this.txtLim2.TabIndex = 3;
            this.txtLim2.Text = "0";
            this.txtLim2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLim2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLim1_KeyPress);
            // 
            // txtLim1
            // 
            this.txtLim1.Location = new System.Drawing.Point(88, 110);
            this.txtLim1.Name = "txtLim1";
            this.txtLim1.Size = new System.Drawing.Size(100, 20);
            this.txtLim1.TabIndex = 2;
            this.txtLim1.Text = "0";
            this.txtLim1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLim1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLim1_KeyPress);
            // 
            // lblLim2
            // 
            this.lblLim2.AutoSize = true;
            this.lblLim2.Location = new System.Drawing.Point(194, 110);
            this.lblLim2.Name = "lblLim2";
            this.lblLim2.Size = new System.Drawing.Size(79, 13);
            this.lblLim2.TabIndex = 72;
            this.lblLim2.Text = "Límite superior:";
            // 
            // lblLim1
            // 
            this.lblLim1.AutoSize = true;
            this.lblLim1.Location = new System.Drawing.Point(11, 110);
            this.lblLim1.Name = "lblLim1";
            this.lblLim1.Size = new System.Drawing.Size(73, 13);
            this.lblLim1.TabIndex = 71;
            this.lblLim1.Text = "Límite inferior:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Ecuación:";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(381, 43);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(7, 87);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEcuacion.Size = new System.Drawing.Size(449, 20);
            this.txtEcuacion.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(7, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(59, 53);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbxMetodos
            // 
            this.cbxMetodos.FormattingEnabled = true;
            this.cbxMetodos.Items.AddRange(new object[] {
            "Trapezoidal",
            "Simpson 1/3",
            "Simpson 3/8"});
            this.cbxMetodos.Location = new System.Drawing.Point(56, 45);
            this.cbxMetodos.Name = "cbxMetodos";
            this.cbxMetodos.Size = new System.Drawing.Size(132, 21);
            this.cbxMetodos.TabIndex = 0;
            this.cbxMetodos.Text = "Selecciona método";
            this.cbxMetodos.SelectedIndexChanged += new System.EventHandler(this.cbxMetodos_SelectedIndexChanged);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(4, 48);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(46, 13);
            this.lblMetodo.TabIndex = 65;
            this.lblMetodo.Text = "Método:";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(370, 151);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 5;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // formIntegracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 232);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblLimB);
            this.Controls.Add(this.lblLimA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEcuacion);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtLim2);
            this.Controls.Add(this.txtLim1);
            this.Controls.Add(this.lblLim2);
            this.Controls.Add(this.lblLim1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.txtEcuacion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbxMetodos);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formIntegracion";
            this.Text = "M.N. - Integración númerica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        protected internal System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblLimB;
        private System.Windows.Forms.Label lblLimA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEcuacion;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtLim2;
        private System.Windows.Forms.TextBox txtLim1;
        private System.Windows.Forms.Label lblLim2;
        private System.Windows.Forms.Label lblLim1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbxMetodos;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Button btnGraficar;
    }
}
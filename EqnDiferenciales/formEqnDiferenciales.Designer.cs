namespace raizesMN
{
    partial class formEqnDiferenciales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEqnDiferenciales));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGMejora = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.conIncLbl = new System.Windows.Forms.Label();
            this.txtNYs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEcuacion = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.lblY0 = new System.Windows.Forms.Label();
            this.lblX0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbxMetodos = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(475, 37);
            this.lblTitulo.TabIndex = 66;
            this.lblTitulo.Text = "Ecuaciones diferenciales";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGMejora
            // 
            this.lblGMejora.AutoSize = true;
            this.lblGMejora.Location = new System.Drawing.Point(317, 177);
            this.lblGMejora.Name = "lblGMejora";
            this.lblGMejora.Size = new System.Drawing.Size(88, 13);
            this.lblGMejora.TabIndex = 108;
            this.lblGMejora.Text = "Grado de mejora:";
            this.lblGMejora.Visible = false;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(410, 174);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(43, 20);
            this.txtM.TabIndex = 5;
            this.txtM.Visible = false;
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM_KeyPress);
            // 
            // conIncLbl
            // 
            this.conIncLbl.AutoSize = true;
            this.conIncLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conIncLbl.Location = new System.Drawing.Point(136, 169);
            this.conIncLbl.Name = "conIncLbl";
            this.conIncLbl.Size = new System.Drawing.Size(117, 25);
            this.conIncLbl.TabIndex = 106;
            this.conIncLbl.Text = "y(x0) = y0";
            // 
            // txtNYs
            // 
            this.txtNYs.Location = new System.Drawing.Point(369, 111);
            this.txtNYs.Name = "txtNYs";
            this.txtNYs.Size = new System.Drawing.Size(95, 20);
            this.txtNYs.TabIndex = 4;
            this.txtNYs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtH_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Número de y´s:";
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.AutoSize = true;
            this.lblEcuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcuacion.Location = new System.Drawing.Point(102, 147);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(49, 16);
            this.lblEcuacion.TabIndex = 103;
            this.lblEcuacion.Text = "y\'(x)= ";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(259, 46);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(81, 20);
            this.txtH.TabIndex = 102;
            this.txtH.Text = "0.0001";
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtH_KeyPress);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(237, 49);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(16, 13);
            this.lblH.TabIndex = 101;
            this.lblH.Text = "h:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 206);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 100;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(76, 203);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(377, 148);
            this.txtResultado.TabIndex = 99;
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(182, 111);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(100, 20);
            this.txtY0.TabIndex = 3;
            this.txtY0.Text = "0";
            this.txtY0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtY0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX0_KeyPress);
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(49, 111);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(100, 20);
            this.txtX0.TabIndex = 2;
            this.txtX0.Text = "0";
            this.txtX0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX0_KeyPress);
            // 
            // lblY0
            // 
            this.lblY0.AutoSize = true;
            this.lblY0.Location = new System.Drawing.Point(155, 111);
            this.lblY0.Name = "lblY0";
            this.lblY0.Size = new System.Drawing.Size(21, 13);
            this.lblY0.TabIndex = 96;
            this.lblY0.Text = "y0:";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Location = new System.Drawing.Point(19, 111);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(24, 13);
            this.lblX0.TabIndex = 95;
            this.lblX0.Text = "x0: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Ecuación ( y\'(x)=f(x,y) ) :";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(389, 44);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(15, 88);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEcuacion.Size = new System.Drawing.Size(449, 20);
            this.txtEcuacion.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(11, 137);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(59, 53);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbxMetodos
            // 
            this.cbxMetodos.FormattingEnabled = true;
            this.cbxMetodos.Items.AddRange(new object[] {
            "Euler",
            "Euler mejorado",
            "Runge-Kutta"});
            this.cbxMetodos.Location = new System.Drawing.Point(64, 46);
            this.cbxMetodos.Name = "cbxMetodos";
            this.cbxMetodos.Size = new System.Drawing.Size(132, 21);
            this.cbxMetodos.TabIndex = 0;
            this.cbxMetodos.Text = "Selecciona método";
            this.cbxMetodos.SelectedIndexChanged += new System.EventHandler(this.cbxMetodos_SelectedIndexChanged);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(12, 49);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(46, 13);
            this.lblMetodo.TabIndex = 89;
            this.lblMetodo.Text = "Método:";
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(388, 137);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(75, 23);
            this.btnGrafica.TabIndex = 109;
            this.btnGrafica.Text = "Abrir gráfica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // formEqnDiferenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 362);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.lblGMejora);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.conIncLbl);
            this.Controls.Add(this.txtNYs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEcuacion);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.lblY0);
            this.Controls.Add(this.lblX0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.txtEcuacion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbxMetodos);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formEqnDiferenciales";
            this.Text = "M.N. - Ecuaciones diferenciales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGMejora;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label conIncLbl;
        private System.Windows.Forms.TextBox txtNYs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEcuacion;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label lblY0;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbxMetodos;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Button btnGrafica;
    }
}
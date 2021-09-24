namespace raizesMN
{
    partial class formFourier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFourier));
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblT = new System.Windows.Forms.Label();
            this.lblFt = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblDatos1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbxResultados = new System.Windows.Forms.ListBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtNumeron = new System.Windows.Forms.TextBox();
            this.lblNumeron = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWn = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.Location = new System.Drawing.Point(127, 44);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(88, 31);
            this.btnCrearTabla.TabIndex = 1;
            this.btnCrearTabla.Text = "Crear tabla";
            this.btnCrearTabla.UseVisualStyleBackColor = true;
            this.btnCrearTabla.Click += new System.EventHandler(this.btnCrearTabla_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(24, 55);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(97, 20);
            this.txtN.TabIndex = 0;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de datos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(904, 35);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Funciones periódicas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(56, 81);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 31);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pnlTabla
            // 
            this.pnlTabla.AutoSize = true;
            this.pnlTabla.Location = new System.Drawing.Point(10, 45);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(136, 94);
            this.pnlTabla.TabIndex = 0;
            // 
            // pnlDatos
            // 
            this.pnlDatos.AutoScroll = true;
            this.pnlDatos.Controls.Add(this.lblT);
            this.pnlDatos.Controls.Add(this.lblFt);
            this.pnlDatos.Controls.Add(this.lblIndice);
            this.pnlDatos.Controls.Add(this.lblDatos1);
            this.pnlDatos.Controls.Add(this.pnlTabla);
            this.pnlDatos.Location = new System.Drawing.Point(221, 55);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(152, 387);
            this.pnlDatos.TabIndex = 2;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(60, 26);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(10, 13);
            this.lblT.TabIndex = 8;
            this.lblT.Text = "t";
            this.lblT.Visible = false;
            // 
            // lblFt
            // 
            this.lblFt.AutoSize = true;
            this.lblFt.Location = new System.Drawing.Point(99, 26);
            this.lblFt.Name = "lblFt";
            this.lblFt.Size = new System.Drawing.Size(19, 13);
            this.lblFt.TabIndex = 8;
            this.lblFt.Text = "f(t)";
            this.lblFt.Visible = false;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(7, 29);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(36, 13);
            this.lblIndice.TabIndex = 8;
            this.lblIndice.Text = "Índice";
            this.lblIndice.Visible = false;
            // 
            // lblDatos1
            // 
            this.lblDatos1.AutoSize = true;
            this.lblDatos1.Location = new System.Drawing.Point(58, 3);
            this.lblDatos1.Name = "lblDatos1";
            this.lblDatos1.Size = new System.Drawing.Size(35, 13);
            this.lblDatos1.TabIndex = 8;
            this.lblDatos1.Text = "Datos";
            this.lblDatos1.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(47, 225);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 41);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbxResultados
            // 
            this.lbxResultados.FormattingEnabled = true;
            this.lbxResultados.Location = new System.Drawing.Point(393, 55);
            this.lbxResultados.Name = "lbxResultados";
            this.lbxResultados.Size = new System.Drawing.Size(499, 381);
            this.lbxResultados.TabIndex = 9;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(30, 165);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(33, 13);
            this.lblN.TabIndex = 10;
            this.lblN.Text = "N = 0";
            // 
            // txtNumeron
            // 
            this.txtNumeron.Location = new System.Drawing.Point(15, 142);
            this.txtNumeron.Name = "txtNumeron";
            this.txtNumeron.Size = new System.Drawing.Size(58, 20);
            this.txtNumeron.TabIndex = 3;
            this.txtNumeron.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeron.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // lblNumeron
            // 
            this.lblNumeron.AutoSize = true;
            this.lblNumeron.Location = new System.Drawing.Point(12, 126);
            this.lblNumeron.Name = "lblNumeron";
            this.lblNumeron.Size = new System.Drawing.Size(68, 13);
            this.lblNumeron.TabIndex = 12;
            this.lblNumeron.Text = "Número de n";
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(105, 142);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(58, 20);
            this.txtW.TabIndex = 4;
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtW_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "w (rad/s)";
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(47, 288);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(106, 41);
            this.btnGrafica.TabIndex = 6;
            this.btnGrafica.Text = "Graficar";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNo);
            this.groupBox1.Controls.Add(this.rbtnSi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(47, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráficar armonicos";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Checked = true;
            this.rbtnNo.Location = new System.Drawing.Point(28, 54);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(39, 17);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.Location = new System.Drawing.Point(28, 31);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(34, 17);
            this.rbtnSi.TabIndex = 1;
            this.rbtnSi.Text = "Si";
            this.rbtnSi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // btnWn
            // 
            this.btnWn.Location = new System.Drawing.Point(169, 142);
            this.btnWn.Name = "btnWn";
            this.btnWn.Size = new System.Drawing.Size(27, 19);
            this.btnWn.TabIndex = 13;
            this.btnWn.Text = "c";
            this.btnWn.UseVisualStyleBackColor = true;
            this.btnWn.Click += new System.EventHandler(this.btnWn_Click);
            // 
            // formFourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.btnWn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumeron);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtNumeron);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lbxResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnCrearTabla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formFourier";
            this.Text = "M.N. - Fourier";
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTabla;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblDatos1;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblFt;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lbxResultados;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtNumeron;
        private System.Windows.Forms.Label lblNumeron;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWn;
    }
}
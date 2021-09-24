namespace raizesMN
{
    partial class formOptimizar
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
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.lblFunc = new System.Windows.Forms.Label();
            this.txtxlow = new System.Windows.Forms.TextBox();
            this.txtxhigh = new System.Windows.Forms.TextBox();
            this.lblxl = new System.Windows.Forms.Label();
            this.lblxu = new System.Windows.Forms.Label();
            this.txtMaxIt = new System.Windows.Forms.TextBox();
            this.lblItmax = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbxMetodo = new System.Windows.Forms.ComboBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(65, 37);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(352, 20);
            this.txtFuncion.TabIndex = 0;
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Location = new System.Drawing.Point(11, 40);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(48, 13);
            this.lblFunc.TabIndex = 1;
            this.lblFunc.Text = "Función:";
            // 
            // txtxlow
            // 
            this.txtxlow.Location = new System.Drawing.Point(39, 108);
            this.txtxlow.Name = "txtxlow";
            this.txtxlow.Size = new System.Drawing.Size(100, 20);
            this.txtxlow.TabIndex = 2;
            this.txtxlow.Text = "0";
            this.txtxlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtxhigh
            // 
            this.txtxhigh.Location = new System.Drawing.Point(39, 134);
            this.txtxhigh.Name = "txtxhigh";
            this.txtxhigh.Size = new System.Drawing.Size(100, 20);
            this.txtxhigh.TabIndex = 2;
            this.txtxhigh.Text = "0";
            this.txtxhigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblxl
            // 
            this.lblxl.AutoSize = true;
            this.lblxl.Location = new System.Drawing.Point(10, 111);
            this.lblxl.Name = "lblxl";
            this.lblxl.Size = new System.Drawing.Size(23, 13);
            this.lblxl.TabIndex = 3;
            this.lblxl.Text = "xl =";
            // 
            // lblxu
            // 
            this.lblxu.AutoSize = true;
            this.lblxu.Location = new System.Drawing.Point(10, 137);
            this.lblxu.Name = "lblxu";
            this.lblxu.Size = new System.Drawing.Size(27, 13);
            this.lblxu.TabIndex = 3;
            this.lblxu.Text = "xu =";
            // 
            // txtMaxIt
            // 
            this.txtMaxIt.Location = new System.Drawing.Point(29, 212);
            this.txtMaxIt.Name = "txtMaxIt";
            this.txtMaxIt.Size = new System.Drawing.Size(100, 20);
            this.txtMaxIt.TabIndex = 2;
            this.txtMaxIt.Text = "20";
            this.txtMaxIt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblItmax
            // 
            this.lblItmax.AutoSize = true;
            this.lblItmax.Location = new System.Drawing.Point(26, 196);
            this.lblItmax.Name = "lblItmax";
            this.lblItmax.Size = new System.Drawing.Size(102, 13);
            this.lblItmax.TabIndex = 3;
            this.lblItmax.Text = "Iteraciones máximas";
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(29, 251);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(100, 20);
            this.txtError.TabIndex = 2;
            this.txtError.Text = "0.01";
            this.txtError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Error";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(14, 295);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 70);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbxMetodo
            // 
            this.cbxMetodo.FormattingEnabled = true;
            this.cbxMetodo.Items.AddRange(new object[] {
            "Seccion dorada",
            "Brent"});
            this.cbxMetodo.Location = new System.Drawing.Point(13, 63);
            this.cbxMetodo.Name = "cbxMetodo";
            this.cbxMetodo.Size = new System.Drawing.Size(126, 21);
            this.cbxMetodo.TabIndex = 5;
            this.cbxMetodo.Text = "Elije metodo";
            this.cbxMetodo.SelectedIndexChanged += new System.EventHandler(this.cbxMetodo_SelectedIndexChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(158, 76);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(259, 195);
            this.txtResultado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultados";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(435, 35);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Métodos de optimización";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(172, 306);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(102, 48);
            this.btnGrafica.TabIndex = 9;
            this.btnGrafica.Text = "Graficar";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(297, 306);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(102, 48);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(158, 278);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(0, 13);
            this.lblFuncion.TabIndex = 10;
            // 
            // formOptimizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 380);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.cbxMetodo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItmax);
            this.Controls.Add(this.lblxu);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.lblxl);
            this.Controls.Add(this.txtMaxIt);
            this.Controls.Add(this.txtxhigh);
            this.Controls.Add(this.txtxlow);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.txtFuncion);
            this.Name = "formOptimizar";
            this.Text = "M.N. - Optimizacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.TextBox txtxlow;
        private System.Windows.Forms.TextBox txtxhigh;
        private System.Windows.Forms.Label lblxl;
        private System.Windows.Forms.Label lblxu;
        private System.Windows.Forms.TextBox txtMaxIt;
        private System.Windows.Forms.Label lblItmax;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbxMetodo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblFuncion;
    }
}
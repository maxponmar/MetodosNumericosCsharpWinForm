namespace raizesMN
{
    partial class formGrafica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGrafica));
            this.panelGrafica = new System.Windows.Forms.Panel();
            this.txtYmin = new System.Windows.Forms.TextBox();
            this.txtYmax = new System.Windows.Forms.TextBox();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxFunciones = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbxEjes = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbrZoomX = new System.Windows.Forms.TrackBar();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbxEjes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomX)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGrafica
            // 
            this.panelGrafica.AutoScroll = true;
            this.panelGrafica.Location = new System.Drawing.Point(0, 0);
            this.panelGrafica.Name = "panelGrafica";
            this.panelGrafica.Size = new System.Drawing.Size(4000, 4000);
            this.panelGrafica.TabIndex = 0;
            this.panelGrafica.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrafica_Paint);
            // 
            // txtYmin
            // 
            this.txtYmin.Location = new System.Drawing.Point(112, 31);
            this.txtYmin.Name = "txtYmin";
            this.txtYmin.Size = new System.Drawing.Size(65, 20);
            this.txtYmin.TabIndex = 1;
            this.txtYmin.Text = "-10";
            this.txtYmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtYmax
            // 
            this.txtYmax.Location = new System.Drawing.Point(112, 57);
            this.txtYmax.Name = "txtYmax";
            this.txtYmax.Size = new System.Drawing.Size(65, 20);
            this.txtYmax.TabIndex = 1;
            this.txtYmax.Text = "10";
            this.txtYmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXmin
            // 
            this.txtXmin.Location = new System.Drawing.Point(41, 31);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(65, 20);
            this.txtXmin.TabIndex = 1;
            this.txtXmin.Text = "-10";
            this.txtXmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXmax
            // 
            this.txtXmax.Location = new System.Drawing.Point(41, 57);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(65, 20);
            this.txtXmax.TabIndex = 1;
            this.txtXmax.Text = "10";
            this.txtXmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eje X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eje Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "mín.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "máx.";
            // 
            // lbxFunciones
            // 
            this.lbxFunciones.FormattingEnabled = true;
            this.lbxFunciones.Location = new System.Drawing.Point(15, 9);
            this.lbxFunciones.Name = "lbxFunciones";
            this.lbxFunciones.ScrollAlwaysVisible = true;
            this.lbxFunciones.Size = new System.Drawing.Size(614, 134);
            this.lbxFunciones.TabIndex = 5;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(17, 149);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(51, 23);
            this.btnAñadir.TabIndex = 6;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(83, 149);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(145, 149);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(52, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbxEjes
            // 
            this.gbxEjes.Controls.Add(this.btnAyuda);
            this.gbxEjes.Controls.Add(this.label5);
            this.gbxEjes.Controls.Add(this.tbrZoomX);
            this.gbxEjes.Controls.Add(this.btnActualizar);
            this.gbxEjes.Controls.Add(this.label1);
            this.gbxEjes.Controls.Add(this.txtYmin);
            this.gbxEjes.Controls.Add(this.txtXmin);
            this.gbxEjes.Controls.Add(this.txtYmax);
            this.gbxEjes.Controls.Add(this.txtXmax);
            this.gbxEjes.Controls.Add(this.label3);
            this.gbxEjes.Controls.Add(this.label2);
            this.gbxEjes.Controls.Add(this.label4);
            this.gbxEjes.Location = new System.Drawing.Point(418, 12);
            this.gbxEjes.Name = "gbxEjes";
            this.gbxEjes.Size = new System.Drawing.Size(209, 167);
            this.gbxEjes.TabIndex = 7;
            this.gbxEjes.TabStop = false;
            this.gbxEjes.Text = "Ejes";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(83, 144);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(54, 23);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zoom ";
            // 
            // tbrZoomX
            // 
            this.tbrZoomX.LargeChange = 1;
            this.tbrZoomX.Location = new System.Drawing.Point(61, 112);
            this.tbrZoomX.Maximum = 1000;
            this.tbrZoomX.Minimum = 100;
            this.tbrZoomX.Name = "tbrZoomX";
            this.tbrZoomX.Size = new System.Drawing.Size(116, 45);
            this.tbrZoomX.TabIndex = 4;
            this.tbrZoomX.Value = 100;
            this.tbrZoomX.Scroll += new System.EventHandler(this.tbrZoomX_Scroll);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(72, 83);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelGrafica);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnAñadir);
            this.panel2.Controls.Add(this.lbxFunciones);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Location = new System.Drawing.Point(418, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 227);
            this.panel2.TabIndex = 10;
            // 
            // formGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxEjes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formGrafica";
            this.Text = "Gráfica";
            this.gbxEjes.ResumeLayout(false);
            this.gbxEjes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGrafica;
        private System.Windows.Forms.TextBox txtYmin;
        private System.Windows.Forms.TextBox txtYmax;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxFunciones;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbxEjes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbrZoomX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAyuda;
    }
}
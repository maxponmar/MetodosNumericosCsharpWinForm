namespace raizesMN
{
    partial class TabularFuncion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabularFuncion));
            this.rtxTabla = new System.Windows.Forms.RichTextBox();
            this.btnTabla = new System.Windows.Forms.Button();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.cbxTabla = new System.Windows.Forms.CheckBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaso = new System.Windows.Forms.TextBox();
            this.lblPaso = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxTabla
            // 
            this.rtxTabla.Location = new System.Drawing.Point(12, 146);
            this.rtxTabla.Name = "rtxTabla";
            this.rtxTabla.Size = new System.Drawing.Size(313, 224);
            this.rtxTabla.TabIndex = 30;
            this.rtxTabla.Text = "";
            // 
            // btnTabla
            // 
            this.btnTabla.Location = new System.Drawing.Point(16, 113);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(106, 27);
            this.btnTabla.TabIndex = 24;
            this.btnTabla.Text = "Tabular";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // txtV1
            // 
            this.txtV1.Enabled = false;
            this.txtV1.Location = new System.Drawing.Point(47, 87);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(43, 20);
            this.txtV1.TabIndex = 26;
            this.txtV1.Text = "-100";
            this.txtV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtV1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtV1_KeyPress_1);
            // 
            // cbxTabla
            // 
            this.cbxTabla.AutoSize = true;
            this.cbxTabla.Location = new System.Drawing.Point(30, 64);
            this.cbxTabla.Name = "cbxTabla";
            this.cbxTabla.Size = new System.Drawing.Size(106, 17);
            this.cbxTabla.TabIndex = 29;
            this.cbxTabla.Text = "Establecer rango";
            this.cbxTabla.UseVisualStyleBackColor = true;
            this.cbxTabla.CheckedChanged += new System.EventHandler(this.cbxTabla_CheckedChanged);
            // 
            // txtV2
            // 
            this.txtV2.Enabled = false;
            this.txtV2.Location = new System.Drawing.Point(96, 87);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(43, 20);
            this.txtV2.TabIndex = 25;
            this.txtV2.Text = "100";
            this.txtV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtV2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtV1_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "A:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "De:";
            this.label3.Visible = false;
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(67, 12);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(250, 20);
            this.txtFuncion.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Función:";
            // 
            // txtPaso
            // 
            this.txtPaso.Location = new System.Drawing.Point(64, 38);
            this.txtPaso.Name = "txtPaso";
            this.txtPaso.Size = new System.Drawing.Size(58, 20);
            this.txtPaso.TabIndex = 33;
            this.txtPaso.Text = "1";
            this.txtPaso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaso_KeyPress);
            // 
            // lblPaso
            // 
            this.lblPaso.AutoSize = true;
            this.lblPaso.Location = new System.Drawing.Point(27, 41);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new System.Drawing.Size(34, 13);
            this.lblPaso.TabIndex = 34;
            this.lblPaso.Text = "Paso:";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(173, 90);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(33, 13);
            this.lblX2.TabIndex = 37;
            this.lblX2.Text = "x(2) =";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(173, 64);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(33, 13);
            this.lblX1.TabIndex = 38;
            this.lblX1.Text = "x(1) =";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(212, 87);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(90, 20);
            this.txtX2.TabIndex = 35;
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(212, 61);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(90, 20);
            this.txtX1.TabIndex = 36;
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "La raíz se encuentre entre:";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(128, 120);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(55, 13);
            this.lblFuncion.TabIndex = 40;
            this.lblFuncion.Text = "lblFuncion";
            this.lblFuncion.Visible = false;
            // 
            // TabularFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 376);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.lblPaso);
            this.Controls.Add(this.txtPaso);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxTabla);
            this.Controls.Add(this.btnTabla);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.cbxTabla);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabularFuncion";
            this.Text = "Tabular función";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxTabla;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.CheckBox cbxTabla;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaso;
        private System.Windows.Forms.Label lblPaso;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFuncion;
    }
}
namespace Pagina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbprocesos = new System.Windows.Forms.ComboBox();
            this.lbp1 = new System.Windows.Forms.ListBox();
            this.btnagrega = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cbprocesos
            // 
            this.cbprocesos.BackColor = System.Drawing.SystemColors.Info;
            this.cbprocesos.FormattingEnabled = true;
            this.cbprocesos.Items.AddRange(new object[] {
            "Proceso A",
            "Proceso B",
            "Proceso C"});
            this.cbprocesos.Location = new System.Drawing.Point(397, 7);
            this.cbprocesos.Name = "cbprocesos";
            this.cbprocesos.Size = new System.Drawing.Size(121, 28);
            this.cbprocesos.TabIndex = 0;
            // 
            // lbp1
            // 
            this.lbp1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbp1.FormattingEnabled = true;
            this.lbp1.ItemHeight = 20;
            this.lbp1.Location = new System.Drawing.Point(12, 12);
            this.lbp1.Name = "lbp1";
            this.lbp1.Size = new System.Drawing.Size(379, 264);
            this.lbp1.TabIndex = 2;
            // 
            // btnagrega
            // 
            this.btnagrega.BackColor = System.Drawing.SystemColors.Info;
            this.btnagrega.Location = new System.Drawing.Point(397, 172);
            this.btnagrega.Name = "btnagrega";
            this.btnagrega.Size = new System.Drawing.Size(121, 36);
            this.btnagrega.TabIndex = 11;
            this.btnagrega.Text = "Terminar";
            this.btnagrega.UseVisualStyleBackColor = false;
            this.btnagrega.Click += new System.EventHandler(this.btnagrega_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(397, 130);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(121, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Iniciar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(397, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tamaño";
            // 
            // txtcant
            // 
            this.txtcant.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtcant.Location = new System.Drawing.Point(477, 44);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(52, 26);
            this.txtcant.TabIndex = 14;
            this.txtcant.TextChanged += new System.EventHandler(this.txtcant_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(397, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "Agregar Procesos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(546, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(21, 20);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 373);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnagrega);
            this.Controls.Add(this.lbp1);
            this.Controls.Add(this.cbprocesos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbprocesos;
        private System.Windows.Forms.ListBox lbp1;
        private System.Windows.Forms.Button btnagrega;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}


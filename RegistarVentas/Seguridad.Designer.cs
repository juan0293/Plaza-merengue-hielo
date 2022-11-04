namespace RegistarVentas
{
    partial class formAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAcceso));
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigoacceso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresarAcceso = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // txtcodigoacceso
            // 
            this.txtcodigoacceso.BackColor = System.Drawing.SystemColors.Info;
            this.txtcodigoacceso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoacceso.Location = new System.Drawing.Point(72, 38);
            this.txtcodigoacceso.Name = "txtcodigoacceso";
            this.txtcodigoacceso.PasswordChar = '*';
            this.txtcodigoacceso.Size = new System.Drawing.Size(100, 29);
            this.txtcodigoacceso.TabIndex = 3;
            this.txtcodigoacceso.UseSystemPasswordChar = true;
            this.txtcodigoacceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigoacceso_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(63, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = " Acceso Supervisor";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // btnIngresarAcceso
            // 
            this.btnIngresarAcceso.BackColor = System.Drawing.Color.White;
            this.btnIngresarAcceso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAcceso.Location = new System.Drawing.Point(72, 73);
            this.btnIngresarAcceso.Name = "btnIngresarAcceso";
            this.btnIngresarAcceso.Size = new System.Drawing.Size(100, 45);
            this.btnIngresarAcceso.TabIndex = 5;
            this.btnIngresarAcceso.Text = "Ingresar ";
            this.btnIngresarAcceso.UseVisualStyleBackColor = false;
            this.btnIngresarAcceso.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 6;
            // 
            // formAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(231, 130);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnIngresarAcceso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodigoacceso);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(247, 169);
            this.Name = "formAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigo de Acceso";
            this.Load += new System.EventHandler(this.formAcceso_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formAcceso_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigoacceso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresarAcceso;
        private System.Windows.Forms.Label lbl1;
    }
}
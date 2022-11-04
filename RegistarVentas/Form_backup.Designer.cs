namespace RegistarVentas
{
    partial class Form_backup
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
            this.Gbox_backup = new System.Windows.Forms.GroupBox();
            this.Txt_guardar_ruta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_backup = new System.Windows.Forms.Button();
            this.Btn_buscarlugar = new System.Windows.Forms.Button();
            this.Gbox_backup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbox_backup
            // 
            this.Gbox_backup.BackColor = System.Drawing.Color.White;
            this.Gbox_backup.Controls.Add(this.Txt_guardar_ruta);
            this.Gbox_backup.Controls.Add(this.label1);
            this.Gbox_backup.Controls.Add(this.Btn_backup);
            this.Gbox_backup.Controls.Add(this.Btn_buscarlugar);
            this.Gbox_backup.Location = new System.Drawing.Point(138, 116);
            this.Gbox_backup.Name = "Gbox_backup";
            this.Gbox_backup.Size = new System.Drawing.Size(394, 117);
            this.Gbox_backup.TabIndex = 2;
            this.Gbox_backup.TabStop = false;
            this.Gbox_backup.Text = "Back up DataBase";
            // 
            // Txt_guardar_ruta
            // 
            this.Txt_guardar_ruta.Location = new System.Drawing.Point(77, 34);
            this.Txt_guardar_ruta.Name = "Txt_guardar_ruta";
            this.Txt_guardar_ruta.Size = new System.Drawing.Size(210, 20);
            this.Txt_guardar_ruta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guardar en:";
            // 
            // Btn_backup
            // 
            this.Btn_backup.Location = new System.Drawing.Point(304, 61);
            this.Btn_backup.Name = "Btn_backup";
            this.Btn_backup.Size = new System.Drawing.Size(75, 23);
            this.Btn_backup.TabIndex = 0;
            this.Btn_backup.Text = "Back Up";
            this.Btn_backup.UseVisualStyleBackColor = true;
            this.Btn_backup.Click += new System.EventHandler(this.Btn_backup_Click);
            // 
            // Btn_buscarlugar
            // 
            this.Btn_buscarlugar.Location = new System.Drawing.Point(304, 32);
            this.Btn_buscarlugar.Name = "Btn_buscarlugar";
            this.Btn_buscarlugar.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscarlugar.TabIndex = 0;
            this.Btn_buscarlugar.Text = "Buscar";
            this.Btn_buscarlugar.UseVisualStyleBackColor = true;
            this.Btn_buscarlugar.Click += new System.EventHandler(this.Btn_buscarlugar_Click);
            // 
            // Form_backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 481);
            this.Controls.Add(this.Gbox_backup);
            this.Name = "Form_backup";
            this.Text = "Form_backup";
            this.Gbox_backup.ResumeLayout(false);
            this.Gbox_backup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Gbox_backup;
        private System.Windows.Forms.TextBox Txt_guardar_ruta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_backup;
        private System.Windows.Forms.Button Btn_buscarlugar;
    }
}
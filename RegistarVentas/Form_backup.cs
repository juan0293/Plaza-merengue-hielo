using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistarVentas
{
    public partial class Form_backup : Form
    {
        public Form_backup()
        {
            InitializeComponent();
        }
        public void bakup()
        {
            try
            {
                using (SqlConnection conn = Conectado.conexion())
                {
                    string database = conn.Database.ToString();


                    if (Txt_guardar_ruta.Text == string.Empty)
                    {
                        MessageBox.Show("Por Favor elija la Ruta para guardar el Backup", "Error en la Ruta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        string cmd = "BACKUP DATABASE [" + database + "] TO DISK ='" + Txt_guardar_ruta.Text + "\\" + "beuty" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                        using (SqlCommand command = new SqlCommand(cmd, conn))
                        {
                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();

                            }
                            command.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("El Backup se Realizo exitosamente", "Backup Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Btn_backup.Enabled = false;
                        }

                    }

                }
            }
            catch { }

        }
        private void Btn_backup_Click(object sender, EventArgs e)
        {
            bakup();
        }

        private void Btn_buscarlugar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Txt_guardar_ruta.Text = dlg.SelectedPath;
                Btn_backup.Enabled = true;
            }
        }
    }
}

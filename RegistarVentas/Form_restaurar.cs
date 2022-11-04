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
    public partial class Form_restaurar : Form
    {
        public Form_restaurar()
        {
            InitializeComponent();
        }

        private void Btn_buscar_restaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER databae backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Txt_buscar_ruta.Text = dlg.FileName;
                Btn_restaurar.Enabled = true;
            }
        }

        private void Btn_restaurar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectado.conexion())
            {
                string database = conn.Database.ToString();
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                try
                {
                    string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand bu2 = new SqlCommand(sqlStmt2, conn);
                    bu2.ExecuteNonQuery();

                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + Txt_buscar_ruta.Text + "'WITH REPLACE;";
                    SqlCommand bu3 = new SqlCommand(sqlStmt3, conn);
                    bu3.ExecuteNonQuery();

                    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand bu4 = new SqlCommand(sqlStmt4, conn);
                    bu4.ExecuteNonQuery();

                    MessageBox.Show("Base de Datos Restaurada exitosamente", "BD Restaurada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

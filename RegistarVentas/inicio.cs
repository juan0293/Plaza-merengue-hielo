using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistarVentas
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
     
        private void btnretornar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btninicar_Click(object sender, EventArgs e)
        {

            


        }

    private void inicio_Load(object sender, EventArgs e)
        {
           
        }

        private void txtmontoinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                MessageBox.Show("Favor debe ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtmontoinicial_Leave(object sender, EventArgs e)
        {
         
        }

        private void inicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btninicar_Click(sender, e);
            }
        }
    }
}

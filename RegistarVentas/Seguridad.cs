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
    public partial class formAcceso : Form
    {
        public formAcceso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void formAcceso_Load(object sender, EventArgs e)
        {
           

        }

        private void txtcodigoacceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void formAcceso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
               ;
            }
        }
    }
}

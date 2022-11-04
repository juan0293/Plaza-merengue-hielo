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
    public partial class Form_lavador : Form
    {
        public string id_s;
        public Form_lavador()
        {
            InitializeComponent();
        }

        private void Form_lavador_Load(object sender, EventArgs e)
        {
          
        }

        private void txt_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
         
        }
        private void dgv_equipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow DGV = dgv_equipo.Rows[e.RowIndex];
                txt_Nombre.Text = DGV.Cells[1].Value.ToString();
                txt_apellido.Text = DGV.Cells[2].Value.ToString();
                txt_porcentaje.Text = DGV.Cells[3].Value.ToString();
                txt_telefono.Text = DGV.Cells[5].Value.ToString();
                txt_cedula.Text = DGV.Cells[4].Value.ToString();
                id_s = DGV.Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txt_apellido.Clear();
            txt_Nombre.Clear();
            txt_porcentaje.Clear();
            txt_cedula.Clear();
            txt_telefono.Clear();
        }
    }
}

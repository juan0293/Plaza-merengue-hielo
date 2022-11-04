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
    public partial class Form_pag0 : Form
    {
        double porcentaje = 0.00;
        string lavador;
        public Form_pag0()
        {
            InitializeComponent();
        }
        public void empleado()
        {
           
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
         
        }

        private void Form_pag0_Load(object sender, EventArgs e)
        {
            empleado();
        }

        private void cbo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            cbo_usuario.SelectedIndex = -1;
            txt_articulo.Clear();
            txt_total.Clear();
            txt_vendido.Clear();
            txt_porcentaje.Clear();
            Dgv_cierres.Rows.Clear();

        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
          
        }
    }
}
    


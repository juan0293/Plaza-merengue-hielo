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
    public partial class cierres : Form
    {
        public cierres()
        {
            InitializeComponent();
        }

        private void cierres_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                datos dat = new datos();
                form_imprimir_gastos cierres = new form_imprimir_gastos();

                dat.fecha = dtp_fecha.Text;
                dat.articulos = txt_articulo.Text;
                dat.total = txt_vendido.Text;
                dat.usuario = cbo_usuario.Text;
                cierres.datos.Add(dat);
                cierres.Show();

                }
            catch { }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

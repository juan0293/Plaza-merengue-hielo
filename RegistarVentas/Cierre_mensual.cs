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
    public partial class Cierre_mensual : Form
    {
        public Cierre_mensual()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                datos dat = new datos();
                print_report cierres = new print_report();

                dat.fecha_inicial = dtp_fecha_inicio.Text;
                dat.fecha_final = dtp_fecha_final.Text;
                dat.articulos = txt_articulo.Text;
                dat.total = txt_vendido.Text;
                dat.usuario = Global.usuario1;
                cierres.datos.Add(dat);
                cierres.Show();

            }
            catch { }
        }
    }
}

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
    public partial class Form_servicio : Form
    {
        public string id_emleado;
        public Form_servicio()
        {
            InitializeComponent();
        }
        public void resfrescar()
        {
          
        }
        private void Txt_devueltaVf_TextChanged(object sender, EventArgs e)
        {

        }
        public void empleado()
        {
          
        }

        public void factura()
        {
          
              
        }
        private void Form_servicio_Load(object sender, EventArgs e)
        {
            resfrescar();
            empleado();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
              

                foreach (DataGridViewRow row in dgv_equipo.SelectedRows)
                {
                    string cod = row.Cells[0].Value.ToString();
                    string nombre = row.Cells[1].Value.ToString();
                    double precio =Convert.ToDouble(row.Cells[2].Value.ToString());
                    dgv_servicio.Rows.Add(cod, nombre, precio);


                }

                double suma = 0;
                foreach (DataGridViewRow ro in dgv_servicio.Rows)
    

                {
                    
                    suma += Convert.ToDouble(ro.Cells["precio_t"].Value);

                }
                txt_total.Text = Convert.ToString(suma);

                Double balance_hoy;
                if (Double.TryParse(txt_total.Text, out balance_hoy))
                    txt_total.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", balance_hoy);

            }
            catch { }
        }

        private void cbo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void Txt_signo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_servicio.Rows.Remove(dgv_servicio.CurrentRow);
                double suma = 0;


                foreach (DataGridViewRow row in dgv_servicio.Rows)


                {
                    suma += Convert.ToDouble(row.Cells["precio_t"].Value);


                }

                txt_total.Text = Convert.ToString(suma);

                Double balance_hoy;
                if (Double.TryParse(txt_total.Text, out balance_hoy))
                    txt_total.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", balance_hoy);

            }
            catch { }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            factura();
        }
    }
}

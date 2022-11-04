using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistarVentas
{
    public partial class Form_cxc : Form
    {
        public Form_cxc()
        {
            InitializeComponent();
        }
        public void listarnombre()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    string nombre = Convert.ToString(txtcedula.Text.Trim());

                    viewCreditoBindingSource.DataSource = db.View_Credito.ToList().Where(c => c.Nombre == nombre);


                }

            }

            catch { }
        }
        public void listarapellido()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    string nombre = Convert.ToString(txtcedula.Text.Trim());

                    viewCreditoBindingSource.DataSource = db.View_Credito.ToList().Where(c => c.Apellidos == nombre);


                }

            }

            catch { }
        }
        public void listartodos()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    //string nombre = Convert.ToString(txtcedula.Text.Trim());

                    viewCreditoBindingSource.DataSource = db.View_Credito.ToList();


                }

            }

            catch { }
        }
        public void operacion()
        {
            try
            {
                //Capital

                double total = 0.00; total = dgvCategorias.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[3].Value));
                txt_total.Text = total.ToString();

                Double Tpago = 0.00;
                if (Double.TryParse(txt_total.Text, out Tpago))
                    txt_total.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);

                //Ganancias 





            }
            catch { }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_cxc_Load(object sender, EventArgs e)
        {
            listartodos();
            operacion();
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            if (rdb_nombre.Checked == true && rdb_apellido.Checked == false)
            {
                listarnombre();
                operacion();
            }

           else if (rdb_nombre.Checked == false && rdb_apellido.Checked == true)
            {
                listarapellido();
                operacion();
            }

            else
            {
                MessageBox.Show("Por favor seleccionar una opcion de busquedad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picbActualizar_Click(object sender, EventArgs e)
        {
            listartodos();
            operacion();
        }
    }
}

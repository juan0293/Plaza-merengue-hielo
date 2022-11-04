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
    public partial class Form_comision : Form
    {
        public int empleadoid;
        public double monto_comision;
        public Form_comision()
        {
            InitializeComponent();
        }
        public void listarempleado()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.empleado;
                    foreach (var oempleado in lst)
                    {
                        cboempleado.Items.Add(oempleado.nombre);
                    }

                }

            }

            catch { }
        }
        public void listarIDempleado()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                    var lst = db.empleado.Where(c => c.nombre == cboempleado.Text);
                    foreach (var oempleado in lst)
                    {
                        empleadoid = oempleado.idempleado;
                        monto_comision =Convert.ToDouble(oempleado.comision);
                    }
                }
            }
            catch { }
        }
        public void listarreporte()
        {
            try
            {
                DateTime startDate = Convert.ToDateTime(dtpDateinicio.Text);
                DateTime endDate = Convert.ToDateTime(dtpDatefin.Text);
                using (beutyEntities db = new beutyEntities())

                {

                    reparacionBindingSource.DataSource = db.reparacion.ToList().Where(f => f.fecha >= startDate && f.fecha <= endDate && f.empledoid == empleadoid);

                }
            }
            catch { }
        }
        public void operacion()
        {
            try
            {
                //Capital

                double total = 0.00; total = dgvproducto.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[2].Value));
                txttotal.Text = total.ToString();

                Double Tpago = 0.00;
                if (Double.TryParse(txttotal.Text, out Tpago))
                    txttotal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);
                double comosionganada = total * monto_comision / 100;
                txt_comision.Text = comosionganada.ToString();
                Double Tpago1 = 0.00;
                if (Double.TryParse(txt_comision.Text, out Tpago1))
                    txt_comision.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago1);
                //Ganancias 


            }
            catch { }

        }
        private void Form_comision_Load(object sender, EventArgs e)
        {
            listarempleado();
        }

        private void cboempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarIDempleado();
        }

        private void picimprimir_Click(object sender, EventArgs e)
        {
            if(cboempleado.Text == "")
            {
                MessageBox.Show("Por favor seleccionar el empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                listarreporte();
                operacion();
            }
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

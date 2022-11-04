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
    public partial class Form_gastos_report : Form
    {
        public Form_gastos_report()
        {
            InitializeComponent();
        }
        public void listarreporte()
        {
            try
            {
                DateTime startDate = Convert.ToDateTime(dtpDateinicio.Text);
                DateTime endDate = Convert.ToDateTime(dtpDatefin.Text);
                using (beutyEntities db = new beutyEntities())

                {

                   gastoBindingSource.DataSource = db.gasto.ToList().Where(f => f.fecha >= startDate && f.fecha <= endDate);

                }
            }
            catch { }
        }
        public void listarALL()
        {
            try
            {
                DateTime startDate = Convert.ToDateTime(dtpDateinicio.Text);
                DateTime endDate = Convert.ToDateTime(dtpDatefin.Text);
                using (beutyEntities db = new beutyEntities())

                {

                    gastoBindingSource.DataSource = db.gasto.ToList().Where(f => f.estado == true);

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
                      .Sum(t => Convert.ToDouble(t.Cells[3].Value));
                txttotal.Text = total.ToString();

                Double Tpago = 0.00;
                if (Double.TryParse(txttotal.Text, out Tpago))
                    txttotal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);

                //Ganancias 
            

               


            }
            catch { }

        }
        public void impfactura()
        {
            Form_print_gastos fat = new Form_print_gastos();
            for (int i = 0; i < dgvproducto.Rows.Count - 0; i++)
            {
                datos dat = new datos();
                dat.fecha = DateTime.Now.ToString(); 
                dat.fecha = dgvproducto.Rows[i].Cells[1].Value.ToString();
                dat.articulos = dgvproducto.Rows[i].Cells[2].Value.ToString();
                dat.usuario = dgvproducto.Rows[i].Cells[3].Value.ToString();      
                dat.total = txttotal.Text;
               
                dat.fecha_inicial = dtpDateinicio.Text;
                dat.fecha_final = dtpDatefin.Text;
                dat.logo = Global.logo;
                dat.descripcion = Global.descripcion;
                dat.rnc = Global.rnc;
                dat.instegram = Global.instegram;
                dat.whatsaap = Global.telefono;


                fat.datos.Add(dat);

            }
            fat.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_gastos_report_Load(object sender, EventArgs e)
        {
            listarALL();
        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            listarreporte();
            operacion();
        }

        private void picimprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo >>>>>>>>>>>", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            impfactura();
        }
    }
}

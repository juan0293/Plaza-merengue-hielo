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
    public partial class Form_inventario : Form
    {
        public Form_inventario()
        {
            InitializeComponent();
        }
        public void articulos()
        {
            try
            {
                foreach (DataGridViewRow row in dgvproducto.Rows)
                {

                    double cantidad = Convert.ToDouble(row.Cells[4].Value);


                    if (cantidad <= 0)
                    {
                        row.Cells[4].Value = "0";

                    }


                }


            }
            catch { }


        }
        public void listarexistencia()
        {
            try
            {
                foreach (DataGridViewRow row in dgvproducto.Rows)
                {
                    double existencia = Convert.ToDouble(row.Cells[2].Value) - Convert.ToDouble(row.Cells[3].Value);

                    row.Cells[4].Value = existencia;





                }


            }
            catch { }

        }
        public void listarcapital()
        {
            try
            {
                foreach (DataGridViewRow row in dgvproducto.Rows)
                {

                    double capital = Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[5].Value);
                    double ganacias = Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[6].Value);


                    row.Cells[7].Value = capital;
                    row.Cells[8].Value = ganacias;




                }


            }
            catch { }

        }
        public void listarInventario()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    viewreporteinventarioBindingSource.DataSource = db.View_reporte_inventario.ToList().Where(p => p.estatus == true);

                }
            }
            catch { }
        }
        public void operacion()
        {
            try
            {
                //Capital

                double totalcapital = 0.00; totalcapital = dgvproducto.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[7].Value));
                txtcapital.Text = totalcapital.ToString();

                Double Tpago = 0.00;
                if (Double.TryParse(txtcapital.Text, out Tpago))
                    txtcapital.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);



                //Ganancias 
                double totalganancias = 0.00; totalganancias = dgvproducto.Rows.Cast<DataGridViewRow>()

                     .Sum(t => Convert.ToDouble(t.Cells[8].Value));
                double ganancias = totalganancias - totalcapital;

                txtGanancias.Text = ganancias.ToString();

                Double Tpago1 = 0.00;
                if (Double.TryParse(txtGanancias.Text, out Tpago1))
                    txtGanancias.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago1);
                //Capita + Ganancias 
                double total = Convert.ToDouble(txtcapital.Text) + Convert.ToDouble(txtGanancias.Text);
                txttotal.Text = total.ToString();
                Double Tpago2 = 0.00;
                if (Double.TryParse(txttotal.Text, out Tpago2))
                    txttotal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

                //total Articulos 
                double totalarticulos = 0.00; totalarticulos = dgvproducto.Rows.Cast<DataGridViewRow>()

                     .Sum(t => Convert.ToDouble(t.Cells[4].Value));
                txt_totalarticulos.Text = totalarticulos.ToString();


            }
            catch { }

        }
        public void impfactura()
        {
            Form_print_inventario fat = new Form_print_inventario();
            for (int i = 0; i < dgvproducto.Rows.Count - 0; i++)
            {
                datos dat = new datos();
                dat.fecha = DateTime.Now.ToString(); ;

                dat.articulos = dgvproducto.Rows[i].Cells[0].Value.ToString();
                dat.cliente = dgvproducto.Rows[i].Cells[1].Value.ToString();
                dat.total = dgvproducto.Rows[i].Cells[4].Value.ToString();
                dat.fecha_inicial = dgvproducto.Rows[i].Cells[5].Value.ToString();
                dat.fecha_final = dgvproducto.Rows[i].Cells[6].Value.ToString();
                dat.monto_pago = dgvproducto.Rows[i].Cells[7].Value.ToString();
                //dat.subtotal = dgvproducto.Rows[i].Cells[6].Value.ToString();
                dat.devuelta = txt_totalarticulos.Text;
                dat.direcion = txtGanancias.Text;
                dat.descuento = txtcapital.Text;
                dat.logo = Global.logo;
                dat.descripcion = Global.descripcion;
                dat.rnc = Global.rnc;
                dat.instegram = Global.instegram;
                dat.whatsaap = Global.telefono;


                fat.datos.Add(dat);

            }
            fat.Show();
        }
        private void Form_inventario_Load(object sender, EventArgs e)
        {

            listarInventario();

            listarexistencia();
            articulos();
            listarcapital();
            operacion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picimprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo >>>>>>>>>>>", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            impfactura();
        }
    }
}

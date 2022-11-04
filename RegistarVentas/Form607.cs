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
    public partial class Form607 : Form
    {
        public Form607()
        {
            InitializeComponent();
        }

        public void listar()
        {
            dataGridView1.Rows.Clear();
            using (beutyEntities db = new beutyEntities())
            {
                DateTime fecha1 = Convert.ToDateTime(dtpDateinicio.Text);  
                DateTime fecha2 = Convert.ToDateTime(dtpDatefin.Text);
            

                var lst = db.venta.ToList().Where(f => f.fecha >= fecha1 && f.fecha <= fecha2 && f.tipodocumento == cbo_factura.Text);
                foreach (var oventa in lst)
                {


                   
                    dataGridView1.Rows.Add(oventa.cliente, oventa.rnc, oventa.fecha, oventa.ncf, oventa.monto, oventa.itebis, oventa.monto, oventa.tipodocumento);


                }
                operacion();
            }
        }
        private void Form607_Load(object sender, EventArgs e)
        {

        }
        public void operacion()
        {
            try
            {


                //Suma de total
                double total = 0.00; total = dataGridView1.Rows.Cast<DataGridViewRow>()
                   .Sum(t => Convert.ToDouble(t.Cells[6].Value));
                txt_total.Text = total.ToString();


                Double Tpago2 = 0.00;
                if (Double.TryParse(txt_total.Text, out Tpago2))
                    txt_total.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

                //display();



            }
            catch { }

        }
        public void imprimir()
        {
            try
            {

                Form_607_print rp1 = new Form_607_print();



                for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
                {
                    datos dat = new datos();

                    dat.logo = Global.logo;
                    dat.cliente = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    dat.rnc = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    dat.fecha = Convert.ToDateTime(dataGridView1.Rows[i].Cells[2].Value).ToString("dd/MM/yyyy");
                    dat.comprobante = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    dat.subtotal = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value).ToString("#,##0.00");
                    dat.itebis = Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value).ToString("#,##0.00");
                    dat.total = Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value).ToString("#,##0.00");
                    dat.tipo = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    dat.capital = txt_total.Text;

                    //dat.autorizacion = Dgv_Pacientes.Rows[i].Cells[2].Value.ToString();
                    //dat.cantidad = Convert.ToDouble(Dgv_Pacientes.Rows[i].Cells[9].Value.ToString());


                    rp1.datos.Add(dat);

                }

                rp1.Show();
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(cbo_factura.Text =="")
            {
                MessageBox.Show("Por favor seleccionar tipo de factura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listar();
            }
          
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].Cells[8].Value = "Eliminar";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["quitar"].Index && e.RowIndex >= 0)
                {

                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    operacion();

                }



            }


            catch { }
        }
    }
}

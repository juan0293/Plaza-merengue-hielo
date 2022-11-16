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
    public partial class Form_Ventas : Form
    {
        public Form_Ventas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        public void listarreporte()
        {
            try
            {
                DateTime startDate = Convert.ToDateTime(dtpDateinicio.Text);
                DateTime endDate = Convert.ToDateTime(dtpDatefin.Text);
                using (beutyEntities db = new beutyEntities())

                {

                    viewgananciasBindingSource.DataSource = db.View_ganancias.ToList().Where(f => f.fecha >= startDate && f.fecha <= endDate);
                    
                }
            }
            catch { }
        }

        public void listarreporte_cliente()
        {
            try
            {
                DateTime startDate = Convert.ToDateTime(dtpDateinicio.Text);
                DateTime endDate = Convert.ToDateTime(dtpDatefin.Text);
                using (beutyEntities db = new beutyEntities())

                {

                    viewgananciasBindingSource.DataSource = db.View_ganancias.ToList().Where(f => f.fecha >= startDate && f.fecha <= endDate && f.cliente == cbo_cliente.Text);

                }
                cbo_cliente.SelectedIndex = -1;
            }
            catch { }
        }
        public void listarCombo()
        {
            try
            {
                //DateTime startDate = Convert.ToDateTime(dtpDateinicio.Text);
                //DateTime endDate = Convert.ToDateTime(dtpDatefin.Text);
                using (beutyEntities db = new beutyEntities())

                {
                    clienteBindingSource.Clear();
                    clienteBindingSource.DataSource = db.Cliente.ToList();

                }
            }
            catch { }
        }

        public void listar_descuento()
        {
            try
            {
                dgv_descuento.Rows.Clear();
                DateTime startDate = Convert.ToDateTime(dtpDateinicio.Text);
                DateTime endDate = Convert.ToDateTime(dtpDatefin.Text);
                
                DateTime fecha;
                decimal descuento;
                int id_venta;
                using (beutyEntities db = new beutyEntities())
                {
                  var list = db.View_descuento.ToList().Where(f => f.fecha >= startDate && f.fecha <= endDate && f.estado == "Normal");

                    foreach (var odescuento in list)
                    {
                        fecha = Convert.ToDateTime(odescuento.fecha);
                        descuento = Convert.ToDecimal(odescuento.descuento);
                        id_venta = Convert.ToInt32(odescuento.idventa);

                        dgv_descuento.Rows.Add(fecha, descuento, id_venta);
                    }
                }

                
            }
            catch { }
        }
        public void operacion()
        {
            try
            {
                txt_total.Text = "0.00";
                txt_totalarticulos.Text = dgvproducto.Rows.Count.ToString();

                double Total_ventas_brutas = 0.00;
                Total_ventas_brutas = dgvproducto.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[5].Value));
                txtventasBrutas.Text = Convert.ToDecimal(Total_ventas_brutas).ToString("#,###,##0.00");

                double Total_descuentos = 0.00;
                Total_descuentos = dgv_descuento.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[1].Value));
                txt_descuentos.Text = Convert.ToDecimal(Total_descuentos).ToString("#,###,##0.00");

                double Total_ganancias = 0.00;
                Total_ganancias = dgvproducto.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[6].Value));
                txt_ganancias.Text = Convert.ToDecimal(Total_ganancias).ToString("#,###,##0.00");

                double bruto = Convert.ToDouble(txtventasBrutas.Text);  double ganancia = Convert.ToDouble(txt_ganancias.Text); double descuento = Convert.ToDouble(txt_descuentos.Text);

                txt_total.Text = Convert.ToDecimal(bruto+ganancia-descuento).ToString("#,###,##0.00");

            }
            catch { }

        }
        public void impfactura()
        {
            try
            {
                printventas fat = new printventas();
                for (int i = 0; i < dgvproducto.Rows.Count - 0; i++)
                {
                    datos dat = new datos();
                    dat.fecha = DateTime.Now.ToString(); ;


                    dat.articulos = dgvproducto.Rows[i].Cells[1].Value.ToString();
                    dat.cliente = dgvproducto.Rows[i].Cells[2].Value.ToString();
                    dat.total = dgvproducto.Rows[i].Cells[3].Value.ToString();
                    dat.metodo = dgvproducto.Rows[i].Cells[4].Value.ToString();
                    dat.monto_pago = dgvproducto.Rows[i].Cells[5].Value.ToString();

                    dat.factura = dgvproducto.Rows[i].Cells[6].Value.ToString();
                    dat.subtotal = "0.00";
                    dat.devuelta = txt_totalarticulos.Text;
                    dat.descuento = txt_total.Text;
                    dat.efectivo = txtventasBrutas.Text;
                    dat.direcion = txt_ganancias.Text;
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
            catch { }
        }
        private void Form_Ventas_Load(object sender, EventArgs e)
        {
           
        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            if(cbo_cliente.Text =="")
            {
                listarreporte();
                listar_descuento();
                operacion();

            }
            else
            {
                listarreporte_cliente();
                listar_descuento();
                operacion();
            }
        


        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picimprimir_Click(object sender, EventArgs e)
        {
          
            impfactura();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbo_cliente_DropDown(object sender, EventArgs e)
        {
            listarCombo();
        }
    }
}

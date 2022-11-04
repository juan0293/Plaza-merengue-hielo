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
    public partial class Ingresos : Form
  
    {
     public string cliente,apellido, cedula, idfactura;

        public double resultado, resultado2 =0.00;
    public Ingresos()
        {
            InitializeComponent();

        }
        public void udpcxc()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                   {
                   
                        int idusuario = Convert.ToInt32(idfactura);

                        CXC ocxc = db.CXC.Find(idusuario);
                        ocxc.Monto = resultado;
                        db.Entry(ocxc).State = EntityState.Modified;
                        db.SaveChanges();
                        //MessageBox.Show("Pago Realizado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    addpagos();
                  
                   
                }

                
            }
            catch { }
        }
        public void deletecxc()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idusuario = Convert.ToInt32(idfactura);

                        CXC ocxc = db.CXC.Find(idusuario);
                      
                        db.Entry(ocxc).State = EntityState.Deleted;
                        db.SaveChanges();
                        //MessageBox.Show("Pago Realizado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addpagos();
                     
                       
                    }

                }
            }
            catch { }
        }
        public void listarcxc()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    viewcxcBindingSource.DataSource = db.View_cxc.ToList().Where(c => c.Cedula == cedula.Trim()).OrderBy(f => f.Fecha);


                }

            }

            catch { }
        }
        public void pagar()
        {
            try
            {
                double montopago = Convert.ToDouble(txt_monto_pagar.Text);
                double montopagado = Convert.ToDouble(txt_Valor_pago.Text);
                resultado = montopago - montopagado;
            }
            catch { }
        }
        public void impfactura()
        {
            pay_ingresos fat = new pay_ingresos();

            datos dat = new datos();
            dat.fecha = DateTime.Now.ToString(); ;
            dat.usuario = Global.nombre.ToString();
            dat.factura = idfactura;
            dat.subtotal = txt_monto_pagar.Text;
            dat.monto_pago = txt_Valor_pago.Text;
            dat.cliente= cliente;
            dat.direcion = apellido;
            dat.devuelta = resultado.ToString();
            dat.logo = Global.logo;
            dat.descripcion = Global.descripcion;
            dat.rnc = Global.rnc;
            dat.instegram = Global.instegram;
            dat.whatsaap = Global.telefono;
            fat.datos.Add(dat);
            fat.Show();
        }
        public void addpagos()
        {
            try
            {


                using (beutyEntities db = new beutyEntities())

                {
                    pagos opago = new pagos();
                    opago.idusuario = Convert.ToInt32(Global.iduser);
                    opago.monto = Convert.ToDouble(txt_Valor_pago.Text);
                    opago.fecha = DateTime.Now;

                    db.pagos.Add(opago);
                    db.SaveChanges();
                   
                }

            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        public void operacion()
        {
            try
            {
              

                //Suma de total
                double total = 0.00; total = dgvproducto.Rows.Cast<DataGridViewRow>()
                   .Sum(t => Convert.ToDouble(t.Cells[5].Value));
                txt_monto_pagar.Text = total.ToString();

           
                Double Tpago2 = 0.00;
                if (Double.TryParse(txt_monto_pagar.Text, out Tpago2))
                    txt_monto_pagar.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

                //display();



            }
            catch { }

        }

      
        private void Recibo_Ingreso_Load(object sender, EventArgs e)
        {
            txt_Valor_pago.Text = "0.00";
            txt_monto_pagar.Text = "0.00";
            listarcxc();
            lbcliente.Text = cliente.ToString();
            operacion();

        }

        public void addpago()
        {
            impfactura();
            impfactura();

            using (beutyEntities db = new beutyEntities())

            {
                double monto_pago = 0.00;
                monto_pago = Convert.ToDouble(txt_Valor_pago.Text);

                for (int i = 0; i < dgvproducto.Rows.Count - 0; i++)
                {

                    monto_pago -= Convert.ToDouble(dgvproducto.Rows[i].Cells[5].Value);
                    int pago = i + 1;
                    if(Convert.ToDouble(txt_Valor_pago.Text) >= Convert.ToDouble(dgvproducto.Rows[i].Cells[5].Value))
                    {
                       
                        int idfactura = Convert.ToInt32(dgvproducto.Rows[i].Cells[1].Value);
                        CXC ocxc = db.CXC.Find(idfactura);
                        db.Entry(ocxc).State = EntityState.Deleted;
                        db.SaveChanges();

                        //pagos
                        pagos opago = new pagos();
                        opago.idusuario = Convert.ToInt32(Global.iduser);
                        opago.monto = Convert.ToDouble(dgvproducto.Rows[i].Cells[1].Value);
                        opago.fecha = DateTime.Now;
                        db.pagos.Add(opago);
                        db.SaveChanges();
                       
                       

                    }

                   else  if (Convert.ToDouble(txt_Valor_pago.Text) <= Convert.ToDouble(dgvproducto.Rows[i].Cells[5].Value))
                    {
                       
                        int idfactura = Convert.ToInt32(dgvproducto.Rows[i].Cells[1].Value);
                        CXC ocxc = db.CXC.Find(idfactura);
                        ocxc.Monto = Convert.ToDouble(dgvproducto.Rows[i].Cells[5].Value) - Convert.ToDouble(txt_Valor_pago.Text);
                        db.Entry(ocxc).State = EntityState.Modified;
                        db.SaveChanges();

                        //pagos
                        pagos opago = new pagos();
                        opago.idusuario = Convert.ToInt32(Global.iduser);
                        opago.monto = Convert.ToDouble(dgvproducto.Rows[i].Cells[5].Value) - Convert.ToDouble(txt_Valor_pago.Text);
                        opago.fecha = DateTime.Now;
                        db.pagos.Add(opago);
                        db.SaveChanges();
                        dgvproducto.Rows.Clear();


                    }

                   
                    txt_Valor_pago.Text = monto_pago.ToString();

                }
               
                listarcxc();
                operacion();
                txt_Valor_pago.Text = "0.00";
                MessageBox.Show("Pago Realizado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txt_Valor_pago_Click(object sender, EventArgs e)
        {
            txt_Valor_pago.Clear();
        }

        private void txt_cedula_recibo_TextChanged(object sender, EventArgs e)
        {
            listarcxc();
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvproducto.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        idfactura = row.Cells[1].Value.ToString();
                        cliente = row.Cells[3].Value.ToString();
                        apellido = row.Cells[4].Value.ToString();
                        txt_monto_pagar.Text = row.Cells[5].Value.ToString();
                        Double Tpago;
                        if (Double.TryParse(txt_monto_pagar.Text, out Tpago))
                            txt_monto_pagar.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);

                    }

                }
              
            }
            catch { }
        }

        private void txt_monto_pagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Valor_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn1_guardar_Click(object sender, EventArgs e)
        {
          
            if (txt_monto_pagar.Text == "0.00")
            {
                MessageBox.Show("El monto debe ser mayor que cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else  if (txt_Valor_pago.Text == "")
            {
                MessageBox.Show("Por favor Agregar el valor del pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
            {
                addpago();
            }
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
         
        }

      
    }
}

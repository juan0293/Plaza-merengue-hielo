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
    public partial class Form_Ajustar : Form
    {
        public delegate void pasar1(string dato);
        public event pasar1 pasado1;
        public int id_producto;
        public double nuevacantidad;
        public Form_Ajustar()
        {
            InitializeComponent();
        }
        public void updateinventario()
        {

            try
            {


                using (beutyEntities db = new beutyEntities())
                {

                    Inventario oinventario = new Inventario();
                    oinventario.Producto_Id = id_producto;
                    oinventario.entrada = Convert.ToDouble(txtcantidad.Text); ;
                    oinventario.salida = 0;
                    oinventario.Fecha_Ingreso = DateTime.Now;
                    oinventario.tipo_operacion = 1;
                    db.Inventario.Add(oinventario);
                    db.SaveChanges();
                    MessageBox.Show("Producto Ajustado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pasado1(txt_existencia.Text);

                }


            }
            catch { }


        }
        public void ajustarInventario()
        {

            try
            {


                using (beutyEntities db = new beutyEntities())
                {

                    Inventario oinventario = new Inventario();
                    oinventario.Producto_Id = id_producto;
                    oinventario.salida = Convert.ToDouble(txt_existencia.Text); 
                    oinventario.entrada = 0;
                    oinventario.Fecha_Ingreso = DateTime.Now;
                    oinventario.tipo_operacion = 2;
                    db.Inventario.Add(oinventario);
                    db.SaveChanges();
                    MessageBox.Show("Producto Ajustado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pasado1(txt_existencia.Text);

                }


            }
            catch { }


        }
        public void updateproducto()
        {
            try
            {
                double existencia = Convert.ToDouble(txt_existencia.Text);
                double cantidad = Convert.ToDouble(txtcantidad.Text);
              
                using (beutyEntities db = new beutyEntities())
                {

                    foreach (var oinventario in db.Producto.Where(c => c.Codigo_ID == id_producto))
                    {

                        oinventario.precio_neto = Convert.ToDouble(txtcompra.Text);
                        oinventario.precio_salida = Convert.ToDouble(txtprecioventa.Text);

                        db.Entry(oinventario).State = EntityState.Modified;

                    }

                    db.SaveChanges();
                    pasado1(txt_existencia.Text);

                }
            }
            catch { }
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pic_atras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Ajustar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtcompra_Leave(object sender, EventArgs e)
        {
            Double Tpago;
            if (Double.TryParse(txtcompra.Text, out Tpago))
                txtcompra.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);
        }

        private void txtprecioventa_Leave(object sender, EventArgs e)
        {
            Double Tpago;
            if (Double.TryParse(txtprecioventa.Text, out Tpago))
                txtprecioventa.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);
        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            Double Tpago;
            if (Double.TryParse(txtcantidad.Text, out Tpago))
                txtcantidad.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);
        }
        public void listarexistencia()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.View_stock.Where(c => c.Producto_Id == id_producto);
                    foreach (var ostock in lst)
                    {
                        txt_existencia.Text = ostock.existencia.ToString();
                    }

                }

            }

            catch { }
        }
        private void picGuardar_Click(object sender, EventArgs e)
        {
            updateproducto();
            updateinventario();
            Close();
        }
        public void boton()
        {
            try
            {


                if(Convert.ToDouble(txt_existencia.Text) >0)
                {
                    picajustar.Enabled = true;
                }
            
               
            }
            catch { }
        }
        private void Form_Ajustar_Load(object sender, EventArgs e)
        {
           
            listarexistencia();
            boton();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ajustarInventario();
            Hide();
        }
    }
}

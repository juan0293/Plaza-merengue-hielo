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
    public partial class Registro_Producto : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;

        public Registro_Producto()
        {
            InitializeComponent();
        }

        public string id_s, idproduct;
        public int idprd, idcategoria, idimpuesto, idprovedor, idproducto, ideditar;
      
        public void listarcategoria()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.categoria;
                    foreach (var ocategoria in lst)
                    {
                        cbocategorias.Items.Add(ocategoria.nombre);
                    }

                }

            }

            catch { }
        }
        public void listarproveedor()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.suplidor;
                    foreach (var oproveedor in lst)
                    {
                        cboProveedor.Items.Add(oproveedor.nombre);
                    }

                }

            }

            catch { }
        }
        public void listarIDcategoria()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.categoria.Where(c => c.nombre == cbocategorias.Text);
                    foreach (var ocategoria in lst)
                    {
                        idcategoria = ocategoria.idcategoria;
                    }

                }

            }

            catch { }
        }
        public void listarIDproveedor()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.suplidor.Where(c => c.nombre == cboProveedor.Text); ;
                    foreach (var oprovedor in lst)
                    {
                        idprovedor = oprovedor.idsuplidor;
                    }

                }

            }

            catch { }
        }
        public void addproductos()
        {
            //try
            //{
                if (txt_codigo.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de codigo.");
                    txt_codigo.BackColor = Color.Crimson;
                }
                if (txtnombre.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de nombre.");
                    txtnombre.BackColor = Color.Crimson;
                }
                if (txtDetalle.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de detalle.");
                    txtDetalle.BackColor = Color.Crimson;
                }
                if (txt_precioentrada.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de Precio de compra.");
                    txt_precioentrada.BackColor = Color.Crimson;

                }
                if (txt_preciosalida.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de Precio de venta.");
                    txt_preciosalida.BackColor = Color.Crimson;
                }
                if (cbocategorias.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de categorias.");
                    cbocategorias.BackColor = Color.Crimson;
                }
                if (cboProveedor.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de Proveedor.");
                    cboProveedor.BackColor = Color.Crimson;
                }
                if (cbo_itebis.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de ITEBIS.");
                    cbo_itebis.BackColor = Color.Crimson;
                }
                if (txt_cantidad.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de Precio de Cantidad.");
                    cbo_itebis.BackColor = Color.Crimson;
                }
                else
                {

                    using (beutyEntities db = new beutyEntities())

                    {
                        Producto oproducto = new Producto();
                        oproducto.codigo = txt_codigo.Text;
                        oproducto.Nombre = txtnombre.Text;
                        oproducto.Categoria = idcategoria;
                        oproducto.Suplidor = idprovedor;
                        oproducto.Descripcion_Producto = txtDetalle.Text;
                        oproducto.estatus = true;
                        if (chItbis.Checked == true)
                        {
                            oproducto.itbis = true;
                        }
                        else
                        {
                            oproducto.itbis = false;
                        }
                    oproducto.precio_neto = Convert.ToDouble(txt_precioentrada.Text);
                        oproducto.precio_salida = Convert.ToDouble(txt_preciosalida.Text);
                        oproducto.impuesto = Convert.ToDouble(cbo_itebis.Text);
                        oproducto.fecha_entrada = DateTime.Now;
                        db.Producto.Add(oproducto);
                        db.SaveChanges();

                    }
                }
            //}
            //catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void listarIDproducto()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.Producto.Where(i => i.codigo == txt_codigo.Text);
                    foreach (var oproducto in lst)
                    {
                        idproducto = oproducto.Codigo_ID;

                    }

                }

            }

            catch { }
        }
        public void updateproductos()
        {
            try
            {
                if (txt_codigo.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de codigo.");
                    txt_codigo.BackColor = Color.Crimson;
                }
                if (txtnombre.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de nombre.");
                    txtnombre.BackColor = Color.Crimson;
                }
                if (txtDetalle.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de detalle.");
                    txtDetalle.BackColor = Color.Crimson;
                }
             
                if (cbocategorias.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de categorias.");
                    cbocategorias.BackColor = Color.Crimson;
                }
                if (cboProveedor.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de Proveedor.");
                    cboProveedor.BackColor = Color.Crimson;
                }
                if (cbo_itebis.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de ITEBIS.");
                    cbo_itebis.BackColor = Color.Crimson;
                }
                else
                {

                    using (beutyEntities db = new beutyEntities())

                    {
                    int idprod = Convert.ToInt32(idproduct);

                    foreach (var oproducto in db.Producto.Where(c => c.Codigo_ID == idprod))
                        {
                            oproducto.codigo = txt_codigo.Text;
                            oproducto.Nombre = txtnombre.Text;
                            oproducto.Categoria = idcategoria;
                            oproducto.Suplidor = idprovedor;
                            oproducto.Descripcion_Producto = txtDetalle.Text;
                            //oproducto.impuesto = Convert.ToDouble(cbo_itebis.Text);
                            if(chItbis.Checked ==true)
                            {
                                oproducto.itbis = true;
                            }
                            else
                            {
                                oproducto.itbis = false;
                            }
                            db.Producto.Add(oproducto);

                            db.Entry(oproducto).State = EntityState.Modified;

                        }
                        db.SaveChanges();
                        MessageBox.Show("Datos Actualizados");
                       
                        Close();

                    }
                }
            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void verificar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.Producto.Where(i => i.codigo == txt_codigo.Text && i.estatus ==true);
                    foreach (var oproducto in lst)
                    {
                        MessageBox.Show("Ya existe un producto registrado con el mismo codigo");
                        txt_codigo.Clear();
                        txt_codigo.Focus();

                    }

                }

            }

            catch { }
        }
        public void addinv()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {
                    Inventario oinvetario = new Inventario();

                    oinvetario.Producto_Id = idproducto;
                    oinvetario.entrada = Convert.ToDouble(txt_cantidad.Text);
                    oinvetario.salida = 0.00;
                    oinvetario.Fecha_Ingreso = DateTime.Now;
                    oinvetario.tipo_operacion = 1;
                    db.Inventario.Add(oinvetario);
                    db.SaveChanges();

                }
                MessageBox.Show("Producto Registrado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
             
            }
            catch { }

        }
        public void limpiar()
        {
            txt_codigo.Text = txtnombre.Text = txtDetalle.Text = txt_precioentrada.Text = txt_preciosalida.Text = txt_cantidad.Text = "";
            cbocategorias.SelectedIndex = -1;
            cbo_itebis.Items.Clear();
            cboProveedor.SelectedIndex = -1;

        }
        public void lb()
        {
            if (idproduct == null)
            {
                lbProducto.Text = "Nuevo Producto";
            }
            else
            {
                lbProducto.Text = "Editar Producto";
            }
        }
        public void guardar()
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de codigo.");
                txt_codigo.BackColor = Color.Crimson;
            }
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de nombre.");
                txtnombre.BackColor = Color.Crimson;
            }
            if (txtDetalle.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de detalle.");
                txtDetalle.BackColor = Color.Crimson;
            }
            if (txt_precioentrada.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de Precio de compra.");
                txt_precioentrada.BackColor = Color.Crimson;

            }
            if (txt_preciosalida.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de Precio de venta.");
                txt_preciosalida.BackColor = Color.Crimson;
            }
            if (cbocategorias.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de categorias.");
                cbocategorias.BackColor = Color.Crimson;
            }
            if (cboProveedor.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de Precio de Proveedor.");
                cboProveedor.BackColor = Color.Crimson;
            }
            if (cbo_itebis.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de Precio de ITEBIS.");
                cbo_itebis.BackColor = Color.Crimson;
            }
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de Precio de Cantidad.");
                cbo_itebis.BackColor = Color.Crimson;
            }
            else
            {
                addproductos();
                listarIDproducto();
                addinv();
            }

        }


        // Boton salir 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_precioentrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_preciosalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_cantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_codigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Registro_Producto_Load(object sender, EventArgs e)
        {
            if (idproduct == null)
            {

                chItbis.Checked = true;
            }
            //MessageBox.Show(txt_codigo.Text);
            txtDetalle.Focus();
          //  generar_id();
          //  check1.Checked = false;
         //   txt_codigo.ReadOnly = true;

            if (txt_codigo.Text == "")
            {
               
            }
            else
            {
                txt_cantidad.Visible = false;
                lbCantidad.Visible = false;
                txt_precioentrada.Visible = false;
                lbprecioVenta.Visible = false;
                lbprecioCompra.Visible = false;
                txt_preciosalida.Visible = false;
            }

            listarcategoria();
            listarproveedor();
            lb();
        }

        private void cbocategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarIDcategoria();
        }

        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarIDproveedor();
        }

        private void picbLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            generar_id();
            txtDetalle.Focus();
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            if (idproduct ==null)
            {
              
                            guardar();
                           // pasado(txtDetalle.Text);
                            generar_id();
            }
            else
            {
                updateproductos();
                pasado(txtDetalle.Text);
                generar_id();
               // txtnombre.Text = "Normal";

            }

        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Registro_Producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verificar();
            }
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if (check1.Checked == true)
            {
                generar_id();
                txt_codigo.ReadOnly = true;
            }
            else
            {
                txt_codigo.Clear();
                txt_codigo.ReadOnly = false;
            }


        }


        public void generar_id()
        {
            if (check1.Checked == true)
            {

                try
                {
                    double id = 0;
                    using (beutyEntities db = new beutyEntities())

                    {

                        var lst = db.Producto.ToList();
                        foreach (var oproducto in lst)
                        {
                            id = Convert.ToDouble(oproducto.Codigo_ID);
                            txt_codigo.Text = (id + 1).ToString();
                        }
                      
                    }
                }

                catch { }
            }
        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {
            txtnombre.Text = txtDetalle.Text; 
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (idproduct == null)
            {
                verificar();
            }
            else
            {
               
            }
           
        }

        private void txt_Precio_Unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_Impuestos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_precioentrada_Leave(object sender, EventArgs e)
        {
            Double Tpago;
            if (Double.TryParse(txt_precioentrada.Text, out Tpago))
                txt_precioentrada.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);
        }

        private void txt_preciosalida_Leave(object sender, EventArgs e)
        {
            Double Tpago;
            if (Double.TryParse(txt_preciosalida.Text, out Tpago))
                txt_preciosalida.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago);
        }

        private void txt_Precio_Neto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
    


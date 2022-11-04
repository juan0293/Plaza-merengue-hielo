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
    public partial class Form_cotizacion : Form
    {
        public string mensaje1, idcotiza;
        public int articulostotal;
        public double totalimpuestos = 0.00;
        public int idcotizacion;
        public Form_cotizacion()
        {
            InitializeComponent();
        }
        public void listarIDproducto()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    string cod = Convert.ToString(txt_buscar_codigo.Text.Trim());
                    var lst = db.Producto.Where(i => i.codigo == cod);

                    foreach (var oproducto in lst)
                    {

                        string codigo = oproducto.codigo;
                        mensaje1 = oproducto.codigo;
                        string nombre = oproducto.Nombre;
                        string detalle = oproducto.Descripcion_Producto;
                        double subtotal = Convert.ToDouble(oproducto.precio_salida);
                        int id = oproducto.Codigo_ID;
                        double porcentaje = Convert.ToDouble(Global.porcentaje);
                        double resultado = porcentaje * subtotal  / 100;
                        double resultado1 = resultado + subtotal;

                        if (cbo_factura.Text == "Factura Crédito fiscal")
                        {

                            if (oproducto.itbis == true)
                            {

                                dgvCategoras.Rows.Add(codigo, nombre, detalle, 1, subtotal, resultado1, id, resultado, oproducto.itbis);
                            }

                            else
                            {
                                dgvCategoras.Rows.Add(codigo, nombre, detalle, 1, subtotal, subtotal, id, "0.00", oproducto.itbis);
                            }
                        }
                        else if (cbo_factura.Text == "Factura Gubernamental")
                        {

                            if (oproducto.itbis == true)
                            {
                                dgvCategoras.Rows.Add(codigo, nombre, detalle, 1, resultado1, resultado1, id, resultado, oproducto.itbis);
                            }

                            else
                            {
                                dgvCategoras.Rows.Add(codigo, nombre, detalle, 1, subtotal, subtotal, id, "0.00", oproducto.itbis);
                            }
                        }
                        else
                        {
                            dgvCategoras.Rows.Add(codigo, nombre, detalle, 1, subtotal, subtotal, id, "0.00", oproducto.itbis);
                        }

                        //dgvCategorias.Rows.Add(codigo, nombre, detalle, 1, subtotal, subtotal, oproducto.Codigo_ID);
                        txt_buscar_codigo.Clear();
                        txt_buscar_codigo.Focus();


                    }


                }

            }

            catch { }

        }

        public void agregarItbis()
        {
            for (int i = 0; i < dgvCategoras.Rows.Count; ++i)
            {
                
                double total = Convert.ToDouble(dgvCategoras.Rows[i].Cells[3].Value) * Convert.ToDouble(dgvCategoras.Rows[i].Cells[4].Value);
                double total1 = Convert.ToDouble(dgvCategoras.Rows[i].Cells[3].Value) * Convert.ToDouble(dgvCategoras.Rows[i].Cells[7].Value);
                Boolean ItbisCondicion = Convert.ToBoolean(dgvCategoras.Rows[i].Cells[8].Value.ToString());

                    double porcentaje = Convert.ToDouble(Global.porcentaje);
                    double resultado = porcentaje * total / 100;
                    double resultado1 = resultado + total;
                    if (ItbisCondicion == true)
                    {
                        dgvCategoras.Rows[i].Cells[5].Value = resultado1;
                        dgvCategoras.Rows[i].Cells[7].Value = resultado;
                    }
                    else
                    {
                        dgvCategoras.Rows[i].Cells[5].Value = total;
                        dgvCategoras.Rows[i].Cells[7].Value = total1;
                    }
             
            }
            operacion();
        }
        public void agregarSinItbis()
        {
            for (int i = 0; i < dgvCategoras.Rows.Count; ++i)
            {

                double total = Convert.ToDouble(dgvCategoras.Rows[i].Cells[3].Value) * Convert.ToDouble(dgvCategoras.Rows[i].Cells[4].Value);
                double total1 = Convert.ToDouble(dgvCategoras.Rows[i].Cells[3].Value) * Convert.ToDouble(dgvCategoras.Rows[i].Cells[7].Value);
                Boolean ItbisCondicion = Convert.ToBoolean(dgvCategoras.Rows[i].Cells[8].Value.ToString());

                double porcentaje = Convert.ToDouble(Global.porcentaje);
                double resultado = 0 * total / 100;
                double resultado1 = resultado + total;
                if (ItbisCondicion == true)
                {
                    dgvCategoras.Rows[i].Cells[5].Value = resultado1;
                    dgvCategoras.Rows[i].Cells[7].Value = resultado;
                }
                else
                {
                    dgvCategoras.Rows[i].Cells[5].Value = total;
                    dgvCategoras.Rows[i].Cells[7].Value = total1;
                }

            }
            operacion();
        }
        public void operacion()
        {
            try
            {
                //Contar articulos
                articulostotal = dgvCategoras.Rows.Count;


                double totalcliente = 0.00; totalcliente = dgvCategoras.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[5].Value));
                txt_total.Text = totalcliente.ToString();

                double totalItbis = 0.00; totalItbis = dgvCategoras.Rows.Cast<DataGridViewRow>()
                     .Sum(t => Convert.ToDouble(t.Cells[7].Value));
                totalimpuestos = totalItbis;

                Double Tpago2 = 0.00;
                if (Double.TryParse(txt_total.Text, out Tpago2))
                    txt_total.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);


            }
            catch { }

        }
        public void eventocantidad()
        {
            try
            {
                foreach (DataGridViewRow row in dgvCategoras.SelectedRows)
                {

                 
                    string celda = dgvCategoras.CurrentCell.RowIndex.ToString();
                    int cantidades = int.Parse(celda);
                    double total = Convert.ToDouble(dgvCategoras.Rows[cantidades].Cells[3].Value) * Convert.ToDouble(dgvCategoras.Rows[cantidades].Cells[4].Value);
                    double total1 = Convert.ToDouble(dgvCategoras.Rows[cantidades].Cells[3].Value) * Convert.ToDouble(dgvCategoras.Rows[cantidades].Cells[7].Value);
                    Boolean ItbisCondicion = Convert.ToBoolean(row.Cells[8].Value.ToString());

                    if (cbo_factura.Text == "Factura de Consumo")
                    {
                        dgvCategoras.Rows[cantidades].Cells[5].Value = total;
                        dgvCategoras.Rows[cantidades].Cells[7].Value = total1;
                    }
                    else
                    {

                        double porcentaje = Convert.ToDouble(Global.porcentaje);
                        double resultado = porcentaje * total / 100;
                        double resultado1 = resultado + total;
                        if (ItbisCondicion == true)
                        {
                            dgvCategoras.Rows[cantidades].Cells[5].Value = resultado1;
                            dgvCategoras.Rows[cantidades].Cells[7].Value = resultado;
                        }
                        else
                        {
                            dgvCategoras.Rows[cantidades].Cells[5].Value = total;
                            dgvCategoras.Rows[cantidades].Cells[7].Value = total1;
                        }
                    }

                    operacion();
                }
            }
            catch { }
        }
        public void Formadd_pasado(string dato)
        {
            txt_buscar_codigo.Text = dato.ToString();
            listarIDproducto();
            operacion();
            txt_buscar_codigo.Clear();
            txt_buscar_codigo.Focus();
        }
        public void impfactura()
        {
            try
            {
                Form_cotizacion_print fat = new Form_cotizacion_print();
                for (int i = 0; i < dgvCategoras.Rows.Count - 0; i++)
                {
                    datos dat = new datos();
                    dat.fecha =Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy");
                    dat.codigo = dgvCategoras.Rows[i].Cells[0].Value.ToString();
                    dat.articulos = dgvCategoras.Rows[i].Cells[1].Value.ToString();
                    dat.detalle = dgvCategoras.Rows[i].Cells[2].Value.ToString();
                    dat.cantidad = dgvCategoras.Rows[i].Cells[3].Value.ToString();
                    dat.subtotal = Convert.ToDecimal(dgvCategoras.Rows[i].Cells[4].Value).ToString("#,##0.00");
                    dat.totald = Convert.ToDecimal(dgvCategoras.Rows[i].Cells[5].Value).ToString("#,##0.00");
                    dat.itbis = Convert.ToDecimal(dgvCategoras.Rows[i].Cells[7].Value).ToString("#,##0.00");
                    dat.totaLitbis = Convert.ToDecimal(totalimpuestos).ToString("#,##0.00");
                    dat.totalarticulos = articulostotal.ToString();
                    dat.total = Convert.ToDecimal(txt_total.Text).ToString("#,##0.00");
                    dat.rnc = txt_rnc.Text;
                    dat.cliente = txt_nombre_cotizacion.Text;

                    dat.logo = Global.logo;
                    dat.descripcion = Global.descripcion;
                    //dat.rnc = Global.rnc;
                    dat.instegram = Global.instegram;
                    dat.whatsaap = Global.telefono;
                    dat.subtotalcotizacion = (Convert.ToDouble(txt_total.Text) - Convert.ToDouble(totalimpuestos)).ToString("#,##0.00");

                    fat.datos.Add(dat);

                }
                fat.ShowDialog();
                Close();
            }
            catch { }
        }
         public void borrarCotizacion()
        {
            using (beutyEntities db = new beutyEntities())

            {
              
                    int idcotiza1 = Convert.ToInt32(idcotiza);
                    foreach (var oproducto in db.cotizacion.Where(c => c.idcotiza == idcotiza1))
                    {
                        
                        db.cotizacion.Add(oproducto);
                        db.Entry(oproducto).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                }

            

        }
        public void borrarCotizacionDetalle()
        {
            using (beutyEntities db = new beutyEntities())

            {
               

                    int idcotiza1 = Convert.ToInt32(idcotiza);
                    foreach (var oproducto in db.dbCotizacion.Where(c => c.idcotiza == idcotiza1))
                    {
                        oproducto.estado = false;
                        db.dbCotizacion.Add(oproducto);
                        db.Entry(oproducto).State = EntityState.Deleted;
                     
                       
                    }
                    db.SaveChanges();
                  
                

            }

        }
        private void Form_cotizacion_Load(object sender, EventArgs e)
        {
            if(idcotiza==null)
            {
                cbo_factura.Text = "Factura de Consumo";
            }
            
        }
        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void Form_cotizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listarIDproducto();
                operacion();
                if (mensaje1 == null)
                {
                    MessageBox.Show("No encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txt_buscar_codigo.Clear();
                txt_buscar_codigo.Focus();
                mensaje1 = null;

            }
        }

        private void dgvCategorias_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            eventocantidad();
        }

        private void dgvCategorias_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvCategoras.CurrentCell.ColumnIndex == 3)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
            if (dgvCategoras.CurrentCell.ColumnIndex == 4)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
            if (dgvCategoras.CurrentCell.ColumnIndex == 5)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            Form_cotizacionV formadd = new Form_cotizacionV();
            formadd.pasado += Formadd_pasado;
            formadd.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCategoras.Columns["quitar"].Index && e.RowIndex >= 0)
            {

                dgvCategoras.Rows.Remove(dgvCategoras.CurrentRow);
                //MessageBox.Show("Producto Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                operacion();

            }
        }

        private void dgvCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void validar()
        {
            if (txt_nombre_cotizacion.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de cliente.");
                txt_nombre_cotizacion.BackColor = Color.Crimson;
            }
            else if (txt_direccion_cotizacion.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de direccion.");
                txt_direccion_cotizacion.BackColor = Color.Crimson;
            }
            else if (txt_telefono_cotizacion.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de telefono.");
                txt_telefono_cotizacion.BackColor = Color.Crimson;
            }
            else if (txt_rnc.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de rnc.");

            }

            else
            {

                addcotizacion();
                addcotizacionDetalle();
                if(idcotiza ==null){
                    impfactura();
                }
               
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        public void addcotizacionDetalle()
        {


            using (beutyEntities db = new beutyEntities())

            {

                for (int i = 0; i < dgvCategoras.Rows.Count - 0; i++)
                {
                    cotizacion ocotizacion = new cotizacion();
                    ocotizacion.cliente = txt_nombre_cotizacion.Text;
                    ocotizacion.direccion = txt_direccion_cotizacion.Text;
                    ocotizacion.telefono = txt_telefono_cotizacion.Text;
                    ocotizacion.tipodocumento = cbo_factura.Text;
                    ocotizacion.totalCotizacion = Convert.ToDouble(txt_total.Text);
                    ocotizacion.fecha = DateTime.Now;
                    ocotizacion.estado = true;
                    ocotizacion.codigo = dgvCategoras.Rows[i].Cells[0].Value.ToString();
                    ocotizacion.nombre = dgvCategoras.Rows[i].Cells[1].Value.ToString();
                    ocotizacion.cantidad = Convert.ToDouble(dgvCategoras.Rows[i].Cells[3].Value.ToString());
                    ocotizacion.subtotal = Convert.ToDouble(dgvCategoras.Rows[i].Cells[4].Value.ToString());
                    ocotizacion.total = Convert.ToDouble(dgvCategoras.Rows[i].Cells[5].Value.ToString());
                    ocotizacion.itbis = Convert.ToDouble(dgvCategoras.Rows[i].Cells[7].Value.ToString());
                    ocotizacion.idprd = Convert.ToInt32(dgvCategoras.Rows[i].Cells[6].Value.ToString());
                    ocotizacion.idcotiza = idcotizacion;

                    db.cotizacion.Add(ocotizacion);

                }


                db.SaveChanges();
                MessageBox.Show("Cotizacion registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
        }
        public void addcotizacion()
        {


            using (beutyEntities db = new beutyEntities())

            {


                dbCotizacion ocotizacion = new dbCotizacion();
                ocotizacion.cliente = txt_nombre_cotizacion.Text;
                ocotizacion.direccion = txt_direccion_cotizacion.Text;
                ocotizacion.rnc = txt_rnc.Text;
                ocotizacion.telefono = txt_telefono_cotizacion.Text;
                ocotizacion.total = Convert.ToDouble(txt_total.Text);
                ocotizacion.totalItbis = totalimpuestos;
                ocotizacion.fecha = DateTime.Now;
                ocotizacion.estado = true;


                db.dbCotizacion.Add(ocotizacion);
                db.SaveChanges();
                idcotizacion = ocotizacion.idcotiza;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idcotiza !=null)
            {
                borrarCotizacion();
                borrarCotizacionDetalle();
            }
            validar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbo_factura.Text = "Factura de Consumo";
            dgvCategoras.Rows.Clear();
            txt_nombre_cotizacion.Clear();
            txt_rnc.Clear();
            txt_telefono_cotizacion.Clear();
            txt_total.Clear();
            txt_direccion_cotizacion.Clear();

        }

        private void cbo_factura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_factura.Text == "Factura de Consumo")
            {
               agregarSinItbis();
               
            }

            else
            {
                agregarItbis();
            }
            
        }

        private void txt_rnc_KeyUp(object sender, KeyEventArgs e)
        {

        }

        public void verificar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                    var lst = db.dbCotizacion.Where(i => i.rnc == txt_rnc.Text);
                    foreach (var oproducto in lst)
                    {
                        txt_nombre_cotizacion.Text = oproducto.cliente;
                        txt_direccion_cotizacion.Text = oproducto.direccion;
                        txt_telefono_cotizacion.Text = oproducto.telefono;
                    }
                }
            }
            catch { }
        }

        private void txt_rnc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_rnc_Leave(object sender, EventArgs e)
        {
            verificar();
        }

      
    }
}

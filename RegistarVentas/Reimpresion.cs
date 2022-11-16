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
using System.Drawing.Printing;
using System.IO;

namespace RegistarVentas
{
    public partial class Reimpresion : Form
    {
        public string cliente,devuelta,usuario,descuento;
        
        public Reimpresion()
        {
            InitializeComponent();
        }
        public void listarventas()
        {
            try
            {
                DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                using (beutyEntities db = new beutyEntities())

                {
                   

                    ventaBindingSource.DataSource = db.venta.ToList().Where(f=> f.fecha ==fecha);

                    for (int i = 0; i < dgvproducto.Rows.Count; i++)
                    {
                        if (dgvproducto.Rows[i].Cells[5].Value == null)
                        {
                            
                        }
                        else if (dgvproducto.Rows[i].Cells[5].Value.ToString() == string.Empty)
                        {
                            
                        }
                        else if (dgvproducto.Rows[i].Cells[5].Value.ToString() == "Anulada")
                        {
                            dgvproducto.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                            dgvproducto.Rows[i].Cells[5].Style.BackColor = Color.White;
                        }
                    }                    
                }

            }

            catch { }
        }
        public void imprimir()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {
                    factura fat = new factura();
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {
                        int idventa  = Convert.ToInt32( row.Cells[2].Value.ToString());
                       
                        DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                        var lst = db.View_factura.ToList().Where(c => c.idventa ==idventa);
                        foreach (var ofactura in lst)
                        {
                            datos dat = new datos();
                            dat.usuario = Global.nombre;
                            dat.fecha = ofactura.fecha.ToString();
                            dat.factura = ofactura.idventa.ToString(); ;
                            dat.metodo = ofactura.metodo.ToString();
                            dat.cliente = ofactura.Nombre.ToString();
                            dat.descuento = ofactura.descuento.ToString();
                            dat.credito = ofactura.credito.ToString();
                            dat.articulos = ofactura.Descripcion_Producto.ToString();
                            dat.telefono = ofactura.cantidad.ToString();
                            dat.total = ofactura.precio.ToString();
                            dat.subtotal = ofactura.monto.ToString();
                            dat.efectivo = ofactura.efectivo.ToString();
                            dat.credito = ofactura.credito.ToString();
                            dat.tarejeta = ofactura.tarjeta.ToString();
                            dat.fecha_inicial = ofactura.subtotal.ToString();
                            dat.logo = Global.logo;
                            dat.descripcion = Global.descripcion;
                            dat.rnc = Global.rnc;
                            dat.instegram = Global.instegram;
                            dat.whatsaap = Global.telefono;

                            fat.datos.Add(dat);

                        }
                        //MessageBox.Show(efectivo.ToString());
                        fat.Show();
                    }
                 
                }

            }

            catch { }
        }
        public  void anularventas()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)

                    {
                        int idoperacion = Convert.ToInt32(row.Cells[2].Value);
                        foreach (var oventa in db.detalleVenta.Where(d => d.ventaid == idoperacion))
                        {

                            Inventario oinventario = new Inventario();
                            oinventario.Producto_Id =Convert.ToInt32(oventa.idproducto);
                            oinventario.entrada = Convert.ToDouble(oventa.cantidad);
                            oinventario.salida = 0;
                            oinventario.Fecha_Ingreso = DateTime.Now;
                            oinventario.tipo_operacion = 1;
                            db.Inventario.Add(oinventario);
                         
                           
                        }
                       
                        db.SaveChanges();
                      
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void eliminarventas()
        {

            using (beutyEntities db = new beutyEntities())
            {
                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {

                    int idoperacion = Convert.ToInt32(row.Cells[2].Value);
                    venta oventa = db.venta.Find(idoperacion);
                    oventa.estado = "Anulada";
                    oventa.vendedor = Global.nombre;           
                    db.Entry(oventa).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("reabastecer Inventario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    listarventas();

                }

            }

        }
        public void eliminartrabajo()
        {

            using (beutyEntities db = new beutyEntities())
            {
                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {

                    int idoperacion = Convert.ToInt32(row.Cells[2].Value);
                    foreach (var oventa in db.reparacion.ToList().Where(d => d.ventaid == idoperacion))
                    {

                        db.Entry(oventa).State = EntityState.Deleted;
                        db.SaveChanges();
                        

                    }
                }
            }

        }
        public void eliminarcxc()
        {

            using (beutyEntities db = new beutyEntities())
            {
                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {

                    int idoperacion = Convert.ToInt32(row.Cells[2].Value);
                    foreach (var oventa in db.CXC.ToList().Where(d => d.venta == idoperacion))
                    {

                        db.Entry(oventa).State = EntityState.Deleted;
                        db.SaveChanges();


                    }
                }
            }

        }
        public  void eliminardetalle()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)

                    {
                        int idoperacion = Convert.ToInt32(row.Cells[2].Value);
                        foreach (var oventa in db.detalleVenta.ToList().Where(d => d.ventaid == idoperacion))
                        {
                            detalleVenta odetalle = db.detalleVenta.FirstOrDefault(d => d.ventaid == oventa.ventaid);

                            db.Entry(odetalle).State = EntityState.Deleted;
                            db.SaveChanges();

                        }
                       

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            listarventas();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvproducto.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    datagrid();
                    imprimirfactura();

                }
                if (e.ColumnIndex == dgvproducto.Columns["anular"].Index && e.RowIndex >= 0)
                {

                    if (MessageBox.Show("Seguro de Anular la factura?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        anularventas();
                        eliminartrabajo();
                        eliminarcxc();
                        eliminardetalle();
                        eliminarventas();
                    }

                    else
                    {

                    }

                }

            }
            catch { }
        }

        private void txtNfatura_KeyUp(object sender, KeyEventArgs e)
        {
           
          
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
           
        }
        private void RE_Imprimir(object sender, PrintPageEventArgs e)
        {
            try
            {


                using (beutyEntities db = new beutyEntities())

                {

                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idventa = Convert.ToInt32(row.Cells[2].Value.ToString());

                        DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                        var lst = db.View_factura.ToList().Where(v => v.idventa == idventa);
                        foreach (var ofactura in lst)
                        {

                            double subtotal = 0.00;
                            double suma1 = 0.00;
                            suma1 = Convert.ToDouble(ofactura.itebis);
                            subtotal = Convert.ToDouble(ofactura.monto) - suma1;

                            Font font_8 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                            Font font_16 = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Point);
                            Font font_10 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
                            Font font_28 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point);

                            int y = 20;


                            string itb = "ITBIS";
                            string subtotal1 = "MONTO BRUTO";
                            string total = "TOTAL A PAGAR RD$";
                            string efectivo = "EFECTIVO";
                            string tarjeta = "TARJETA";
                            string cambio = "CAMBIO";


                            e.Graphics.DrawImage(piclogo.Image, new RectangleF(45, 0, 200, 110));
                            e.Graphics.DrawString(Global.nombre_empresa.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 100, 300, 0));
                            e.Graphics.DrawString(Global.descripcion.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                            e.Graphics.DrawString("TELEFONO: " + Global.telefono + " / " + Global.instegram, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                            e.Graphics.DrawString("RNC: " + Global.rnc.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                            e.Graphics.DrawString(DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                            e.Graphics.DrawString("CAJERO: CAJA 1 " + Global.nombre.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));

                            if (ofactura.tipodocumento == "Factura de Consumo")
                            {
                                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                                e.Graphics.DrawString("FACTURA PARA CONSUMIDOR FINAL", font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                                e.Graphics.DrawString("NCF: " + ofactura.ncf, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                                e.Graphics.DrawString("VECIMIENTO: " +Convert.ToDateTime(ofactura.Fecha_vencimiemto_comprobante).ToShortDateString() , font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                            }
                            else
                            {
                                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                                e.Graphics.DrawString(ofactura.tipodocumento.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                                e.Graphics.DrawString("RNC CLIENTE: " + ofactura.rnc.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                                e.Graphics.DrawString("CLIENTE: " + ofactura.cliente.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                                e.Graphics.DrawString("NCF: " + ofactura.ncf, font_10, Brushes.Black, new RectangleF(2, y += 30, 300, 50));
                                e.Graphics.DrawString("VECIMIENTO: " + Convert.ToDateTime(ofactura.Fecha_vencimiemto_comprobante).ToShortDateString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                            }
                            if (ofactura.credito > 0)
                            {
                                e.Graphics.DrawString("FACTURA A CREDITO", font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));

                            }
                            e.Graphics.DrawString("DESCRIPCION        ITBIS            VALOR  ", font_10, Brushes.Black, new RectangleF(10, y += 20, 300, 50));
                            e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(10, y += 12, 300, 50));
                            for (int i = 0; i < dgvdetalle.Rows.Count - 0; i++)
                            {
                                e.Graphics.DrawString(dgvdetalle.Rows[i].Cells[1].Value.ToString().ToUpper(), font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                                e.Graphics.DrawString(dgvdetalle.Rows[i].Cells[2].Value.ToString() + "   x   " + Convert.ToDecimal(dgvdetalle.Rows[i].Cells[3].Value).ToString("#,##0.00").PadRight(15) + Convert.ToDecimal(dgvdetalle.Rows[i].Cells[5].Value).ToString("#,##0.00").PadRight(15) + Convert.ToDecimal(dgvdetalle.Rows[i].Cells[4].Value).ToString("#,##0.00").PadLeft(15), font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                            }

                            e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(10, y += 12, 300, 50));
                            e.Graphics.DrawString(subtotal1.PadRight(27) + (Convert.ToDouble(ofactura.monto) - Convert.ToDouble(ofactura.itebis)).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                            e.Graphics.DrawString(itb.PadRight(37) + Convert.ToDecimal(ofactura.itebis).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                            e.Graphics.DrawString(total.PadRight(17) + Convert.ToDecimal(ofactura.monto).ToString("#,##0.00").PadLeft(20), font_28, Brushes.Black, new RectangleF(10, y += 15, 400, 50));
                            //if (ofactura.efectivo > 0)
                            //{
                                e.Graphics.DrawString(efectivo.PadRight(30) + Convert.ToDecimal(ofactura.efectivo).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(10, y += 18, 300, 50));
                            //}
                            //else if (ofactura.tarjeta > 0)
                            //{
                            //    e.Graphics.DrawString(tarjeta.PadRight(30) + Convert.ToDecimal(ofactura.tarjeta).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(10, y += 18, 300, 50));
                            //}
                            e.Graphics.DrawString(cambio.PadRight(32) + Convert.ToDecimal(ofactura.devuelta).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                            e.Graphics.DrawString("FACTURA: 000" + (ofactura.idventa), font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                            
                            // e.Graphics.DrawString("MESA: " + ofactura.mesa, font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                            e.Graphics.DrawString("GRACIAS POR SU VISITA", font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                            e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(10, y += 12, 300, 50));
                            e.Graphics.DrawString("             WWW.ERMSOFTS.COM     ", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                            e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                            e.Graphics.DrawString(".", font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));



                        }
                    }
                }


                

            }

            catch { }
        }
        public void listarlogo()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.configuracion.ToList();
                    foreach (var oconfig in lst)
                    {

                        MemoryStream ms = new MemoryStream(oconfig.logo);
                        Bitmap bmp = new Bitmap(ms);
                        piclogo.Image = bmp;
                    }

                }

            }

            catch { }
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        public void datagrid()
        {
            try
            {
                dgvdetalle.Rows.Clear();
                using (beutyEntities db = new beutyEntities())

                {

                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idventa = Convert.ToInt32(row.Cells[2].Value.ToString());

                        DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                        var lst = db.View_factura.ToList().Where(v => v.idventa == idventa);
                        foreach (var ofactura in lst)
                        {
                            dgvdetalle.Rows.Add(1, ofactura.Descripcion_Producto.ToString(), ofactura.cantidad, ofactura.precio, ofactura.subtotal, ofactura.itbis);


                        }

                    }

                }

            }

            catch { }
        }
        public void imprimirfactura()
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += RE_Imprimir;
            printDocument1.Print();
        }
        private void Reimpresion_Load(object sender, EventArgs e)
        {
            listarventas();
            listarlogo();
        }
    }
}

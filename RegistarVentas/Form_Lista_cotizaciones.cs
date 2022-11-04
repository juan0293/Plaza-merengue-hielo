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
    public partial class Form_Lista_cotizaciones : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;
        public string documento;
        public Form_Lista_cotizaciones()
        {
            InitializeComponent();
        }
        public void listarBuscarnombre()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = from m in db.dbCotizacion
                              where m.cliente.Contains(txtBuscar.Text)
                              select m;
                    dbCotizacionBindingSource.Clear();
                    dbCotizacionBindingSource.DataSource = lst.ToList().Where(m => m.estado == true).Take(25);



                }
            }
            catch { }
        }
        public void listarcotizaciones()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {

                    dbCotizacionBindingSource.Clear();
                    dbCotizacionBindingSource.DataSource = db.dbCotizacion.ToList().Where(m => m.estado == true).Take(25);



                }
            }
            catch { }
        }
        private void Form_Lista_cotizaciones_Load(object sender, EventArgs e)
        {
            listarcotizaciones();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            listarBuscarnombre();
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvproducto.Columns["agregar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {


                        pasado(row.Cells[0].Value.ToString());

                        Close();
                    }

                }


            }
            catch { }
        }

        private void dgvproducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvproducto.Rows[e.RowIndex].Cells[6].Value = "Seleccionar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            borrarCotizacion();
            borrarCotizacionDetalle();

        }

        public void borrarCotizacion()
        {
            using (beutyEntities db = new beutyEntities())

            {
                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {

                    int idcotiza = Convert.ToInt32(row.Cells[0].Value.ToString());
                    foreach (var oproducto in db.cotizacion.Where(c => c.idcotiza == idcotiza))
                    {
                        oproducto.estado = false;
                        db.cotizacion.Add(oproducto);
                        db.Entry(oproducto).State = EntityState.Modified;
                    }
                    db.SaveChanges();

                }

            }

        }
        public void borrarCotizacionDetalle()
        {
            using (beutyEntities db = new beutyEntities())

            {
                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {

                    int idcotiza = Convert.ToInt32(row.Cells[0].Value.ToString());
                    foreach (var oproducto in db.dbCotizacion.Where(c => c.idcotiza == idcotiza))
                    {
                        oproducto.estado = false;
                        db.dbCotizacion.Add(oproducto);
                        db.Entry(oproducto).State = EntityState.Modified;
                     
                       
                    }
                    db.SaveChanges();
                    MessageBox.Show("Cotizacion eliminada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarcotizaciones();
                }

            }

        }
        public void reimprecion()
        {
            try
            {
                Form_cotizacion_print fat = new Form_cotizacion_print();

              
                using (beutyEntities db = new beutyEntities())

                {


                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idcotiza = Convert.ToInt32(row.Cells[0].Value.ToString());


                        var lst = db.dbCotizacion.ToList().Where(c => c.idcotiza == idcotiza);
                        foreach (var dbcotiza in lst)
                        {
                            for (int i = 0; i < dgvCategoras.Rows.Count - 0; i++)
                            {
                                datos dat = new datos();
                                dat.fecha =Convert.ToDateTime(dbcotiza.fecha).ToString("dd/MM/yyyy");
                                dat.totaLitbis = Convert.ToDecimal(dbcotiza.totalItbis).ToString("#,##0.00");
                                dat.totalarticulos = dgvCategoras.Rows.Count.ToString();
                                dat.total = Convert.ToDecimal(dbcotiza.total).ToString("#,##0.00");
                                dat.rnc = dbcotiza.rnc;
                                dat.cliente = dbcotiza.cliente;
                               
                                dat.logo = Global.logo;
                                dat.descripcion = Global.descripcion;
                                //dat.rnc = Global.rnc;
                                dat.instegram = Global.instegram;
                                dat.whatsaap = Global.telefono;

                                dat.codigo = dgvCategoras.Rows[i].Cells[0].Value.ToString();
                                dat.articulos = dgvCategoras.Rows[i].Cells[1].Value.ToString();
                                dat.detalle = dgvCategoras.Rows[i].Cells[2].Value.ToString();
                                dat.cantidad = dgvCategoras.Rows[i].Cells[3].Value.ToString();
                                dat.subtotal = Convert.ToDecimal(dgvCategoras.Rows[i].Cells[4].Value).ToString("#,##0.00");
                                dat.totald = Convert.ToDecimal(dgvCategoras.Rows[i].Cells[5].Value).ToString("#,##0.00");
                                dat.itbis = Convert.ToDecimal(dgvCategoras.Rows[i].Cells[7].Value).ToString("#,##0.00");

                                dat.subtotalcotizacion = Convert.ToDecimal(dbcotiza.total - dbcotiza.totalItbis).ToString("#,##0.00"); 
                                fat.datos.Add(dat);
                            }

                        }

                        fat.Show();

                       }

                   }

            }

            catch { }
        }


        public void editar()
        {
            try
            {
              
               Form_cotizacion fat = new Form_cotizacion();


                using (beutyEntities db = new beutyEntities())

                {
                    Boolean estado;
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idcotiza = Convert.ToInt32(row.Cells[0].Value.ToString());


                        var lst = db.dbCotizacion.ToList().Where(c => c.idcotiza == idcotiza);
                        foreach (var dbcotiza in lst)
                        {
                            for (int i = 0; i < dgvCategoras.Rows.Count - 0; i++)
                            {
                                fat.txt_total.Text = Convert.ToDecimal(dbcotiza.total).ToString("#,##0.00");
                                fat.idcotiza = idcotiza.ToString();
                                fat.txt_rnc.Text = dbcotiza.rnc;
                                fat.cbo_factura.Text = documento;
                                fat.txt_direccion_cotizacion.Text = dbcotiza.direccion;
                                fat.txt_telefono_cotizacion.Text = dbcotiza.telefono;
                             
                                fat.txt_nombre_cotizacion.Text = dbcotiza.cliente;
                                if(Convert.ToDecimal(dgvCategoras.Rows[i].Cells[7].Value) >0)
                                {
                                    estado = true;
                                }
                                else
                                {
                                    estado = false;
                                }

                                fat.dgvCategoras.Rows.Add(dgvCategoras.Rows[i].Cells[0].Value.ToString(),
                                  dgvCategoras.Rows[i].Cells[1].Value.ToString(),
                                  dgvCategoras.Rows[i].Cells[2].Value.ToString(),
                                  dgvCategoras.Rows[i].Cells[3].Value.ToString(),
                                 Convert.ToDecimal(dgvCategoras.Rows[i].Cells[4].Value).ToString("#,##0.00"),
                                 Convert.ToDecimal(dgvCategoras.Rows[i].Cells[5].Value).ToString("#,##0.00"),
                                 dgvCategoras.Rows[i].Cells[6].Value.ToString(),
                                 Convert.ToDecimal(dgvCategoras.Rows[i].Cells[7].Value).ToString("#,##0.00"),
                                 estado);
                               
                            }

                        }

                        fat.ShowDialog();
                        Close();

                    }

                }

            }

            catch { }
        }
        public void datagridDatos()
        {
            try
            {
              
                using (beutyEntities db = new beutyEntities())

                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idcotiza = Convert.ToInt32(row.Cells[0].Value.ToString());
                        var lst1 = db.cotizacion.ToList().Where(c => c.idcotiza == idcotiza);
                        foreach (var dbcotiza in lst1)
                        {
                            documento = dbcotiza.tipodocumento;
                            dgvCategoras.Rows.Add(dbcotiza.codigo, dbcotiza.nombre, dbcotiza.nombre, dbcotiza.cantidad.ToString(), dbcotiza.subtotal.ToString(), dbcotiza.total.ToString(), dbcotiza.idprd.ToString(), dbcotiza.itbis.ToString());
                           
                          
                        }

                    }

                }

            }

            catch { }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            dgvCategoras.Rows.Clear();
            MessageBox.Show("Imprimiendo documento", "Mensaje");
            datagridDatos();
            reimprecion();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            dgvCategoras.Rows.Clear();
            datagridDatos();
            editar();
           
          
        }
    }
}

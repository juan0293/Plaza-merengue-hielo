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
    public partial class Form_gastos : Form
    {
        public string idgasto;
       
        public Form_gastos()
        {
            InitializeComponent();
        }
        public void listarGastos()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);

                    gastoBindingSource.DataSource = db.gasto.ToList().Where(g => g.estado ==true);


                }

            }

            catch { }
        }
        public void addgastos()
        {
            try
            {


                using (beutyEntities db = new beutyEntities())

                {
                    gasto ogastos = new gasto();
                    ogastos.detalle = txtnombre.Text;
                    ogastos.monto = Convert.ToDouble(txt_cantidad.Text);
                    ogastos.fecha = DateTime.Now;
                    ogastos.estado = true;
                    ogastos.iduser = Convert.ToInt32(Global.iduser);
                    db.gasto.Add(ogastos);
                    db.SaveChanges();
                    MessageBox.Show("Gastos Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarGastos();
                }

            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void updgastos()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {

                    int idgast = Convert.ToInt32(idgasto);

                    gasto ogastos = db.gasto.Find(idgast);
                    ogastos.detalle = txtnombre.Text;
                    ogastos.monto = Convert.ToDouble(txt_cantidad.Text);
                    db.Entry(ogastos).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Datos Actualizados.");
                }

            }

            catch { }
        }
        public void Pagos()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                    foreach (DataGridViewRow row in dgvCategorias.SelectedRows)
                    {



                        int idgast = Convert.ToInt32(row.Cells[0].Value);

                        gasto ogastos = db.gasto.Find(idgast);
                        ogastos.estado = false;
                        db.Entry(ogastos).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("FACTURA PAGADA EXITOSAMENTE!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listarGastos();
                    }
                   
                }

            }

            catch { }
        }
        public void borrar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                    foreach (DataGridViewRow row in dgvCategorias.SelectedRows)
                    {

                        int idgast = Convert.ToInt32(row.Cells[0].Value);
                        gasto ogastos = db.gasto.Find(idgast);
                        db.Entry(ogastos).State = EntityState.Deleted;
                        db.SaveChanges();
                        MessageBox.Show("FACTURA ELIMINADA EXITOSAMENTE!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listarGastos();
                    }
                   
                }

            }

            catch { }
        }
        public void impfactura()
        {
            form_imprimir_gastos fat = new form_imprimir_gastos();
           
                datos dat = new datos();
                dat.fecha = DateTime.Now.ToString(); ;
                dat.usuario = Global.nombre.ToString();
                dat.total = txt_cantidad.Text;
                dat.articulos = txtnombre.Text;
                dat.logo = Global.logo;
                dat.descripcion = Global.descripcion;
                dat.rnc = Global.rnc;
                dat.instegram = Global.instegram;
                dat.whatsaap = Global.telefono;
            fat.datos.Add(dat);
            fat.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form_gastos_Load(object sender, EventArgs e)
        {
            listarGastos();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvCategorias.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvCategorias.SelectedRows)
                    {


                        idgasto = row.Cells[0].Value.ToString();
                        txtnombre.Text = row.Cells[1].Value.ToString();
                        txt_cantidad.Text = row.Cells[2].Value.ToString();
                    }

                }
                if (e.ColumnIndex == dgvCategorias.Columns["Pagar"].Index && e.RowIndex >= 0)
                {
                    Pagos();

                }
                if (e.ColumnIndex == dgvCategorias.Columns["delete"].Index && e.RowIndex >= 0)
                {
                    borrar();
                }

            }
            catch { }
        }

        private void dgvCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvCategorias.Rows[e.RowIndex].Cells[4].Value = "Editar";
            dgvCategorias.Rows[e.RowIndex].Cells[5].Value = "Pagar";
            dgvCategorias.Rows[e.RowIndex].Cells[6].Value = "Borrar";
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            
                if (idgasto == null)
                {
                    addgastos();
                    impfactura();
                    txtnombre.Clear();
                    txt_cantidad.Clear();
                }
                else
                {
                    updgastos();
                    impfactura();
                    listarGastos();
                    txtnombre.Clear();
                    txt_cantidad.Clear();
                    idgasto = null;

                }
            }
        }
    }


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
    public partial class Form_actualizar : Form
    {
        public string idproducto;
        public Form_actualizar()
        {
            InitializeComponent();
        }
        public void guardar()
        {
           
                using (beutyEntities db = new beutyEntities())
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idoperacion = Convert.ToInt32(row.Cells[1].Value);

                        Inventario oinventario = db.Inventario
                        .Find(idoperacion);
                        oinventario.entrada = Convert.ToDouble(row.Cells[3].Value); ;
                        db.Entry(oinventario).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Datos actualizados con exito","mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }

                }
           
        }
        public void listarload()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    inventarioBindingSource.Clear();

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                  
                    inventarioBindingSource.DataSource = db.Inventario.ToList().Where(c =>  c.Fecha_Ingreso == fecha);

                }
            }
            catch { }
        }
        public void listarentrada()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    inventarioBindingSource.Clear();

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    int ID = Convert.ToInt32(idproducto);
                    inventarioBindingSource.DataSource = db.Inventario.ToList().Where(c => c.Producto_Id == ID && c.Fecha_Ingreso == fecha);

                }
            }
            catch { }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void dgvproducto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvproducto.CurrentCell.ColumnIndex == 3)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void Form_actualizar_Load(object sender, EventArgs e)
        {
            listarentrada();
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            listarentrada();
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvproducto.Columns["actualizar"].Index && e.RowIndex >= 0)
            {
                guardar();
               
            }

        }
    }
}

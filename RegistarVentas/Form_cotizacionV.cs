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
    public partial class Form_cotizacionV : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;
        public Form_cotizacionV()
        {
            InitializeComponent();
        }
        public int idcategoria;
        public void resfrescar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    productoBindingSource.DataSource = db.Producto.ToList();

                }
            }
            catch { }
        }
        public void listarcategoria()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.categoria;
                    foreach (var ocategoria in lst)
                    {
                        cboCategoria.Items.Add(ocategoria.nombre);
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
                    var lst = db.categoria.Where(c => c.nombre == cboCategoria.Text); ;
                    foreach (var ocategoria in lst)
                    {
                        idcategoria = ocategoria.idcategoria;
                    }

                }

            }

            catch { }
        }
        public void listarBuscarCategoria()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    productoBindingSource.DataSource = db.Producto.ToList().Where(c => c.Categoria == idcategoria);

                }
            }
            catch { }
        }
        public void listarBuscarnombre()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = from m in db.Producto
                              where m.Nombre.Contains(txtBuscar.Text)
                              select m;
                              productoBindingSource.Clear();
                              productoBindingSource.DataSource = lst.ToList().Where(m=> m.estatus == true).Take(25);

                  

                }
            }
            catch { }
        }
        public void listarBuscarcodigo()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    productoBindingSource.DataSource = db.View_inventario.ToList().Where(c => c.codigo == txtBuscar.Text);

                }
            }
            catch { }
        }
        public void metodo()
        {
            if (rdb_nombre.Checked == true && rdbCodigo.Checked == false)
            {
                listarBuscarnombre();
            }
            else if (rdb_nombre.Checked == false && rdbCodigo.Checked == true)
            {
                listarBuscarcodigo();
            }
            else
            {
                MessageBox.Show("Por favor selecionar la opcion de busquedad","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvproducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvproducto.Rows[e.RowIndex].Cells[0].Value = "   +   ";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            metodo();
        }

        private void Form_cotizacionV_Load(object sender, EventArgs e)
        {
            rdb_nombre.Checked = true;
            listarcategoria();
            resfrescar();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarIDcategoria();
            listarBuscarCategoria();
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvproducto.Columns["agregar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {


                        pasado(row.Cells[1].Value.ToString());

                    }

                }


            }
            catch { }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            resfrescar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

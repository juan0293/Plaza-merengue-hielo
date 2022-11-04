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
    public partial class Form_Buscar : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;
        public Form_Buscar()
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

                    productoBindingSource.DataSource = db.Producto.ToList().Where(c=> c.estatus ==true).Take(25);

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
                    var lst = db.categoria.Where(c => c.nombre == cboCategoria.Text);
                    foreach (var ocategoria in lst)
                    {
                        idcategoria = ocategoria.idcategoria;
                    }

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

        public void listarexistencia()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())
                {
                    double id = Convert.ToDouble(dgvproducto.Rows[1].Cells[0].Value);

                    var lst = db.View_stock.ToList();
                   

                    foreach (var ostock in lst)
                    {
                        double gg = Convert.ToDouble(ostock.existencia);

                        MessageBox.Show(gg.ToString());

                        dgvproducto.Rows.Add("", "", "", "", "", "",gg );
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

                    productoBindingSource.DataSource = db.Producto.ToList().Where(c => c.Categoria == idcategoria && c.estatus ==true);

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
                    productoBindingSource.DataSource = lst.ToList().Where(c=> c.estatus ==true);


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

                    productoBindingSource.DataSource = db.View_inventario.ToList().Where(c => c.codigo == txtBuscar.Text && c.estatus ==true);

                }
            }
            catch { }
        }
        public void metodo()
        {
            
            if(txtBuscar.Text =="")
            {
                resfrescar();
            }
            else if (rdb_nombre.Checked == true && rdbCodigo.Checked == false)
            {
                listarBuscarnombre();
            }
            else if (rdb_nombre.Checked == false && rdbCodigo.Checked == true)
            {
                listarBuscarcodigo();
            }
            else
            {
                MessageBox.Show("Por favor selecionar la opcion de busquedad");
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Buscar_Load(object sender, EventArgs e)
        {
            rdb_nombre.Checked = true;
           resfrescar();

           listarcategoria();
           
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarIDcategoria();
            listarBuscarCategoria();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            metodo();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            resfrescar();
        }

        private void rdbcategoria_CheckedChanged(object sender, EventArgs e)
        {
            cboCategoria.Enabled = true;
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                if (e.ColumnIndex == dgvproducto.Columns["agregar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                   
                        pasado(row.Cells[2].Value.ToString());

                        //Close();
                    }

                }
            }
            catch { }
        }

     

        private void dgvproducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvproducto.Rows[e.RowIndex].Cells[0].Value = " + ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvproducto_DoubleClick(object sender, EventArgs e)
        {

                   
            foreach (DataGridViewRow row in dgvproducto.SelectedRows)
            {

                pasado(row.Cells[2].Value.ToString());

                Close();
            }
        }
    }
}

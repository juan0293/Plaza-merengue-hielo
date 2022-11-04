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
    public partial class Form_categoria : Form
    {
        public string idcategoria;
        public Form_categoria()
        {
            InitializeComponent();
        }
        public void listarcategoria()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    categoriaBindingSource.DataSource = db.categoria.ToList();


                }

            }

            catch { }
        }
        public void addcategoria()
        {
            try
            {


                using (beutyEntities db = new beutyEntities())

                {
                    categoria ocategoria = new categoria();
                    ocategoria.nombre = txtnombre.Text;   
                    db.categoria.Add(ocategoria);
                    db.SaveChanges();
                    MessageBox.Show("Categoria Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarcategoria();
                }

            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void updcategoria()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                  
                        int idcat = Convert.ToInt32(idcategoria);

                        categoria ocategoria = db.categoria.Find(idcat);
                         ocategoria.nombre = txtnombre.Text;
                        db.Entry(ocategoria).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Datos Actualizados.");
                    }

                }
            
            catch { }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_categoria_Load(object sender, EventArgs e)
        {
            listarcategoria();
        }

        private void dgvCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvCategorias.Rows[e.RowIndex].Cells[2].Value = "Editar";
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (e.ColumnIndex == dgvCategorias.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvCategorias.SelectedRows)
                    {


                       idcategoria = row.Cells[0].Value.ToString();
                       txtnombre.Text = row.Cells[1].Value.ToString();
                    }

                }


            }
            catch { }
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            if (idcategoria == null)
            {
                addcategoria();
                txtnombre.Clear();
            }
            else
            {
                updcategoria();
                listarcategoria();
                txtnombre.Clear();
                idcategoria = null;

            }
        }
    }
}

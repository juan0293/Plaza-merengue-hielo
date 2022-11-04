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
    public partial class Form_provedor : Form
    {
        public string idproveedor;
        public Form_provedor()
        {
            InitializeComponent();
        }
        public void listarproveedor()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    suplidorBindingSource.DataSource = db.suplidor.ToList();


                }

            }

            catch { }
        }
        public void addproveedor()
        {
            try
            {


                using (beutyEntities db = new beutyEntities())

                {
                    suplidor oprovedor = new suplidor();
                    oprovedor.nombre = txtnombre.Text;
                    db.suplidor.Add(oprovedor);
                    db.SaveChanges();
                    MessageBox.Show("Proveedor Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarproveedor();
                }

            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void updproveedor()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {

                    int idprovee = Convert.ToInt32(idproveedor);

                    suplidor oproveedor = db.suplidor.Find(idprovee);
                    oproveedor.nombre = txtnombre.Text;
                    db.Entry(oproveedor).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Datos Actualizados.");
                }

            }

            catch { }
        }
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvCategorias.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvCategorias.SelectedRows)
                    {


                        idproveedor = row.Cells[0].Value.ToString();
                        txtnombre.Text = row.Cells[1].Value.ToString();
                    }

                }


            }
            catch { }
        }

        private void dgvCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvCategorias.Rows[e.RowIndex].Cells[2].Value = "Editar";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            if (idproveedor == null)
            {
                addproveedor();
                txtnombre.Clear();
            }
            else
            {
                updproveedor();
                listarproveedor();
                txtnombre.Clear();
                idproveedor = null;

            }
        }

        private void Form_provedor_Load(object sender, EventArgs e)
        {
            listarproveedor();
        }
    }
}

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
    public partial class Form_vista_cliente : Form
    {
        public delegate void pasar(string id, string nombre);
        public event pasar pasado;
        public Form_vista_cliente()
        {
            InitializeComponent();
        }
        public void resfrescar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    clienteBindingSource.DataSource = db.Cliente.ToList().Where(c=> c.estatus ==true);

                }
            }
            catch { }
        }
        public void buscar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = from m in db.Cliente
                              where m.Nombre.Contains(txtBuscar.Text) || m.Apellidos.Contains(txtBuscar.Text) || m.Cedula.Contains(txtBuscar.Text)
                              select m;
                    clienteBindingSource.Clear();
                    clienteBindingSource.DataSource = lst.ToList().Where(c => c.estatus ==true);

                   

                }
            }
            catch { }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvproducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dgvproducto.Rows[e.RowIndex].Cells[0].Value = "Agregar";
            //dgvproducto.Rows[e.RowIndex].Cells[0].Value = "Editar";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void Form_vista_cliente_Load(object sender, EventArgs e)
        {
            resfrescar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            resfrescar();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 

            if (e.ColumnIndex == dgvproducto.Columns["agregar"].Index && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {


                    pasado(row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());

                    Close();
                }

            }

                if (e.ColumnIndex == dgvproducto.Columns["editar"].Index && e.RowIndex >= 0)
                {

                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {
                        Clientes abrir = new Clientes();

                       abrir.idcliente = row.Cells[2].Value.ToString();
                        abrir.ShowDialog();
                       
                    }

                }


            }
            catch { }
        }

        private void btn1_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {
                    Ingresos abrir = new Ingresos();

                    abrir.cedula = row.Cells[5].Value.ToString();
                    abrir.cliente = row.Cells[3].Value.ToString() + " " + row.Cells[4].Value.ToString();
                    abrir.ShowDialog();

                }
            }
            catch
            {

            }
        }
    }
}

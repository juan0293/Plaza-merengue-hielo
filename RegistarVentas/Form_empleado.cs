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

namespace RegistarVentas
{
    public partial class Form_empleado : Form
    {
        public string idempleado;
        public Form_empleado()
        {
            InitializeComponent();
        }
        public void listar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    empleadoBindingSource.DataSource = db.empleado.ToList();


                }

            }

            catch { }
        }
        public void add()
        {
            try
            {
                if (txtnombre.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de nombre.");
                   
                }
                if (txt_apellido.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de apellido.");
                    txtnombre.BackColor = Color.Crimson;
                }
                if (txt_comision.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de comision.");

                }

                else
                {
                    using (beutyEntities db = new beutyEntities())

                    {
                        empleado oempleado = new empleado();
                        oempleado.nombre = txtnombre.Text;
                        oempleado.apellido = txt_apellido.Text;
                        oempleado.comision = Convert.ToDouble(txt_comision.Text);
                        db.empleado.Add(oempleado);
                        db.SaveChanges();
                        MessageBox.Show("empleado Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listar();
                    }
                }
            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void updateem()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {

                    int empleadoid = Convert.ToInt32(idempleado);

                    empleado oempleado = db.empleado.Find(empleadoid);
                    oempleado.nombre = txtnombre.Text;
                    oempleado.apellido = txt_apellido.Text;
                    oempleado.comision = Convert.ToDouble(txt_comision.Text);
                    db.Entry(oempleado).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Datos Actualizados.");
                    listar();
                }
            }
            catch { }
        }
        public void limpiar()
        {
            txtnombre.Text = txt_apellido.Text = txt_comision.Text = "";
          
        }
        private void Form_empleado_Load(object sender, EventArgs e)
        {
            listar();
        }
        public void resfrescar()
        {
           
        }

        private void dgv_equipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_comision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            if (idempleado == null)
            {
               
                    add();
                    limpiar();
                
            }
            else
            {
           
                    updateem();
                    limpiar();
                
                    idempleado = null;
               
            }
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvproducto.Columns["editar"].Index && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {


                    idempleado = row.Cells[1].Value.ToString();
                    txtnombre.Text = row.Cells[2].Value.ToString();
                    txt_apellido.Text = row.Cells[3].Value.ToString();
                    txt_comision.Text = row.Cells[4].Value.ToString();
                }

            }
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

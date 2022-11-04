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
    public partial class R_usuarios : Form
    {
        public string id_user;
        public R_usuarios()
        {
            InitializeComponent();
        }
        public void listarusuario()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    loginBindingSource.DataSource = db.login.ToList();


                }

            }

            catch { }
        }
        public void addusuario()
        {
            try
            {


                using (beutyEntities db = new beutyEntities())

                {
                    login ologin = new login();
                    ologin.nombre = txtnombre.Text;
                    ologin.usuario = txt_usuario.Text;
                    ologin.pass = txtpassword.Text;
                     if(cbotipo.Text =="Admin")
                    {
                        ologin.tipo = 1;
                    }
                   else if (cbotipo.Text == "Pos")
                    {
                        ologin.tipo = 2;
                    }
                    ologin.estatus = true;
                    ologin.empresa =Convert.ToInt32(Global.empresa);
                    db.login.Add(ologin);
                    db.SaveChanges();
                    MessageBox.Show("Usuario Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarusuario();
                }

            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void updusuario()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {

                    int idusuer = Convert.ToInt32(id_user);

                    login ologin = db.login.Find(idusuer);
                    ologin.nombre = txtnombre.Text;
                    ologin.usuario = txt_usuario.Text;
                    ologin.pass = txtpassword.Text;
                    if (cbotipo.Text == "Admin")
                    {
                        ologin.tipo = 1;
                    }
                    else if (cbotipo.Text == "Pos")
                    {
                        ologin.tipo = 2;
                    }
                    db.Entry(ologin).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Datos Actualizados.");
                }

            }

            catch { }
        }
        public void Activarestado()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idusuario = Convert.ToInt32(row.Cells[2].Value);

                        login ologin = db.login.Find(idusuario);
                        ologin.estatus = true;
                        db.Entry(ologin).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Usuario Activo");
                    }

                }
            }
            catch { }
        }
        public void desactivarestao()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idusuario = Convert.ToInt32(row.Cells[2].Value);

                        login ologin = db.login.Find(idusuario);
                        ologin.estatus = false;
                        db.Entry(ologin).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Usuario Inactivo");
                    }

                }
            }
            catch { }
        }

        public void limpiar()
        {
            txtnombre.Text = txtpassword.Text = txt_usuario.Text = "";
            cbotipo.SelectedIndex = -1;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {



            }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void R_usuarios_Load(object sender, EventArgs e)
        {
            listarusuario();


            // CONECION CON LA BASE DE DATOS
          
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                // CONECION DB

            }
            catch { }
        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

    

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            if (id_user == null)
            {
                if (cbotipo.Text == "")
                {
                    MessageBox.Show("Por Favor seleccionar tipo de Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    addusuario();
                    limpiar();
                }
            }
            else
            {
                if (cbotipo.Text == "")
                {
                    MessageBox.Show("Por Favor seleccionar tipo de Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    updusuario();
                    limpiar();
                    id_user = null;
                }
            }
        }

       

        private void dgvproducto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvproducto.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {


                        id_user = row.Cells[2].Value.ToString();
                        txtnombre.Text = row.Cells[3].Value.ToString();
                        txt_usuario.Text = row.Cells[4].Value.ToString();
                        txtpassword.Text = row.Cells[5].Value.ToString();
                    }

                }
                if (e.ColumnIndex == dgvproducto.Columns["estadocambiar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)

                    {
                        string estado = Convert.ToString(row.Cells[7].Value);


                        if (estado == "True")
                        {
                            desactivarestao();
                        }
                        if (estado == "False")
                        {
                            Activarestado();
                        }
                    }
                    listarusuario();

                }


            }
            catch { }
        }

        private void dgvproducto_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvproducto.Rows)
                {

                    string estado = Convert.ToString(row.Cells[7].Value);


                    if (estado == "True")
                    {
                        row.Cells[8].Value = "Activo";



                    }
                    if (estado == "False")
                    {


                        row.Cells[8].Value = "Inactivo";



                    }
                    string tipo = Convert.ToString(row.Cells[6].Value);
                    if (tipo == "1")
                    {
                        row.Cells[9].Value = "Admin";



                    }
                    if (tipo == "2")
                    {


                        row.Cells[9].Value = "Pos";



                    }


                }
            }
            catch { }
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
   
    public partial class Clientes : Form
    {
       
        public string idcliente;
        public Clientes()
        {
            InitializeComponent();
        }
        public void listarcliente()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    int idclient = Convert.ToInt32(idcliente);
                    var lst = db.Cliente.Where(c => c.ID_Cliente ==idclient);
                    foreach (var ocliente in lst)
                    {
                       
                        txtnombre.Text = ocliente.Nombre;
                        txt_apellido.Text = ocliente.Apellidos;
                        txtDetalle.Text = ocliente.Dirreccion;
                        txt_lugartrabajo.Text = ocliente.Lugar_De_trabajo;
                         txt_cedula.Text = ocliente.Cedula;
                        txt_telefono.Text = ocliente.Telefono;
                        txt_limite_credito.Text = ocliente.Limite_Credito.ToString();
                    }

                }

            }

            catch { }
        }
        public void addcliente()
        {
            try
            {


                using (beutyEntities db = new beutyEntities())

                {
                    Cliente ocliente = new Cliente();
                    ocliente.Nombre = txtnombre.Text;
                    ocliente.Apellidos = txt_apellido.Text;
                    ocliente.Dirreccion = txtDetalle.Text;
                    ocliente.Telefono = txt_telefono.Text;
                    ocliente.Lugar_De_trabajo= txt_lugartrabajo.Text;
                    ocliente.Cedula = txt_cedula.Text;
                    ocliente.Limite_Credito =Convert.ToDouble(txt_limite_credito.Text);
                    ocliente.estatus = true;         

                    db.Cliente.Add(ocliente);
                    db.SaveChanges();
                    MessageBox.Show("Cliente Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }

            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void updcliente()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {

                    int idclient = Convert.ToInt32(idcliente);

                    Cliente ocliente = db.Cliente.Find(idclient);
                    ocliente.Nombre = txtnombre.Text;
                    ocliente.Apellidos = txt_apellido.Text;
                    ocliente.Dirreccion = txtDetalle.Text;
                    ocliente.Telefono = txt_telefono.Text;
                    ocliente.Lugar_De_trabajo = txt_lugartrabajo.Text;
                    ocliente.Cedula = txt_cedula.Text.Trim();
                    ocliente.Limite_Credito = Convert.ToDouble(txt_limite_credito.Text);
                    db.Entry(ocliente).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Datos Actualizados.");
                }

            }

            catch { }
        }
        public void verificar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.Cliente.Where(c => c.Cedula == txt_cedula.Text);
                    foreach (var ocliente in lst)
                    {
                        MessageBox.Show("Ya existe un cliente registrado con la misma cedula","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_cedula.Clear();
                        txt_cedula.Focus();

                    }

                }

            }

            catch { }
        }
        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
            this.Close();
        }


        private void toolStripGuardar_Click_1(object sender, EventArgs e)
        {
            

        }

        private void TopsEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_nuevo_Click_1(object sender, EventArgs e)
        {
          
        }

        private void MaskCedula_Leave(object sender, EventArgs e)
        {
        


        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            listarcliente();
         
        }

        private void Txt_limite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {

           
        }

        private void txt_limite_credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            if (idcliente == null)
            {
                if(txt_cedula.Text =="")
                {
                    MessageBox.Show("Por favor completar el campo Cedula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    addcliente();
                    Close();
                }
              
            }
            else
            {
                if (txt_cedula.Text == "")
                {
                    MessageBox.Show("Por favor completar el campo Cedula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    updcliente();
                    Close();

                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_cedula_Leave(object sender, EventArgs e)
        {
            verificar();
        }
    }
}
    
    

 



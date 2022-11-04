using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistarVentas
{
    public partial class Form_registro : Form
    {
        public string imagen;
        public int  idempresa;
        public Form_registro()
        {
            InitializeComponent();
        }
        public void continuar()
        {
            var ologin = new Login1();
            ologin.Show();
            Hide();
        }
        public void addconfig()
        {
            try
            {
              byte[] file = null;

                Stream myStram = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStram.CopyTo(ms);
                    file = ms.ToArray();
                }
              
                using (beutyEntities db = new beutyEntities())
                {

                    configuracion oconfig = new configuracion();
                    oconfig.nombre = txtnombre.Text;
                    oconfig.descripcion = txtempresa.Text;
                    oconfig.rnc = txt_rnc.Text;
                    oconfig.telefono = txt_telefono.Text;
                    oconfig.logo = file;
                    oconfig.fecha = DateTime.Now; 
                    oconfig.estatus = false;
                    db.configuracion.Add(oconfig);
                    db.SaveChanges();
                    idempresa = oconfig.idcconfig;
                  
                   
                }

            }

            catch { }
        }
        //public void addconfignube()
        //{
        //    try
        //    {
              
        //        using (sdeptech_softmarketEntities1 db = new sdeptech_softmarketEntities1())
        //        {

        //            Cliente_empresa oconfig = new Cliente_empresa();
        //            oconfig.nombre = txtnombre.Text;
        //            oconfig.empresa = txtempresa.Text;
        //            oconfig.rnc = txt_rnc.Text;
        //            oconfig.correo = txt_correo.Text;
        //            oconfig.telefono = txt_telefono.Text;
        //            oconfig.sistema = txt_usuario.Text;
        //            oconfig.password = txt_usuario.Text;
        //            oconfig.ingreso = DateTime.Now;
        //            oconfig.estado = "I";
        //            db.Cliente_empresa.Add(oconfig);
        //            db.SaveChanges();
        //        }

        //    }

        //    catch { }
        //}
        public void addusuario()
        {
            try
            {
                

                using (beutyEntities db = new beutyEntities())
                {

                    login ousuario = new login();
                    ousuario.nombre = txtnombre.Text;
                    ousuario.usuario = txt_usuario.Text;
                    ousuario.pass = txt_contraseña.Text;
                    ousuario.tipo = 1;
                    ousuario.estatus = true;
                    ousuario.empresa = idempresa;

                    db.login.Add(ousuario);
                    db.SaveChanges();
                    MessageBox.Show("Datos Registrados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continuar();
                }

            }

            catch { }
        }
        public void guardar()
        {
            if (string.IsNullOrEmpty(txtempresa.Text))
            {

                MessageBox.Show("Debe completar el campo Nombre de la empresa.");

                return;
            }
            if (string.IsNullOrEmpty(txt_rnc.Text))
            {

                MessageBox.Show("Debe completar  el campo de Rnc");

                return;
            }
            if (string.IsNullOrEmpty(txtnombre.Text))
            {

                MessageBox.Show("Debe completar  el campo del nombre del Propietario");

                return;
            }
            if (string.IsNullOrEmpty(txt_telefono.Text))
            {

                MessageBox.Show("Debe completar  el campo de telefono");

                return;
            }
            if (string.IsNullOrEmpty(txt_usuario.Text))
            {

                MessageBox.Show("Debe completar  el campo de nombre de usuario");

                return;
            }
            if (string.IsNullOrEmpty(txt_correo.Text))
            {

                MessageBox.Show("Debe completar  el campo de correo");

                return;
            }
            if (string.IsNullOrEmpty(txt_contraseña.Text))
            {

                MessageBox.Show("Debe completar  el campo de contraseña");

                return;
            }
            if (string.IsNullOrEmpty(imagen))
            {

                MessageBox.Show("Debe seleccionar el logo de su empresa");

                return;
            }
            else
            {
              
                addconfig();
                addusuario();

            }
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todas las imágenes soportadas|*.jpeg;*.png;*.bmp;*.ico";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagen = openFileDialog1.FileName;
                piclogo.Load(openFileDialog1.FileName);

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

        private void Form_registro_Load(object sender, EventArgs e)
        {

        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == txt_confirmacion.Text)
            {
                guardar();
            }

            else
            {
                MessageBox.Show("Las Contraseñas no coinciden.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

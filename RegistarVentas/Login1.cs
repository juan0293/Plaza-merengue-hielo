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
using System.IO;

namespace RegistarVentas
{
    public partial class Login1 : Form
    {
        public Boolean estado;
        public Login1()
        {
            InitializeComponent();
        }

        
        public void user()
        {
            try
            {

                if (string.IsNullOrEmpty(txt_usuario.Text))
                {
                    // check voor invoeren van wachtwoord en email.
                    MessageBox.Show("Por favor completar campo Usuario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_usuario.Focus();
                    return;
                }
                var login = new acceso();
                string nombre_user, password;

                nombre_user = txt_usuario.Text;
                password = txt_pass.Text;

                if (!login.login(nombre_user, password))
                {
                    MessageBox.Show("Contraseña o Usuario Incorrecto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_pass.Clear();
                    txt_pass.Focus();
                }
                else
                {
                    if (Global.tipo == "1")
                    {
                        listarconfig();
                        var menu = new Menu();
                        menu.Show();
                        Hide();
                    }
                    else if (Global.tipo == "2")
                    {
                        listarconfig();
                        var menu = new Facturar();
                        menu.Show();
                        Hide();
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void listarestado()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.configuracion.ToList();
                    foreach (var oconfig in lst)
                    {

                        estado = Convert.ToBoolean(oconfig.estatus);
                    }

                }

            }

            catch { }
        }
        public void acceso()
        {
            try
            {

                if (string.IsNullOrEmpty(txt_usuario.Text))
                {
                    // check voor invoeren van wachtwoord en email.
                    MessageBox.Show("Por favor completar campo Usuario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_usuario.Focus();
                    return;
                }
                var login = new accesoremoto();
                string nombre_user, password;

                nombre_user = txt_usuario.Text;
                password = txt_pass.Text;

              


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
     
       
        public void internet()
        {
            System.Uri Url = new System.Uri("http://www.google.com/");
            System.Net.WebRequest WebRequest;
            WebRequest = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse objResp;
            try
            {
                objResp = WebRequest.GetResponse();
                //result = "Su dispositivo está correctamente conectado a internet";
               
                objResp.Close();
                WebRequest = null;
            }
            catch
            {
                //result = "Para un mejor desempeño por favor conectarse a internet ";
               // MessageBox.Show(result, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var menu = new Menu();
                menu.Show();
                this.Hide();
                WebRequest = null;
            }
        }
        public void listarconfig()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.configuracion.ToList();
                    foreach (var oconfig in lst)
                    {

                        Global.nombre_empresa = oconfig.nombre;
                        Global.descripcion = oconfig.descripcion;
                        Global.rnc = oconfig.rnc;
                        Global.logo = oconfig.logo;
                        Global.telefono = oconfig.telefono;
                        Global.instegram = oconfig.redes;
                        Global.porcentaje = oconfig.p.ToString();
                    }

                    }

            }

            catch { }
        }
        public void iniciar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.Cliente.ToList();
                    foreach (var ocliente in lst)
                    {
                        if (ocliente != null)
                        {
                          
                        }

                        else
                        {
                            Form_termino_condicion abrir = new Form_termino_condicion();
                            abrir.Show();
                            Hide();
                        }

                    }

                }

            }

            catch { }
        }
        private void btn_Ingresar_Click(object sender, EventArgs e)

        {
            // LLAMAMOS SOLO LOS TEXBOX QUE CONTIENEN USUARIO Y CONTRASENA
            //    if(estado ==true)
            //{
                user();

            //}
            //if (estado == false)
            //{
            //    acceso();

            //}


        }
        public void listarlogo()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.configuracion.ToList();
                    foreach (var oconfig in lst)
                    {

                        MemoryStream ms = new MemoryStream(oconfig.logo);
                        Bitmap bmp = new Bitmap(ms);
                        piclogo.Image = bmp;
                    }

                }

            }

            catch { }
        }
        private void Login1_Load(object sender, EventArgs e)
        {
            listarlogo();
            //iniciar();
            //listarestado();
        }

        private void Login1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                user();


            }    //if (estado == false)
                //{
                //    acceso();

                //}


                //}
            }

        private void btn_Ingresar_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

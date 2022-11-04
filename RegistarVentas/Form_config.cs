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
    public partial class Form_config : Form
    {
        public int idconfig;

        public Form_config()
        {
            InitializeComponent();
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
                        idconfig = oconfig.idcconfig;
                        txtnombre.Text = oconfig.nombre;
                        txtDetalle.Text = oconfig.descripcion;
                        txt_rnc.Text = oconfig.rnc;
                        txt_telefono.Text = oconfig.telefono;
                        txt_instegram.Text = oconfig.redes;
                        MemoryStream ms = new MemoryStream(oconfig.logo);
                        Bitmap bmp = new Bitmap(ms);
                        piclogo.Image = bmp;
                    }

                }

            }

            catch { }
        }
        public void updlogo()
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

                    configuracion oconfig = db.configuracion.Find(idconfig);             
                    oconfig.logo = file;
                    db.Entry(oconfig).State = EntityState.Modified;
                    db.SaveChanges();
                  
                }

            }

            catch { }
        }
        public void updconfig()
        {
            try
            {
              
                using (beutyEntities db = new beutyEntities())
                {

                  

                    configuracion oconfig = db.configuracion.Find(idconfig);
                    oconfig.nombre = txtnombre.Text;
                    oconfig.descripcion = txtDetalle.Text;
                    oconfig.rnc = txt_rnc.Text;
                    oconfig.telefono = txt_telefono.Text;
                    oconfig.redes = txt_instegram.Text;
                
                    db.Entry(oconfig).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Datos Actualizados.","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarconfig();
                }

            }

            catch { }
        }
        private void picsubir_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todas las imágenes soportadas|*.jpeg;*.png;*.bmp;*.ico";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                piclogo.Load(openFileDialog1.FileName);
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            updconfig();
            updlogo();
        }

        private void Form_config_Load(object sender, EventArgs e)
        {
            listarconfig();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picmuestra_Click(object sender, EventArgs e)
        {
            factura abrir = new factura();
            abrir.Show();
        }
    }
}

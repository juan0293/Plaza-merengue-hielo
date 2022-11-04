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
    public partial class Form_activacion : Form
    {
        public int  idmempresa;
        public Form_activacion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //public void verificar()
        //{
        //    try
        //    {
        //        using (sdeptech_softmarketEntities1 db = new sdeptech_softmarketEntities1())

        //        {

        //            var lst = db.licencias.Where(i => i.codigo == txtlicencia.Text);
        //            foreach (var oproducto in lst)
        //            {
        //                MessageBox.Show("Ya existe un producto registrado con esta licencia");
        //                txtlicencia.Clear();
        //                txtlicencia.Focus();


        //            }

        //        }

        //    }

        //    catch { }
        //}
        //public void verificarlicencia()
        //{
        //    try
        //    {
        //        using (sdeptech_softmarketEntities1 db = new sdeptech_softmarketEntities1())

        //        {
        //            var lst = db.serials.Where(i => i.serial1 == txtlicencia.Text);
        //            foreach (var oproducto in lst)
        //            {
                       
        //                   if(oproducto != null)
        //                {
        //                    addconfignube();
        //                    updconfig();
        //                }

        //                else
        //                {
        //                    MessageBox.Show("Esta licencia ya esta en uso, por favor llamar al Ing Juan E. Reyes al 809-707-4010", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
                        
                        

        //            }

        //        }

        //    }

        //    catch { }
        //}
        public void listaridempresa()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.configuracion.ToList();
                    foreach (var oproducto in lst)
                    {
                        idmempresa = oproducto.idcconfig;
                    }

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

                 
                    configuracion oconfig = db.configuracion.Find(idmempresa);
                    oconfig.estatus = true;  
                    db.Entry(oconfig).State = EntityState.Modified;
                    db.SaveChanges();
                    Application.Exit();
                }

            }

            catch { }
        }
        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }
        //public void addconfignube()
        //{
        //    try
        //    {

        //        using (sdeptech_softmarketEntities1 db = new sdeptech_softmarketEntities1())
        //        {

        //            licencia oconfig = new licencia();
        //            oconfig.codigo = txtlicencia.Text;
                 
        //            db.licencias.Add(oconfig);
        //            db.SaveChanges();
        //            MessageBox.Show("El Producto ha sido activado exitosamente! Gracias por preferir a Softmarket.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
        //        }

        //    }

        //    catch { }
        //}
        private void txtlicencia_Leave(object sender, EventArgs e)
        {
          
            
        }

        private void Form_activacion_Load(object sender, EventArgs e)
        {
            listaridempresa();
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
         

        }

        private void btn_activar_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtlicencia.Text))
            {

                MessageBox.Show("Debe completar el campo licencia");

                return;
            }
            else
            {
               
            }
           
        }
    }
}

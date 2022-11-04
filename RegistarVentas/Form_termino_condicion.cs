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
    public partial class Form_termino_condicion : Form
    {
        public Form_termino_condicion()
        {
            InitializeComponent();
        }

        private void chb_acepto_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_acepto.Checked == true)
            {
                btn_aceptar.Enabled = true;
            }
           else
            {
                btn_aceptar.Enabled = false;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Form_registro abrir = new Form_registro();
            abrir.Show();
        }
        //public void terminos()
        //{
        //    try
        //    {

        //        using (sdeptech_softmarketEntities1 db = new sdeptech_softmarketEntities1())

        //        {
                    
        //            var lst = db.acepta_terminos.ToList();

        //            foreach (var oempresa in lst)
        //            {

        //                ricc_terminos.Text = oempresa.detalle;


        //            }

        //        }
        //    }
        //    catch { }


        //}
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_termino_condicion_Load(object sender, EventArgs e)
        {
        }
    }
}

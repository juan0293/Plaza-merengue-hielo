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
    public partial class Form_agregar_cliente : Form
    {
        public delegate void pasar(string clientep, string rncp, string documento);
        public event pasar pasado;
        public Form_agregar_cliente()
        {
            InitializeComponent();
        }
        public void verificar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.venta.Where(i => i.rnc == txt_rnc.Text);
                    foreach (var oproducto in lst)
                    {
                        txt_cliente.Text = oproducto.cliente;
                    }

                }

            }

            catch { }
        }
        private void Form_agregar_cliente_Load(object sender, EventArgs e)
        {

        }

        private void txt_rnc_KeyUp(object sender, KeyEventArgs e)
        {
            //verificar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cliente.Text == "")
            {
                txt_cliente.Focus();
            }
            else if (txt_rnc.Text == "")
            {
                txt_rnc.Focus();
            }
            else
            {
                pasado(txt_cliente.Text, txt_rnc.Text, "");
                this.Hide();
                // Global.facturafiscal = "Factura de Consumo";
            }

           
        }

        private void txt_rnc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pasado("", "", "Factura de Consumo");
            Close();
        }

        private void txt_rnc_Leave(object sender, EventArgs e)
        {
            verificar();
        }
    }
}

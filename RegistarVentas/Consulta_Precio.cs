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
    public partial class Consulta_Precio : Form
    {
        public Consulta_Precio()
        {
            InitializeComponent();
        }

        private void btnBuscarPrecio_Click(object sender, EventArgs e)
        {
           
          
        }

        private void Consulta_Precio_KeyDown(object sender, KeyEventArgs e)
        {
            
        
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

       

        private void Txt_Precio_TextChanged(object sender, EventArgs e)
        {
            Double Tpago;
            if (Double.TryParse(Txt_Precio.Text, out Tpago))
                Txt_Precio.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", Tpago);

        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
    }
}

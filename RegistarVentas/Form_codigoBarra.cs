using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ZXing;

namespace RegistarVentas
{
    public partial class Form_codigoBarra : Form
    {
        public string detalle, codigo, precio;
        public Form_codigoBarra()
        {
            InitializeComponent();
        }
        public void listarIDproducto()
        {
            try
            {
                txtprecio.Clear();
                txtdetalle.Clear();
                using (beutyEntities db = new beutyEntities())
                {
                    string cod = Convert.ToString(txt_codigo.Text.Trim());
                    var lst = db.Producto.Where(i => i.codigo == cod);
                    foreach (var oproducto in lst)
                    {
                        codigo = oproducto.codigo;
                        precio = oproducto.precio_salida.ToString();
                        detalle = oproducto.Descripcion_Producto;
                        codigo = oproducto.codigo;
                        txtprecio.Text = Convert.ToDecimal(oproducto.precio_salida).ToString("#,##0.00");
                       txtdetalle.Text = oproducto.Descripcion_Producto.ToString();
                    }
                }
            }
         catch { }
        }
        public void  codigobarraimagen()
        {
            try
            {
                BarcodeWriter bc = new BarcodeWriter();
                bc.Format = BarcodeFormat.CODE_128;
                Bitmap bm = new Bitmap(bc.Write(txt_codigo.Text), 100, 80);
                pixbarra.Image = bm;
            }
            catch (Exception)
            {
                MessageBox.Show("Coloque el codigo del producto.");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void numeros()
        {
           
        }
        private void Form_codigoBarra_Load(object sender, EventArgs e)
        {
            txtcodigoletra.Clear();
        }
        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void Form_codigoBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listarIDproducto();
                codigobarraimagen();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
       
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (var g = e.Graphics)
            {
                Font font = new Font("Arial", 6, FontStyle.Bold, GraphicsUnit.Point);
                Font font1 = new Font("Arial", 6, FontStyle.Regular, GraphicsUnit.Point);
                int x = 15; int des1 = 55; int des2 = 70; int des3 = 79; int des4 = 88;
                e.Graphics.DrawString(("        "+Global.nombre_empresa).ToUpper(), font, Brushes.Black, new RectangleF(30, x, 200, 0));
                g.DrawImage(pixbarra.Image, new Rectangle(65, 25, 80, 60));
                e.Graphics.DrawString("    "+"PROD.: "+(txtdetalle.Text).ToUpper(), font, Brushes.Black, new RectangleF(30, x + des2, 200, 0));
               // e.Graphics.DrawString("    " +"PRECIO: "+ (txtcodigoletra.Text).ToUpper(), font, Brushes.Black, new RectangleF(30, x + des3, 200, 0));
                e.Graphics.DrawString("    " + "PRECIO: " + (txtprecio.Text).ToUpper(), font, Brushes.Black, new RectangleF(30, x + des3, 200, 0));
                //e.Graphics.DrawString("    " +"FECHA: " + DateTime.Now.ToShortDateString(), font, Brushes.Black, new RectangleF(30, x + des3, 200, 0));
                e.Graphics.DrawString("    " +"TELÉFONO: " + Global.telefono, font, Brushes.Black, new RectangleF(30, x + des4, 200, 0));
            }
        }
        private void picbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cantidad.Text == "" || txt_cantidad.Text == "0" || pixbarra.Image == null)
                {
                    txt_cantidad.Focus();
                    txt_cantidad.BackColor = Color.Aquamarine;
                }
                else
                {
                    ticket();
                    imprimir1();
                }
            }
            catch
            {

            }
        }
        public void imprimir1()
        {
            int cantidad = Convert.ToInt16(txt_cantidad.Text);
            PrintDialog copies = new PrintDialog();
            copies.Document = printDocument1;
            copies.AllowSelection = true;
            copies.AllowSomePages = true;
            copies.PrinterSettings.Copies = (short)cantidad;
            printDocument1.Print();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            if(txt_codigo.Text == "")
            {
                txtcodigoletra.Clear();
            }

            string miresultado = "";

            string precio = txtprecio.Text;

            foreach (Char letra in precio)
            {
                if (Convert.ToString(letra) == "1")
                {
                    miresultado += "L";
                }
                else if (Convert.ToString(letra)  == "2")
                {
                    miresultado += "E";
                }
                else if (Convert.ToString(letra) == "3")
                {
                    miresultado += "G";
                }
                else if (Convert.ToString(letra) == "4")
                {
                    miresultado += "U";
                }
                else if (Convert.ToString(letra) == "5")
                {
                    miresultado += "M";
                }
                else if (Convert.ToString(letra) == "6")
                {
                    miresultado += "I";
                }
                else if (Convert.ToString(letra) == "7")
                {
                    miresultado += "N";
                }
                else if (Convert.ToString(letra) == "8")
                {
                    miresultado += "O";
                }
                else if (Convert.ToString(letra) == "9")
                {
                    miresultado += "S";
                }
                else if (Convert.ToString(letra) == "0")
                {
                    miresultado += "A";
                }
                else if (Convert.ToString(letra) == ",")
                {
                    miresultado += ",";
                }
                else if (Convert.ToString(letra) == ".")
                {
                    miresultado += ".";
                }

                txtcodigoletra.Text = (miresultado).ToString();
            }














            //   cadena = this.UpdateZOrder


            //char[] caracteres = total.ToCharArray();
            //Array.Sort(caracteres);
            //txtcodigoletra.Text = new String(caracteres).ToString();



        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            listarIDproducto();
            codigobarraimagen();
        }

        public static class myPrinters
        {
            [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetDefaultPrinter(string Name);
        }
        public void ticket()
        {
            string pname = "TICKET";
            myPrinters.SetDefaultPrinter(pname);
        }
    }
}

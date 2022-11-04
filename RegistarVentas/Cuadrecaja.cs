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
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Mail;

namespace RegistarVentas
{
    public partial class formCuadrecaja : Form
    {
        public double suma = 0;
        public double efectivo, credito, descuento, tarjeta, anulada, resultado, total, pagos, totalcuadre, totaldeglose, inicioMonto, gastoscuadre = 0;
        public void Listarefetivo()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.venta.ToList().Where(c => c.fecha == fecha && c.usuario == Convert.ToInt32(Global.iduser) && c.estado == "Normal");
                    foreach (var ocuadre in lst)
                    {
                        efectivo += Convert.ToDouble(ocuadre.monto);
                    }
                   // MessageBox.Show(efectivo.ToString());
                }

            }


            catch { }
        }

        public void Listargastos()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.gasto.ToList().Where(c => c.fecha == fecha);
                    foreach (var ocuadre in lst)
                    {
                        gastoscuadre += Convert.ToDouble(ocuadre.monto);
                    }
                    // MessageBox.Show(efectivo.ToString());
                }

            }
            catch { }
        }

        public void Listartarjeta()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.venta.ToList().Where(c =>  c.fecha == fecha && c.usuario == Convert.ToInt32(Global.iduser));
                    foreach (var ocuadre in lst)
                    {
                        tarjeta += Convert.ToDouble(ocuadre.tarjeta);

                    }
                    //MessageBox.Show(deposito.ToString());
                }

            }

            catch { }
        }
        public void Listarcredito()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.CXC.ToList().Where(c =>  c.Fecha == fecha && c.usuario == Convert.ToInt32(Global.iduser));
                    foreach (var ocuadre in lst)
                    {
                        credito += Convert.ToDouble(ocuadre.Monto);

                    }
                    //MessageBox.Show(tarjeta.ToString());
                }

            }

            catch { }
        }
        public void Listardescuento()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.venta.ToList().Where(c =>  c.fecha == fecha && c.usuario == Convert.ToInt32(Global.iduser));
                    foreach (var ocuadre in lst)
                    {
                        descuento += Convert.ToDouble(ocuadre.descuento);

                    }
                    //MessageBox.Show(anulada.ToString());
                }

            }

            catch { }
        }
        public void Listarpagos()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.pagos.ToList().Where(c => c.fecha == fecha && c.idusuario == Convert.ToInt32(Global.iduser));
                    foreach (var ocuadre in lst)
                    {
                        pagos += Convert.ToDouble(ocuadre.monto);

                    }
                    //MessageBox.Show(anulada.ToString());
                }

            }

            catch { }
        }
        public void Listartotal()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.venta.ToList().Where(c => c.fecha == fecha && c.usuario == Convert.ToInt32(Global.iduser) && c.estado =="Normal");
                    foreach (var ocuadre in lst)
                    {
                        total += Convert.ToDouble(ocuadre.monto);

                    }
                    //MessageBox.Show(anulada.ToString());
                }

            }

            catch { }
        }
        public void deglose()
        {
            try
            {
                double m1 = 0; m1 = Convert.ToDouble(txt1.Text) * 1;
                double m2 = 0; m2 = Convert.ToDouble(txt5.Text) * 5;
                double m3 = 0; m3 = Convert.ToDouble(txt10.Text) * 10;
                double m25 = 0; m25 = Convert.ToDouble(txt_25_mone.Text) * 25;
                double m4 = 0; m4 = Convert.ToDouble(txt50.Text) * 50;
                double m5 = 0; m5 = Convert.ToDouble(txt100.Text) * 100;
                double m6 = 0; m6 = Convert.ToDouble(txt200.Text) * 200;
                double m7 = 0; m7 = Convert.ToDouble(txt500.Text) * 500;
                double m8 = 0; m8 = Convert.ToDouble(txt1000.Text) * 1000;
                double m9 = 0; m9 = Convert.ToDouble(txt2000.Text) * 2000;
                double m10 = 0; m10 = Convert.ToDouble(txtcredito.Text);
                double m11 = 0; m11 = Convert.ToDouble(txttarjeta.Text);



                suma = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m25 ;
                totaldeglose = suma + m10 + m11;

            }
            catch { MessageBox.Show("Por ingresar cero si no posee de esa moneda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void cuadre()
        
        {
             
            totalcuadre = total;

        }
        public void bakup()
        {
            try
            {
                using (SqlConnection conn = Conectado.conexion())
                {
                    string database = conn.Database.ToString();
                



                  string cmd = "BACKUP DATABASE [" + database + "] TO DISK ='" + Txt_guardar_ruta.Text + "\\" + "beuty" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                        using (SqlCommand command = new SqlCommand(cmd, conn))
                        {
                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();

                            }
                            command.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("El Backup se Realizo exitosamente", "Backup Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                        }

                    

                }
            }
            catch { }

        }
        public void imprimifactura()
        {
            Form_cuadre fat = new Form_cuadre();
            datos dat = new datos();

            double resultao1 = efectivo - tarjeta;
            dat.efectivo = efectivo.ToString();
            dat.tarejeta = tarjeta.ToString();
            dat.credito = credito.ToString();
            dat.total = totalcuadre.ToString();
            dat.usuario = Global.nombre;
            dat.fecha = DateTime.Now.ToShortDateString();
            dat.efectivod = suma.ToString();
            dat.tarejetad = txttarjeta.Text;
            dat.descuento = pagos.ToString();
            dat.creditod = txtcredito.Text;
            dat.logo = Global.logo;
            dat.descripcion = Global.descripcion;
            dat.rnc = Global.rnc;
            dat.instegram = Global.instegram;
            dat.whatsaap = Global.telefono;
            dat.totald = totaldeglose.ToString();
            fat.datos.Add(dat);
            fat.Show();

        }
        public formCuadrecaja()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void formCuadrecaja_Load(object sender, EventArgs e)

        {
            Listargastos();
            Listarefetivo();
            Listarcredito();
            Listartarjeta();
            Listardescuento();
            Listarpagos();
            Listartotal();
            cuadre();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            if (txt1.Text == "") 
            {

                txt1.Text = "0";
            }
        }

        private void txt5_Leave(object sender, EventArgs e)
        {
          
        }

        private void txt_10_Leave(object sender, EventArgs e)
        {
        }

        private void txt25_Leave(object sender, EventArgs e)
        {
           
        }

        private void txt50_Leave(object sender, EventArgs e)
        {
            if (txt50.Text == "") 
            {

                txt50.Text = "0";

            }
        }

        private void txt100_Leave(object sender, EventArgs e)
        {
            if (txt100.Text == "")
            {

                txt100.Text = "0";

            }
        }

        private void txt200_Leave(object sender, EventArgs e)
        {
            if (txt200.Text == "")
            {

                txt200.Text = "0";

            }
        }

        private void txt500_Leave(object sender, EventArgs e)
        {
            if (txt500.Text == "") 
            {

                txt500.Text = "0";

            }
        }

        private void txt1000_Leave(object sender, EventArgs e)
        {
            if (txt1000.Text =="" )
            {

                txt1000.Text = "0";
            }
        }

        private void txt2000_Leave(object sender, EventArgs e)
        {
            if (txt2000.Text == "" )
            {

                txt2000.Text = "0";

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt1_Leave_1(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "0";
            }
        }

        private void txt5_Leave_1(object sender, EventArgs e)
        {
            if (txt5.Text == "")
            {
                txt5.Text = "0";
            }
        }

        private void txt10_Leave(object sender, EventArgs e)
        {
            if (txt10.Text == "")
            {
                txt10.Text = "0";
            }
        }

        private void txt50_Leave_1(object sender, EventArgs e)
        {
            if (txt50.Text == "")
            {
                txt50.Text = "0";
            }
        }

        private void txt100_Leave_1(object sender, EventArgs e)
        {
            if (txt100.Text == "")
            {
                txt100.Text = "0";
            }
        }

        private void txt200_Leave_1(object sender, EventArgs e)
        {
            if (txt200.Text == "")
            {
                txt200.Text = "0";
            }
        }

        private void txt500_Leave_1(object sender, EventArgs e)
        {
            if (txt500.Text == "")
            {
                txt500.Text = "0";
            }
        }

        private void txt1000_Leave_1(object sender, EventArgs e)
        {
            if (txt1000.Text == "")
            {
                txt1000.Text = "0";
            }
        }

        private void txt2000_Leave_1(object sender, EventArgs e)
        {
            if (txt2000.Text == "")
            {
                txt2000.Text = "0";
            }
        }

        private void txtcredito_Leave(object sender, EventArgs e)
        {
            if (txtcredito.Text == "")
            {
                txtcredito.Text = "0";
            }
        }

        private void txttarjeta_Leave(object sender, EventArgs e)
        {
            if (txttarjeta.Text == "")
            {
                txttarjeta.Text = "0";
            }
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt10_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt100_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt200_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt500_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt1_Leave_2(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "0";
            }
        }

        private void txt5_Leave_2(object sender, EventArgs e)
        {
            if (txt5.Text == "")
            {
                txt5.Text = "0";
            }
        }

        private void txt10_Leave_1(object sender, EventArgs e)
        {
            if (txt10.Text == "")
            {
                txt10.Text = "0";
            }
        }

        private void txt_25_mone_Leave(object sender, EventArgs e)
        {
            if (txt_25_mone.Text == "")
            {
                txt_25_mone.Text = "0";
            }
        }

        private void txt50_Leave_2(object sender, EventArgs e)
        {
            if (txt50.Text == "")
            {
                txt50.Text = "0";
            }
        }

        private void txt100_Leave_2(object sender, EventArgs e)
        {
            if (txt100.Text == "")
            {
                txt100.Text = "0";
            }
        }

        private void txt200_Leave_2(object sender, EventArgs e)
        {
            if (txt200.Text == "")
            {
                txt200.Text = "0";
            }
        }

        private void txt500_Leave_2(object sender, EventArgs e)
        {
            if (txt500.Text == "")
            {
                txt500.Text = "0";
            }
        }

        private void txt1000_Leave_2(object sender, EventArgs e)
        {
            if (txt1000.Text == "")
            {
                txt1000.Text = "0";
            }
        }

        private void txt2000_Leave_2(object sender, EventArgs e)
        {
            if (txt2000.Text == "")
            {
                txt2000.Text = "0";
            }
        }

        private void txttarjeta_Leave_1(object sender, EventArgs e)
        {
            if (txttarjeta.Text == "")
            {
                txttarjeta.Text = "0";
            }
        }

        private void txtcredito_Leave_1(object sender, EventArgs e)
        {
            if (txtcredito.Text == "")
            {
                txtcredito.Text = "0";
            }
        }

        public void imprimir_pre_ticket()
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            double descuadre = (Convert.ToDouble(suma + Convert.ToDouble(txttarjeta.Text) + Convert.ToDouble(txtcredito.Text)) - Convert.ToDouble(total + inicioMonto - gastoscuadre + pagos));
            double resultado = efectivo - tarjeta - credito;
            try
            {

                double m1 = 0; m1 = Convert.ToDouble(txt1.Text) * 1;
                double m5 = 0; m5 = Convert.ToDouble(txt5.Text) * 5;
                double m10 = 0; m10 = Convert.ToDouble(txt10.Text) * 10;
                double m25 = 0; m25 = Convert.ToDouble(txt_25_mone.Text) * 25;
                double m50 = 0; m50 = Convert.ToDouble(txt50.Text) * 50;
                double m100 = 0; m100 = Convert.ToDouble(txt100.Text) * 100;
                double m200 = 0; m200 = Convert.ToDouble(txt200.Text) * 200;
                double m500 = 0; m500 = Convert.ToDouble(txt500.Text) * 500;

                double m2000 = 0; m2000 = Convert.ToDouble(txt2000.Text) * 2000;
                double mtc = 0; mtc = Convert.ToDouble(txttarjeta.Text);


                Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                Font font1 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                Font font2 = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);
                Font font3 = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
                Font font4 = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Point);
                Font font5 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
                Font font6 = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point);
                Font font8 = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point);
                Font font7 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font font12 = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                Font font13 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);

                int y = 20;



                e.Graphics.DrawString(Global.nombre_empresa.ToUpper(), font13, Brushes.Black, new RectangleF(5, 2, 300, 0));
                //e.Graphics.DrawString("C/" + global.descripcion, font5, Brushes.Black, new RectangleF(25, y += 30, 250, 50));
                e.Graphics.DrawString("CUADRE DE CAJA", font8, Brushes.Black, new RectangleF(75, y += 35, 200, 50));
                e.Graphics.DrawString("Usuario: " + Global.nombre, font6, Brushes.Black, new RectangleF(25, y += 20, 200, 50));
                e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString() + "   Hora: " + DateTime.Now.ToShortTimeString(), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Total Cierre: " + Convert.ToDouble(total + pagos + inicioMonto - gastoscuadre).ToString("#,##0.00"), font8, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(25, y += 12, 250, 50));
                e.Graphics.DrawString("DESGLOSE DEL SISTEMA", font1, Brushes.Black, new RectangleF(25, y += 15, 200, 50));
                //e.Graphics.DrawString("Fondo de Caja: " + Convert.ToDouble(inicioMonto).ToString("#,##0.00"), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Efectivo: " + Convert.ToDouble(resultado).ToString("#,##0.00"), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Tarjeta: " + Convert.ToDouble(tarjeta).ToString("#,##0.00"), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Credito: " + Convert.ToDouble(credito).ToString("#,##0.00"), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Ingresos: " + Convert.ToDouble(pagos).ToString("#,##0.00"), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Gastos: " + Convert.ToDouble(gastoscuadre).ToString("#,##0.00"), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("SubTotal: " + Convert.ToDouble(total + pagos + inicioMonto - gastoscuadre).ToString("#,##0.00"), font8, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(25, y += 12, 250, 50));
                e.Graphics.DrawString("DESGLOSE DEL CAJERO", font1, Brushes.Black, new RectangleF(25, y += 15, 200, 50));
                e.Graphics.DrawString("Efectivo: " + Convert.ToDouble(suma).ToString("#,##0.00"), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Tarjeta: " + Convert.ToDouble(txttarjeta.Text).ToString("#,##0.00"), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Credito: " + Convert.ToDouble(txtcredito.Text).ToString("#,##0.00"), font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Total: " + Convert.ToDouble(totaldeglose).ToString("#,##0.00"), font8, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(25, y += 20, 250, 50));
                e.Graphics.DrawString("2000 = " + txt2000.Text + "        50 = " + txt50.Text, font6, Brushes.Black, new RectangleF(25, y += 20, 200, 50));
                e.Graphics.DrawString("1000 = " + txt1000.Text + "        25 = " + txt_25_mone.Text, font6, Brushes.Black, new RectangleF(25, y += 20, 200, 50));
                e.Graphics.DrawString("500 = " + txt500.Text + "        10 = " + txt10.Text, font6, Brushes.Black, new RectangleF(25, y += 20, 200, 50));
                e.Graphics.DrawString("200 = " + txt200.Text + "        5 = " + txt5.Text, font6, Brushes.Black, new RectangleF(25, y += 20, 200, 50));
                e.Graphics.DrawString("100 = " + txt100.Text + "        1 = " + txt1.Text, font6, Brushes.Black, new RectangleF(25, y += 20, 200, 50));
                e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(25, y += 12, 250, 50));
                e.Graphics.DrawString("DIFERENCIA SISTEMA - CAJERO: ", font1, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Falta (-) Sobra (+) ", font6, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("Descuadre: " + (Convert.ToDouble(descuadre)).ToString("#,##0.00"), font8, Brushes.Black, new RectangleF(25, y += 15, 250, 50));
                e.Graphics.DrawString("RECIBIDO POR: ___________________ ", font1, Brushes.Black, new RectangleF(25, y += 30, 250, 50));
                e.Graphics.DrawString(",", font1, Brushes.Black, new RectangleF(80, y += 40, 250, 50));
            }
            catch
            {

            }
        }

        public static class myPrinters
        {
            [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetDefaultPrinter(string Name);
        }
        public void caja()
        {
            string pname = "CAJA";
            myPrinters.SetDefaultPrinter(pname);
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {

            if (txt1.Text == "") { txt1.Text = "0"; }
            if (txt5.Text == "") { txt5.Text = "0"; }
            if (txt10.Text == "") { txt10.Text = "0"; }
            if (txt_25_mone.Text == "") { txt_25_mone.Text = "0"; }
            if (txt50.Text == "") { txt50.Text = "0"; }
            if (txt100.Text == "") { txt100.Text = "0"; }
            if (txt200.Text == "") { txt200.Text = "0"; }
            if (txt500.Text == "") { txt500.Text = "0"; }
            if (txt1000.Text == "") { txt1000.Text = "0"; }
            if (txt2000.Text == "") { txt2000.Text = "0"; }
            if (txttarjeta.Text == "") { txttarjeta.Text = "0"; }
            if (txtcredito.Text == "") { txtcredito.Text = "0"; }
           
            deglose();
            caja();
            imprimir_pre_ticket();
            Close();
            //bakup();



            using (beutyEntities db = new beutyEntities())
            {

                var lst = db.configuracion.ToList();

                foreach (var ocorreo in lst)
                {
                    Global.correoempresa = ocorreo.correo_empresarial;
                }

            }

            double cierre = Convert.ToDouble(total + inicioMonto - gastoscuadre + pagos);
            double total_sistema = Convert.ToDouble(total - gastoscuadre + pagos);
            double total_usuario = suma + Convert.ToDouble(txttarjeta.Text) + Convert.ToDouble(txtcredito.Text);
            double resultado1 = efectivo - tarjeta - credito;
            double descuadre = (Convert.ToDouble(suma + Convert.ToDouble(txttarjeta.Text) + Convert.ToDouble(txtcredito.Text)) - Convert.ToDouble(total + inicioMonto - gastoscuadre + pagos));

            MailMessage msg = new MailMessage();

            msg.To.Add(Global.correoempresa);
            msg.Subject = "Cuadre Electrónico";
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Bcc.Add("posmarketbonao@gmail.com");

            msg.Body = Global.nombre_empresa + "\n" + "Usuario: " + Global.nombre + " \n Fecha: " + DateTime.Now.ToShortDateString() + "   Hora: " + DateTime.Now.ToShortTimeString() + "\n Total Cierre: " + cierre.ToString("#,##0.00") + "\n------------------------------------" + "\n DESGLOSE DEL SISTEMA" + "\n Efectivo: " + Convert.ToDouble(resultado1).ToString("#,##0.00") + "\n Créditos: " + Convert.ToDouble(credito).ToString("#,##0.00") + "\n Pagos: " + Convert.ToDouble(pagos).ToString("#,##0.00") + "\n Gastos: " + Convert.ToDouble(gastoscuadre).ToString("#,##0.00") + "\n Total: " + total_sistema.ToString("#,##0.00") + "\n------------------------------------" + "\n DESGLOSE DEL CAJERO" + "\n Efectivo: " + Convert.ToDouble(suma).ToString("#,##0.00") + "\n Créditos: " + Convert.ToDouble(txtcredito.Text).ToString("#,##0.00") + "\n Total: " + total_usuario.ToString("#,##0.00") + "\n------------------------------------" + "\n DIFERENCIA CAJA-SISTEMA: " + "\n (-) Falta (+) Sobra " + "\n Descuadre: " + descuadre + "\n CAJA CERRADA.";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = false;
            msg.From = new System.Net.Mail.MailAddress(Global.correoempresa);

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

            client.Credentials = new NetworkCredential("posmarketbonao@gmail.com", "juan0293");
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";

            try
            {
                client.Send(msg);
            }
            catch
            {
                // MessageBox.Show("No existe conexión de a internet ");

            }




        }




        private void txt2000_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtcredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txttarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void Txt_cxc_Leave(object sender, EventArgs e)
        {
          

           
        }

        private void Txt_Tarjeta_Leave(object sender, EventArgs e)
        {
          

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
        }


    }
}
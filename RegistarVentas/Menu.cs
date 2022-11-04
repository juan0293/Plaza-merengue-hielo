using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing.Printing;

namespace RegistarVentas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //public void mensaje()
        //{
        //    try
        //    {

        //        using (sdeptech_softmarketEntities1 db = new sdeptech_softmarketEntities1())

        //        {
        //            int id = Convert.ToInt32(Global.clienteid);
        //            var lst = db.mensajes.Where(c => c.idclient == id && c.estado == "A");

        //            foreach (var oempresa in lst)
        //            {
        //                if (oempresa == null)
        //                {
        //                    panelMensaje.Visible = false;
        //                }
        //                else
        //                {
        //                    rcbtxt.Text = oempresa.asunto.ToString();
        //                    panelMensaje.Visible = true;
        //                }



        //            }

        //        }
        //    }
        //    catch { }
    

        //}
        public static void Exists(string path)
        {


        }


        private void btnNuevo_Producto_Click(object sender, EventArgs e)
        {
            Registro_Producto registro = new Registro_Producto();
            registro.Show();
            Global.Codigo = "";
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            inv inventario = new inv();
            inventario.Show();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            Facturar facturar = new Facturar();

            facturar.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();

            clientes.Show();
        }

        private void btnCxc_Click(object sender, EventArgs e)
        {
            Ingresos abrir = new Ingresos();

            abrir.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Menu_Load(object sender, EventArgs e)
        {
            //mensaje();



            // PERMISOS A LOS USUARIOS DEPENDIENDO DEL ROL ASIGNADO



        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            R_usuarios n = new R_usuarios();
            n.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login1 n = new Login1();
            n.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cierres cierres = new cierres();
            cierres.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reimpresion r = new Reimpresion();
            r.Show();
        }

        private void btn_lavadores_Click(object sender, EventArgs e)
        {
            Form_lavador lavador = new Form_lavador();
            lavador.Show();
        }

        private void btn_reporte_pagos_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_facturacion_Click(object sender, EventArgs e)
        {
            Form_servicio servicio = new Form_servicio();
            servicio.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_empleado empleado = new Form_empleado();
            empleado.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem60_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cambiar el usuario ", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login1 empleado = new Login1();
                empleado.Show();
                Close();
            }
            else
            {
                Application.Exit();
            }
           
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            Registro_Producto abrir = new Registro_Producto();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            inv abrir = new inv();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            Form_categoria abrir = new Form_categoria();
            abrir.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_provedor abrir = new Form_provedor();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {
            Form_gastos abrir = new Form_gastos();
            abrir.ShowDialog();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes abrir = new Clientes();
            abrir.ShowDialog();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_vista_cliente abrir = new Form_vista_cliente();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem54_Click(object sender, EventArgs e)
        {
            R_usuarios abrir = new R_usuarios();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem56_Click(object sender, EventArgs e)
        {
            Form_backup abrir = new Form_backup();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {
            Form_inventario abrir = new Form_inventario();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {
            Form_Ventas abrir = new Form_Ventas();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem45_Click(object sender, EventArgs e)
        {
            Form_gastos_report abrir = new Form_gastos_report();
            abrir.ShowDialog();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            panelMensaje.Visible = false;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem51_Click(object sender, EventArgs e)
        {
          Facturar abrir = new Facturar();
            abrir.ShowDialog();
            this.Hide();
        }

        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cxc abrir = new Form_cxc();
            abrir.ShowDialog();
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cotizacion abrir = new Form_cotizacion();
            abrir.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_empleado abrir = new Form_empleado();
            abrir.ShowDialog();
        }

        private void comisionPorReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form_comision abrir = new Form_comision();
            abrir.ShowDialog();
        }

        private void datosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_config abrir = new Form_config();
            abrir.ShowDialog();
        }

        private void imprimirCodigoDeBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_codigoBarra abrir = new Form_codigoBarra();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
           Facturar abrir = new Facturar();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem40_Click(object sender, EventArgs e)
        {

        }

        private void activarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_activacion abrir = new Form_activacion();
            abrir.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anularFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reimpresion abrir = new Reimpresion();
            abrir.ShowDialog();
        }

        private void abirCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_cajon = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            abrir_cajon.PrinterSettings = ps;
            abrir_cajon.PrintPage += abrir_cajon_PrintPage;
            abrir_cajon.Print();
        }

        private void abrir_cajon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font7 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);

            int y = 0;

            e.Graphics.DrawString("`", font7, Brushes.Black, new RectangleF(80, y, 250, 50));
        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem53_Click(object sender, EventArgs e)
        {

        }

        private void registroDeNCFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_lista_Comprobantes abrir = new Form_lista_Comprobantes();
            abrir.ShowDialog();
        }

        private void informe607ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form607 abrir = new Form607();
            abrir.Show();
        }
    }
}

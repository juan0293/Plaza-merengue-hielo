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
using System.IO.Ports;
using System.IO;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace RegistarVentas
{
    public partial class Facturar : Form

    {
        public int idmedico, idcomprobantes, numero_comprobantes, ncf_finalizar, ncf_inicio;
        public string tipocomprobantes,clientep, rncp;
        public DateTime fecha_comprobante;
        public string secuencia_comprobantes;
        public double monto, resultado, efectivo, tarjeta, credito, descuento, subtotal, itebis, Totalitbis;
        public int articulostotal,idventa;
        public int idcliente=2;
        public int empleadoid;
        public double devuelta = 0.00;
        public double entrada, salida =0.00;
        public string mensaje1;

        public void agregar_registro_comprobantes()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    registro_comprobantes oregistro = new registro_comprobantes();
                    oregistro.idcomp = idcomprobantes;
                    oregistro.secuencia = secuencia_comprobantes;
                    oregistro.fecha = DateTime.Now;
                    db.registro_comprobantes.Add(oregistro);
                    db.SaveChanges();



                }
                //MessageBox.Show("Datos Registrado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
        public void listarCreditoFiscal()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.comprobantes.ToList().Where(c => c.estado == true && c.Tipo == "B01");
                    foreach (var nfc in lst)
                    {
                        idcomprobantes = nfc.idomprobantes;
                        tipocomprobantes = nfc.Tipo;
                        fecha_comprobante = Convert.ToDateTime(nfc.fecha);
                        ncf_inicio = Convert.ToInt32(nfc.secuencia);
                        ncf_finalizar = Convert.ToInt32(nfc.secuencia_finalizar);

                    }

                }

            }

            catch { }
        }
        public void listarGubernamental()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.comprobantes.ToList().Where(c => c.estado == true && c.Tipo == "B15");
                    foreach (var nfc in lst)
                    {
                        idcomprobantes = nfc.idomprobantes;
                        tipocomprobantes = nfc.Tipo;
                        ncf_inicio = Convert.ToInt32(nfc.secuencia);
                        ncf_finalizar = Convert.ToInt32(nfc.secuencia_finalizar);
                        fecha_comprobante = Convert.ToDateTime(nfc.fecha);

                    }

                }

            }

            catch { }
        }
        public void listarConsumo()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.comprobantes.ToList().Where(c => c.estado == true && c.Tipo == "B02");
                    foreach (var nfc in lst)
                    {
                        idcomprobantes = nfc.idomprobantes;
                        tipocomprobantes = nfc.Tipo;
                        ncf_inicio = Convert.ToInt32(nfc.secuencia);
                        ncf_finalizar = Convert.ToInt32(nfc.secuencia_finalizar);
                        fecha_comprobante = Convert.ToDateTime(nfc.fecha);

                    }

                }

            }

            catch { }
        }
        public void ConsultarNcf()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    int lst = db.registro_comprobantes.Where(c => c.idcomp == idcomprobantes).Count();
                    numero_comprobantes = lst;

                    if (numero_comprobantes <= 0)
                    {
                        secuencia_comprobantes = ncf_inicio.ToString().PadLeft(8, '0');
                    }
                    else
                    {
                        int resultado = numero_comprobantes + ncf_inicio;

                        if (resultado <= ncf_finalizar)
                        {
                            secuencia_comprobantes = resultado.ToString().PadLeft(8, '0');
                        }

                        else
                        {

                            MessageBox.Show("No tiene comprobantes disponibles", "Alertas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }

            }

            catch { }
        }

        public Facturar()
        {
            InitializeComponent();
        }
        public void listarempleado()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.empleado;
                    foreach (var oempleado in lst)
                    {
                        cboempleado.Items.Add(oempleado.nombre);
                    }

                }

            }

            catch { }
        }  
        public void listarIDempleado()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.empleado.Where(c => c.nombre == cboempleado.Text);
                    foreach (var oempleado in lst)
                    {
                        empleadoid = oempleado.idempleado;
                    }

                }

            }

            catch { }
        }
        public void listarIDproducto()
        {
          
            try
            {
               
                using (beutyEntities db = new beutyEntities())

                {
                    string cod = Convert.ToString(txtcod.Text.Trim());
                    var lst = db.Producto.Where(i => i.codigo == cod && i.estatus ==true);
                  
                    foreach (var oproducto in lst)
                    {
                       
                        string codigo = oproducto.codigo;
                        mensaje1 = oproducto.codigo;
                        string nombre = oproducto.Nombre;
                        string detalle = oproducto.Descripcion_Producto;
                        double subtotal =Convert.ToDouble(oproducto.precio_salida);
                        int id = oproducto.Codigo_ID;
                        double porcentaje = Convert.ToDouble(Global.porcentaje);
                        double resultado = subtotal * porcentaje  / 100;
                        double resultado1 = resultado + subtotal;
                      
                        if(cbo_factura.Text == "Factura Crédito fiscal")
                        {
                        
                            if (oproducto.itbis == true)
                            {
                               
                                dgvDescripcion_Producto.Rows.Add(codigo, nombre, detalle, 1,subtotal, resultado1, id, resultado, oproducto.precio_salida);
                            }

                            else
                            {
                                dgvDescripcion_Producto.Rows.Add(codigo, nombre, detalle, 1, subtotal, subtotal, id, "0.00", "0.00");
                            }
                        }

                       else if (cbo_factura.Text == "Factura Gubernamental")
                        {
                          
                            if (oproducto.itbis == true)
                            {
                                dgvDescripcion_Producto.Rows.Add(codigo, nombre, detalle, 1, subtotal, resultado1, id, resultado, oproducto.precio_salida);
                            }

                            else
                            {
                                dgvDescripcion_Producto.Rows.Add(codigo, nombre, detalle, 1, subtotal, subtotal, id, "0.00", "0.00");
                            }
                        }

                        else if (cbo_factura.Text == "Factura de Consumo")
                        {

                            if (oproducto.itbis == true)
                            {
                                dgvDescripcion_Producto.Rows.Add(codigo, nombre, detalle, 1, subtotal, resultado1, id, resultado, oproducto.precio_salida);
                            }

                            else
                            {
                                dgvDescripcion_Producto.Rows.Add(codigo, nombre, detalle, 1, subtotal, subtotal, id, "0.00", "0.00");
                            }
                        }
                        else
                        {
                            dgvDescripcion_Producto.Rows.Add(codigo, nombre, detalle, 1, subtotal, subtotal, id, "0.00", "0.00");
                        }

                        //dgvDescripcion_Producto.Rows.Add(codigo, nombre, detalle, 1, subtotal,subtotal,id);               
                        txtcod.Clear();
                        txtcod.Focus();
                        

                    }
                  

                }

            }

            catch { }
        }
        public void operacion()
        {
            try
            {
                //Contar articulos
                articulostotal = dgvDescripcion_Producto.Rows.Count;

                //Suma de itbis
                double itbis = 0.00; itbis = dgvDescripcion_Producto.Rows.Cast<DataGridViewRow>()
                   .Sum(t => Convert.ToDouble(t.Cells[7].Value));
                   Totalitbis = itbis;

                double totalcliente = 0.00; totalcliente = dgvDescripcion_Producto.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[5].Value));
               txt_total.Text = totalcliente.ToString();
                
                Double Tpago2 = 0.00;
                if (Double.TryParse(txt_total.Text, out Tpago2))
                   txt_total.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

                //display();

               
              
            }
            catch { }

        }

        public void AplicarItebis()
        {
            try
            {
                double total = Convert.ToDouble(txt_total.Text);
                subtotal = total / 1.18;
                itebis = subtotal * 18 / 100;
            }
            catch 
            {
                MessageBox.Show("Agregue un producto a la factura");
            }
          
        }
        public void suma()
        {
            try
            {

                efectivo = Convert.ToDouble(txt_efectivo.Text);
                tarjeta = Convert.ToDouble(txt_tarjeta.Text);
                credito = Convert.ToDouble(txtcredito.Text);
                descuento = Convert.ToDouble(txt_descuento.Text);
                double total = Convert.ToDouble(txt_total.Text);
                resultado = efectivo + credito + tarjeta;
                 
                devuelta = total - resultado;

            }
            catch { }
        }
        public void operacion_descuento()
        {
            try
            {
                double descuento_aplicado = Convert.ToDouble(txt_descuento.Text);
                double total = Convert.ToDouble(txt_total.Text);
                double monto_aplicado = total - descuento_aplicado;
                txt_total.Text = monto_aplicado.ToString("#,##0.00");





            }
            catch { }

        }
        public void addventa()
        {
            try
            {
                string estado = "Normal";
           
                    using (beutyEntities db = new beutyEntities())
                    {
                    venta venta = new venta();
                    venta.idcliente = idcliente;
                    venta.fecha = DateTime.Now;
                    venta.usuario = Convert.ToInt32(Global.iduser);
                    venta.monto = Convert.ToDouble(txt_total.Text);
                    venta.metodo = 1;
                    venta.efectivo = efectivo;
                    venta.tarjeta = tarjeta;
                    venta.descuento = Convert.ToDouble(txt_descuento.Text);
                    venta.credito = credito;
                    venta.subtotal = subtotal;
                    venta.itebis = Totalitbis;
                    venta.devuelta = devuelta;
                    venta.estado = estado;
                    
                    
                    venta.tipodocumento = cbo_factura.Text;
                    if(cbo_factura.Text != "Factura Consumo")
                    {
                        venta.ncf = tipocomprobantes + secuencia_comprobantes;
                        venta.rnc = rncp;
                        venta.cliente = clientep;
                }
                 
                    venta.vendedor = Global.nombre;
                    db.venta.Add(venta);
                    db.SaveChanges();
                    idventa = venta.idventa;
                    lbOperacion.Text = idventa.ToString();
                    lbOperacion.Visible = true;
                }

            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }


        public void addtaller()
        {
            if (cboempleado.Text == "")
            {
                MessageBox.Show("Selecione el mecánico que esta solicitando las piezas para el taller.");
                cboempleado.Focus();
            }
            else
            {
                using (beutyEntities db = new beutyEntities())
                {
                    for (int i = 0; i < dgvDescripcion_Producto.Rows.Count - 0; i++)
                    {
                        taller otaller = new taller();
                        otaller.codigo = Convert.ToString(dgvDescripcion_Producto.Rows[i].Cells[0].Value.ToString());
                        otaller.nombre = Convert.ToString(dgvDescripcion_Producto.Rows[i].Cells[1].Value.ToString());
                        otaller.detalle = Convert.ToString(dgvDescripcion_Producto.Rows[i].Cells[2].Value.ToString());
                        otaller.cantidad = Convert.ToDouble(dgvDescripcion_Producto.Rows[i].Cells[3].Value.ToString());
                        otaller.subtotal = Convert.ToDouble(dgvDescripcion_Producto.Rows[i].Cells[4].Value.ToString());
                        otaller.total = Convert.ToDouble(dgvDescripcion_Producto.Rows[i].Cells[5].Value.ToString());
                        if (dgvDescripcion_Producto.Rows[i].Cells[8].Value == null)
                        {
                            otaller.referencia = "-";
                        }
                        else
                        {
                            otaller.referencia = Convert.ToString(dgvDescripcion_Producto.Rows[i].Cells[8].Value.ToString());
                        }
                        otaller.idmecanico = Convert.ToInt32(dgvDescripcion_Producto.Rows[i].Cells[6].Value.ToString());
                        otaller.mecanico = cboempleado.Text;
                        otaller.estado = true;
                        db.taller.Add(otaller);
                    }

                    db.SaveChanges();
                    MessageBox.Show("Piezas enviadas al taller", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listartaller();
                    dgvDescripcion_Producto.Rows.Clear();
                }
            }
        }

        public void listartaller()
        {
            dgvtaller.Rows.Clear();
            using (beutyEntities db = new beutyEntities())
            {
                var list = db.taller.ToList().OrderBy(f=>f.mecanico);

                foreach (var otaller in list)
                {
                    string codigo = otaller.codigo;
                    string nombre = otaller.nombre;
                    string detalle = otaller.detalle;
                    double cantidad = Convert.ToDouble(otaller.cantidad);
                    double subtotal = Convert.ToDouble(otaller.subtotal);
                    double total = Convert.ToDouble(otaller.total);
                    string referencia = otaller.referencia;
                    Boolean bol = false;
                    string mecanico = otaller.mecanico;
                    int id = Convert.ToInt32(otaller.idmecanico);
                    int idt = Convert.ToInt32(otaller.id);

                    dgvtaller.Rows.Add(codigo, nombre, detalle, cantidad, subtotal, total, "", referencia, mecanico,bol,id,idt);
                }
            }
        
        }

        public void addtrabajo()
        {
            try
            {
               using (beutyEntities db = new beutyEntities())

                {
                    reparacion oreparacion = new reparacion();
                    oreparacion.ventaid = idventa;
                    oreparacion.empledoid = empleadoid;
                    oreparacion.fecha = DateTime.Now;
                    oreparacion.monto = Convert.ToDouble(txt_total.Text);
                    db.reparacion.Add(oreparacion);
                    db.SaveChanges();
                    cboempleado.SelectedIndex = -1;
                }

            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void addetalle()
        {
           

                using (beutyEntities db = new beutyEntities())

                {

                    for (int i = 0; i < dgvDescripcion_Producto.Rows.Count - 0; i++)
                    {

                        detalleVenta oventa = new detalleVenta();
                        oventa.ventaid = idventa;
                        oventa.idproducto = Convert.ToInt32(dgvDescripcion_Producto.Rows[i].Cells[6].Value.ToString());
                        oventa.cantidad =Convert.ToDouble(dgvDescripcion_Producto.Rows[i].Cells[3].Value.ToString());
                        oventa.precio = Convert.ToDouble(dgvDescripcion_Producto.Rows[i].Cells[4].Value.ToString());
                        oventa.monto = Convert.ToDouble(dgvDescripcion_Producto.Rows[i].Cells[5].Value.ToString());
                        oventa.itbis = Convert.ToDouble(dgvDescripcion_Producto.Rows[i].Cells[7].Value.ToString());

                    db.detalleVenta.Add(oventa);
                     
                    }


                    db.SaveChanges();
                //MessageBox.Show("Venta registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lb_cliente.Text = "";
                eventodevuelta();
                }

          


        }
        public void addinventario()
        {


            using (beutyEntities db = new beutyEntities())

            {

                for (int i = 0; i < dgvDescripcion_Producto.Rows.Count - 0; i++)
                {

                    Inventario oinventario = new Inventario();
                
                    oinventario.Producto_Id = Convert.ToInt32(dgvDescripcion_Producto.Rows[i].Cells[6].Value.ToString());
                    oinventario.entrada = 0;
                    oinventario.Fecha_Ingreso = DateTime.Now;
                    oinventario.tipo_operacion= 2;
                    oinventario.salida = Convert.ToDouble(dgvDescripcion_Producto.Rows[i].Cells[3].Value.ToString());
                    db.Inventario.Add(oinventario);

                }


                db.SaveChanges();
             
            }




        }
        public void addcxc()
        {
            try {

                using (beutyEntities db = new beutyEntities())

                {
                    CXC ocxc= new CXC();
                    ocxc.Fecha = DateTime.Now;
                    ocxc.ID_Cliente = idcliente;
                    ocxc.Monto = credito;
                    ocxc.usuario = Convert.ToInt32(Global.iduser);
                    ocxc.venta = idventa;
                    db.CXC.Add(ocxc);
                    db.SaveChanges();
                   

                }   

            }
            catch { }
            



        }
        public void limpiar()
        {
            txt_total.Text = txt_efectivo.Text = txt_tarjeta.Text = txtcredito.Text = txt_descuento.Text = "0.00";
            dgvDescripcion_Producto.Rows.Clear();
            lb_cliente.Text = "";
            lb_rnc.Text = "";
            cbo_factura.Text = "Factura de Consumo";
            rncp = "";
            clientep = "";
        }
        public void eventodevuelta()
        {
            Txt_devueltaVf.Text = devuelta.ToString();
            Double Tpago2 = 0.00;
            if (Double.TryParse(Txt_devueltaVf.Text, out Tpago2))
                Txt_devueltaVf.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

        }
        //public void listarIdventa()
        //{
        //    try
        //    {
        //        int usuario = Convert.ToInt32(Global.iduser);
        //        var db = new beutyEntities4();

        //        var oventa = db.ventas.FirstOrDefault(v => v.monto == monto && v.idcliente == idcliente && v.usuario == usuario && v.efectivo ==efectivo && v.tarjeta == tarjeta && v.credito == credito);
        //        idventa = oventa.idventa;
        //        MessageBox.Show(idventa.ToString());
        //    }
        //    catch { }


        //}

        public void comprobante_fiscal()
        {
            ncf_inicio = 0;
            ncf_finalizar = 0;
            idcomprobantes = 0;
            listarCreditoFiscal();
            ConsultarNcf();
            //agregar_registro_comprobantes();
         
        }

        public void gubernamental()
        {
            ncf_inicio = 0;
            ncf_finalizar = 0;
            idcomprobantes = 0;
            listarGubernamental();
            ConsultarNcf(); 
            //agregar_registro_comprobantes();
           
        }

        public void consumo()
        {
            ncf_inicio = 0;
            ncf_finalizar = 0;
            idcomprobantes = 0;
            listarConsumo();
            ConsultarNcf();
            //agregar_registro_comprobantes();

        }
        public void cobrar()
        {
            try
            {
                AplicarItebis();
                double total = Convert.ToDouble(txt_total.Text);
                if (resultado >= total)
                {   
                       
                        addventa();
                        addetalle();
                        addinventario();
                        //if(cbo_factura.Text != "Factura de Consumo")
                        //{
                        agregar_registro_comprobantes();
                        //}
                        //if(cboempleado.Text !="")
                        //    {
                        //addtrabajo();
                        //    }
                        //if (MessageBox.Show("Desea Imprimir Factura", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        //{
                            caja();

                        if (idcliente != 2)
                        {
                            imprimirfactura2();
                            imprimirfactura2();
                        }
                     else  if (idcliente==2)
                        {
                            imprimirfactura();
                        }
                    txtcod.Focus();
                    limpiar();
                    //}



                    //    else
                    //    {
                    //        limpiar();
                    //        txtcod.Focus();
                    //}


                }
                else
                {
                    MessageBox.Show("El monto del pago debe ser mayor o igual Total", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    operacion();
                }

               
                txtcod.Focus();
            }
            catch { }
        }
        public void eventocantidad()
        {
            try {
                foreach (DataGridViewRow row in dgvDescripcion_Producto.SelectedRows)
                {
                    //Calcular Ibtbis

                    double porcentaje = Convert.ToDouble(Global.porcentaje);
                    double cantidad = Convert.ToDouble(row.Cells[3].Value);
                    double precio = Convert.ToDouble(row.Cells[4].Value);
                    double subtotal = precio * cantidad;
                    double  monto= subtotal * porcentaje / 100;
                    string celda = dgvDescripcion_Producto.CurrentCell.RowIndex.ToString();
                    int cantidades = int.Parse(celda);
                    double total = Convert.ToDouble(dgvDescripcion_Producto.Rows[cantidades].Cells[3].Value) * Convert.ToDouble(dgvDescripcion_Producto.Rows[cantidades].Cells[4].Value);
                    //double total1 = Convert.ToDouble(dgvDescripcion_Producto.Rows[cantidades].Cells[3].Value) * Convert.ToDouble(dgvDescripcion_Producto.Rows[cantidades].Cells[8].Value);
                  
                    if (cbo_factura.Text == "Factura de Consumo")
                    {

                        dgvDescripcion_Producto.Rows[cantidades].Cells[5].Value = total;
                        dgvDescripcion_Producto.Rows[cantidades].Cells[7].Value = "0.00";
                        operacion();
                    }
                    else
                    {
                        dgvDescripcion_Producto.Rows[cantidades].Cells[5].Value = total + monto;
                        dgvDescripcion_Producto.Rows[cantidades].Cells[7].Value = monto;
                        operacion();
                    }
                 
                }
            }
            catch { }
        }
        public void Formadd_pasado(string dato)
        {
           txtcod.Text = dato.ToString();
            listarIDproducto();
            operacion();
            txtcod.Clear();
            txtcod.Focus();
        }

        public void Formadd_pasado2(string dato)
        {
           
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                  
                    var lst = db.cotizacion.ToList().Where(c => c.idcotiza == Convert.ToInt32(dato));

                    foreach (var oproducto in lst)
                    {
                        double total = Convert.ToDouble(oproducto.totalCotizacion);
                        clientep= oproducto.cliente;
                        dgvDescripcion_Producto.Rows.Add(oproducto.codigo, oproducto.nombre, "1",oproducto.cantidad, oproducto.subtotal, oproducto.total, oproducto.idprd, oproducto.itbis);
                        operacion();

                        cbo_factura.Text = oproducto.tipodocumento;
                        lb_cliente.Text = oproducto.cliente;

                    }

                    var lst1 = db.dbCotizacion.ToList().Where(c => c.idcotiza == Convert.ToInt32(dato));

                    foreach (var oproducto in lst1)
                    {
                       
                        rncp = oproducto.rnc;
                        lb_rnc.Text = oproducto.rnc;
                    

                    }

                    metodoComprobante();
                }
              
            }

            catch { }
        

        }
        public void Formadd_pasado1(string id, string nombre)
        {
            idcliente =Convert.ToInt32(id);
            lbClient.Text = nombre.ToString();   
        }
        public void impfactura()
        {
            factura fat = new factura();
            for (int i = 0; i < dgvDescripcion_Producto.Rows.Count - 0; i++)
            {
                datos dat = new datos();
                dat.fecha = DateTime.Now.ToString(); ;
                dat.usuario = Global.nombre.ToString(); 
                dat.factura = idventa.ToString();
                dat.metodo = "Mixto";
                dat.cliente = lbClient.Text;

               
                dat.articulos = dgvDescripcion_Producto.Rows[i].Cells[2].Value.ToString();
                dat.codigo = dgvDescripcion_Producto.Rows[i].Cells[0].Value.ToString();
                dat.capital = dgvDescripcion_Producto.Rows[i].Cells[1].Value.ToString();
                dat.telefono = dgvDescripcion_Producto.Rows[i].Cells[3].Value.ToString();
                dat.total = dgvDescripcion_Producto.Rows[i].Cells[4].Value.ToString();
                dat.fecha_inicial = dgvDescripcion_Producto.Rows[i].Cells[5].Value.ToString();
                dat.subtotal = txt_total.Text;
                dat.efectivo = txt_efectivo.Text;
                dat.tarejeta = txt_tarjeta.Text;
                dat.credito = txtcredito.Text;
                dat.descuento = txt_descuento.Text;
                dat.devuelta = Txt_devueltaVf.Text;
                dat.monto_pago = resultado.ToString();
                dat.logo = Global.logo;
                dat.descripcion = Global.descripcion;
                dat.rnc = Global.rnc;
                dat.instegram = Global.instegram;
                dat.whatsaap = Global.telefono;
                fat.datos.Add(dat);

            }
            fat.Show();
        }

        private void Facturar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listarIDproducto();
                operacion();
                if (mensaje1 == null)
                {
                    txtcod.Focus();
                   // MessageBox.Show("Código no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtcod.Clear();
                txtcod.Focus();
                mensaje1 = null;
                //display();

            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta_Precio abrir = new Consulta_Precio();
            abrir.Show();
        }
        //public void display()
        //{
           

        //    SerialPort sp = new SerialPort();

        //    sp.PortName = "COM4";
        //    sp.BaudRate = 9600;
        //    sp.Parity = Parity.None;
        //    sp.DataBits = 8;
        //    sp.StopBits = StopBits.One;
        //    sp.Open();
        //    sp.Write(Convert.ToString((char)12));
        //    sp.WriteLine("Monto Total:");
        //    sp.WriteLine((char)13 + "RD$ "+Txt_total.Text);

        //    sp.Close();
        //    sp.Dispose();
        //    sp = null;
        //}


        //public void displayborrar()
        //{
        //    SerialPort sp = new SerialPort();

        //    sp.PortName = "COM4";
        //    sp.BaudRate = 9600;
        //    sp.Parity = Parity.None;
        //    sp.DataBits = 8;
        //    sp.StopBits = StopBits.One;
        //    sp.Open();
        //    sp.Write(new byte[] { 0x0C }, 0, 1);
        //    sp.Write(new byte[] { 0x0C }, 1, 1);
        //    sp.Write(new byte[] { 0x0C }, 2, 1);
        //    sp.Write(new byte[] { 0x0C }, 3, 1);



        //    sp.Write(new byte[] { 0x0C }, 0, 2);
        //    sp.Write(new byte[] { 0x0C }, 1, 2);
        //    sp.Write(new byte[] { 0x0C }, 2, 2);
        //    sp.Write(new byte[] { 0x0C }, 3, 2);


        //    sp.Close();
        //    sp.Dispose();
        //    sp = null;
        //}
        private void Facturar_Load(object sender, EventArgs e)
        {
            cbo_factura.Text = "Factura de Consumo";
            rncp = "";
            clientep = "";
            lb_usuario.Text = Global.nombre.ToString();
            listarempleado();
            lbfecha.Text = DateTime.Now.ToShortDateString();
            listarlogo();
            paneltaller.Visible = false;
        }
        public void imprimirfactura()
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }
        public void imprimirfactura2()
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir2;
            printDocument1.Print();
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {

            try
            {
                Font font_6 = new Font("Arial", 6, FontStyle.Regular, GraphicsUnit.Point);
                Font font_8 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                Font font_16 = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Point);
                Font font_10 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
                Font font_28 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point);

                int y = 20;

                double it = (Convert.ToDouble(txt_total.Text) / (1.18));
                decimal itbis = Convert.ToDecimal(it * 18 / 100);

                string itb = "ITBIS";
                string subtotal = "MONTO BRUTO";
                string total = "TOTAL A PAGAR RD$";
                string efectivo = "EFECTIVO";
                string tarjeta = "TARJETA";
                string cambio = "CAMBIO";
                string ley = "10% LEY";
                string descuento = "DESCUENTO";


                e.Graphics.DrawImage(piclogo.Image, new RectangleF(45, 0, 200, 110));
                e.Graphics.DrawString(Global.nombre_empresa.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 100, 300, 0));
                e.Graphics.DrawString(Global.descripcion.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("TELEFONO: " + Global.telefono + " / " + Global.instegram, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("RNC: " + Global.rnc.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString(DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("CAJERO:" + Global.nombre.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                // e.Graphics.DrawString("MESA: #" + global.numeromesag, font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));

                if (cbo_factura.Text == "Factura de Consumo")
                {
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("FACTURA PARA CONSUMIDOR FINAL", font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("NCF: " + tipocomprobantes + secuencia_comprobantes.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("VENCIMIENTO: " + fecha_comprobante.ToShortDateString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                }
                else
                {
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString(cbo_factura.Text.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("RNC: " + rncp.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("CLIENTE: " + clientep.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("NCF: " + tipocomprobantes + secuencia_comprobantes.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("VENCIMIENTO: " + fecha_comprobante.ToShortDateString().ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                }
                e.Graphics.DrawString("DESCRIPCION        ITBIS            VALOR  ", font_10, Brushes.Black, new RectangleF(2, y += 20, 300, 50));
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                for (int i = 0; i < dgvDescripcion_Producto.Rows.Count - 0; i++)
                {
                    e.Graphics.DrawString(dgvDescripcion_Producto.Rows[i].Cells[1].Value.ToString().ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString(dgvDescripcion_Producto.Rows[i].Cells[3].Value.ToString() + "   x   " + Convert.ToDecimal(dgvDescripcion_Producto.Rows[i].Cells[4].Value).ToString("#,##0.00").PadRight(15) + Convert.ToDecimal(dgvDescripcion_Producto.Rows[i].Cells[7].Value).ToString("#,##0.00").PadRight(15) + Convert.ToDecimal(dgvDescripcion_Producto.Rows[i].Cells[5].Value).ToString("#,##0.00").PadLeft(15), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                }
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                e.Graphics.DrawString(subtotal.PadRight(27)+(Convert.ToDouble(txt_total.Text) - Convert.ToDouble(Totalitbis)).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString(itb.PadRight(38) + Convert.ToDecimal(Totalitbis).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                if (Convert.ToDouble(txt_descuento.Text) > 0)
                {
                    e.Graphics.DrawString(descuento.PadRight(28) + Convert.ToDecimal(txt_descuento.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
                }
                e.Graphics.DrawString(total.PadRight(17) + Convert.ToDecimal(txt_total.Text).ToString("#,##0.00").PadLeft(20), font_28, Brushes.Black, new RectangleF(2, y += 15, 400, 50));
                //if (global.ley10 > 0)
                //{
                //    e.Graphics.DrawString(ley.PadRight(18) + Convert.ToDecimal((TOTAL) * (10) / (100)).ToString("#,##0.00").PadLeft(20), font_28, Brushes.Black, new RectangleF(10, y += 15, 400, 50));
                //}
                if (Convert.ToDouble(txt_efectivo.Text) > 0)
                {
                    e.Graphics.DrawString(efectivo.PadRight(34) + Convert.ToDecimal(txt_efectivo.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
                }
                else if (Convert.ToDouble(txt_tarjeta.Text) > 0)
                {
                    e.Graphics.DrawString(tarjeta.PadRight(32) + Convert.ToDecimal(txt_tarjeta.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(10, y += 18, 300, 50));
                }

                e.Graphics.DrawString(cambio.PadRight(33) + Convert.ToDecimal(Txt_devueltaVf.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("FACTURA: 000" + (idventa), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("GRACIAS POR SU VISITA", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                // e.Graphics.DrawString("FACTURADO EN PESOS DOMINICANOS", font_6, Brushes.Black, new RectangleF(80, y += 7, 300, 50));
                e.Graphics.DrawString("             WWW.ERMSOFTS.COM     ", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString(".", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));


            }
            catch
            {

            }
        }
        private void Imprimir2(object sender, PrintPageEventArgs e)
        {

            try
            {
                Font font_6 = new Font("Arial", 6, FontStyle.Regular, GraphicsUnit.Point);
                Font font_8 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                Font font_16 = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Point);
                Font font_10 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
                Font font_28 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point);

                int y = 20;

                double it = (Convert.ToDouble(txt_total.Text) / (1.18));
                decimal itbis = Convert.ToDecimal(it * 18 / 100);

                string itb = "ITBIS";
                string subtotal = "MONTO BRUTO";
                string total = "TOTAL A PAGAR RD$";
                string efectivo = "EFECTIVO";
                string tarjeta = "TARJETA";
                string CREDITO = "CREDITO";
                string cambio = "CAMBIO";
                string ley = "10% LEY";
                string descuento = "DESCUENTO";


                e.Graphics.DrawImage(piclogo.Image, new RectangleF(45, 0, 200, 110));
                e.Graphics.DrawString(Global.nombre_empresa.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 100, 300, 0));
                e.Graphics.DrawString(Global.descripcion.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("TELEFONO: " + Global.telefono + " / " + Global.instegram, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("RNC: " + Global.rnc.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString(DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("CAJERO:" + Global.nombre.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                // e.Graphics.DrawString("MESA: #" + global.numeromesag, font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("FACTURA PARA CONSUMIDOR FINAL", font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("NCF: " + tipocomprobantes + secuencia_comprobantes.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                   e.Graphics.DrawString("VENCIMIENTO: " + fecha_comprobante.ToShortDateString().ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("FACTURA A CREDITO", font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("CLIENTE: " + lbClient.Text.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
               
                e.Graphics.DrawString("DESCRIPCION        ITBIS            VALOR  ", font_10, Brushes.Black, new RectangleF(2, y += 20, 300, 50));
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                for (int i = 0; i < dgvDescripcion_Producto.Rows.Count - 0; i++)
                {
                    e.Graphics.DrawString(dgvDescripcion_Producto.Rows[i].Cells[1].Value.ToString().ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString(dgvDescripcion_Producto.Rows[i].Cells[3].Value.ToString() + "   x   " + Convert.ToDecimal(dgvDescripcion_Producto.Rows[i].Cells[4].Value).ToString("#,##0.00").PadRight(15) + Convert.ToDecimal(dgvDescripcion_Producto.Rows[i].Cells[7].Value).ToString("#,##0.00").PadRight(15) + Convert.ToDecimal(dgvDescripcion_Producto.Rows[i].Cells[5].Value).ToString("#,##0.00").PadLeft(15), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                }
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                e.Graphics.DrawString(subtotal.PadRight(27) + (Convert.ToDouble(txt_total.Text) - Convert.ToDouble(Totalitbis)).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString(itb.PadRight(38) + Convert.ToDecimal(Totalitbis).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                if (Convert.ToDouble(txt_descuento.Text) > 0)
                {
                    e.Graphics.DrawString(descuento.PadRight(28) + Convert.ToDecimal(txt_descuento.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
                }
                e.Graphics.DrawString(total.PadRight(17) + Convert.ToDecimal(txt_total.Text).ToString("#,##0.00").PadLeft(20), font_28, Brushes.Black, new RectangleF(2, y += 15, 400, 50));
                //if (global.ley10 > 0)
                //{
                //    e.Graphics.DrawString(ley.PadRight(18) + Convert.ToDecimal((TOTAL) * (10) / (100)).ToString("#,##0.00").PadLeft(20), font_28, Brushes.Black, new RectangleF(10, y += 15, 400, 50));
                //}
                if (Convert.ToDouble(txt_efectivo.Text) > 0)
                {
                    e.Graphics.DrawString(efectivo.PadRight(34) + Convert.ToDecimal(txt_efectivo.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
                }
                if (Convert.ToDouble(txt_tarjeta.Text) > 0)
                {
                    e.Graphics.DrawString(tarjeta.PadRight(32) + Convert.ToDecimal(txt_tarjeta.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
                }
                if (Convert.ToDouble(txtcredito.Text) > 0)
                {
                    e.Graphics.DrawString(CREDITO.PadRight(32) + Convert.ToDecimal(txtcredito.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
                }

                e.Graphics.DrawString(cambio.PadRight(33) + Convert.ToDecimal(Txt_devueltaVf.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("FACTURA: 000" + (idventa), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
               
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 50, 300, 50));
                e.Graphics.DrawString("FIRMA", font_10, Brushes.Black, new RectangleF(120, y += 15, 300, 50));
                //e.Graphics.DrawString("GRACIAS POR SU VISITA", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));

                // e.Graphics.DrawString("FACTURADO EN PESOS DOMINICANOS", font_6, Brushes.Black, new RectangleF(80, y += 7, 300, 50));
                e.Graphics.DrawString("             WWW.ERMSOFTS.COM     ", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString(".", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));


            }
            catch
            {

            }
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
        private void button2_Click(object sender, EventArgs e)
        {
            Reimpresion abrir = new Reimpresion();
            abrir.Show();
        }

        private void btnRecibo_Ingreso_Click(object sender, EventArgs e)
        {
            Ingresos abrir = new Ingresos();
            abrir.Show();
        }

        private void btnCuadre_Caja_Click(object sender, EventArgs e)
        {
            formCuadrecaja cuadre = new formCuadrecaja();
            cuadre.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login1 n = new Login1();
            n.Show();
        }

        private void txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_Cheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_Tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void Txt_cxc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void dgvDescripcion_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsNumber(e.KeyChar))  && (e.KeyChar != ','))
            //{
            //    e.Handled = true;
            //    return;
            //}
        }

        public void txtCedula_Click(object sender, EventArgs e)
        {
            
            Clientes cliente = new Clientes();
            cliente.Show();
        }
        private void button3_Click_2(object sender, EventArgs e)
        {
            Form_servicio lav = new Form_servicio();
            lav.Show();
        }


        private void toolStripMenuItem60_Click(object sender, EventArgs e)
        {
            Close();
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

        private void dgvDescripcion_Producto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          dgvDescripcion_Producto.Rows[e.RowIndex].Cells[9].Value = "Eliminar";
        }

        private void txt_efectivo_Enter(object sender, EventArgs e)
        {
            txt_efectivo.Clear();
        }

        private void txt_efectivo_Leave(object sender, EventArgs e)
        {
            if (txt_efectivo.Text == "")
            {
                txt_efectivo.Text = "0.00";
            }
            Double Tpago2 = 0.00;
            if (Double.TryParse(txt_efectivo.Text, out Tpago2))
                txt_efectivo.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);
        }

        private void texttarjeta_Enter(object sender, EventArgs e)
        {
            txt_tarjeta.Clear();
        }

        private void texttarjeta_Leave(object sender, EventArgs e)
        {
            if(txt_tarjeta.Text =="")
            {
                txt_tarjeta.Text = "0.00";
            }
            Double Tpago2 = 0.00;
            if (Double.TryParse(txt_tarjeta.Text, out Tpago2))
                txt_tarjeta.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);
        }

        private void txt_descuento_Enter(object sender, EventArgs e)
        {
            txt_descuento.Clear();
        }

        private void txt_descuento_Leave(object sender, EventArgs e)
        {
            operacion();
            if (txt_descuento.Text == "")
            {
                txt_descuento.Text = "0.00";
                operacion();
            }
            operacion_descuento();
            Double Tpago2 = 0.00;
            if (Double.TryParse(txt_descuento.Text, out Tpago2))
                txt_descuento.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);


        }

        private void txtcredito_Enter(object sender, EventArgs e)
        {

            txtcredito.Text = txt_total.Text;

        }

        private void txtcredito_Leave(object sender, EventArgs e)
        {
            if (txtcredito.Text == "")
            {
                txtcredito.Text = "0.00";
            }
            Double Tpago2 = 0.00;
            if (Double.TryParse(txtcredito.Text, out Tpago2))
                txtcredito.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);
        

    }
        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void dgvDescripcion_Producto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (dgvDescripcion_Producto.CurrentCell.ColumnIndex == 3)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void dgvDescripcion_Producto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            eventocantidad();
        }

        private void toolStripMenuItem40_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
          
        }

        private void cuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reimpresion abrir = new Reimpresion();
            abrir.ShowDialog();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            Form_Buscar formadd = new Form_Buscar();
            formadd.pasado += Formadd_pasado;
            formadd.ShowDialog();
        }

        private void cboempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarIDempleado();
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripMenuItem51_Click(object sender, EventArgs e)
        {

            formCuadrecaja abrir = new formCuadrecaja();
            abrir.ShowDialog();
        }

        private void lb_usuario_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addtaller();
        }

        private void dgvtaller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvtaller.Columns["eliminar"].Index && e.RowIndex >= 0)
                {

                    dgvtaller.Rows.Remove(dgvtaller.CurrentRow);
                  
                    operacion();
              

                }



            }
            catch
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            paneltaller.Visible = false;
            dgvtaller.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paneltaller.Visible = true;
            dgvtaller.Rows.Clear();
            listartaller();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
              
           

        }
        private void dgvtaller_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvtaller.Rows[e.RowIndex].Cells[6].Value = "Eliminar";
        }

        private void dgvtaller_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

                if (MessageBox.Show("Desea enviar piezas a caja?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                string codigo = dgvtaller.SelectedRows[0].Cells[0].Value.ToString();
                string nombre = dgvtaller.SelectedRows[0].Cells[1].Value.ToString();
                string detalle = dgvtaller.SelectedRows[0].Cells[2].Value.ToString();
                double cantidad = Convert.ToDouble(dgvtaller.SelectedRows[0].Cells[3].Value);
                double subtotal = Convert.ToDouble(dgvtaller.SelectedRows[0].Cells[4].Value);
                double total = Convert.ToDouble(dgvtaller.SelectedRows[0].Cells[5].Value);
                string referencia = dgvtaller.SelectedRows[0].Cells[7].Value.ToString();
                string mecanico = dgvtaller.SelectedRows[0].Cells[8].Value.ToString();
                int id = Convert.ToInt32(dgvtaller.SelectedRows[0].Cells[10].Value);
                int idt = Convert.ToInt32(dgvtaller.SelectedRows[0].Cells[11].Value);
                dgvDescripcion_Producto.Rows.Add(codigo, nombre, detalle, cantidad, subtotal, total, id, "", referencia, idt);
                operacion();

                using (beutyEntities db = new beutyEntities())
                {
                    taller otaller = db.taller.Find(idt);
                    otaller.idmecanico = id;
                    db.Entry(otaller).State = EntityState.Deleted;
                    db.SaveChanges();

                }
                listartaller();

                }
                else
                {

                }

            

           



        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form_codigoBarra n = new Form_codigoBarra();
            n.Show();
        }

        private void txt_descuento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_descuento_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                if (Global.tipo == "1")
                {

                }
                else
                {
                    double valor = 50;

                    if (Convert.ToDouble(txt_descuento.Text) > valor)
                    {
                        MessageBox.Show("El monto máximo para descuentos en caja es de 50 pesos");
                        txt_descuento.Text = "0.00";
                    }
                    else
                    {

                    }
                }
            }

            catch
            {


            }

        }
        public void metodoComprobante()
        {
            if (cbo_factura.Text == "Factura Crédito fiscal")
            {
                comprobante_fiscal();
            }

            if (cbo_factura.Text == "Factura Gubernamental")
            {
                gubernamental();
            }
        }
        private void cbo_factura_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
            Form_agregar_cliente formadd = new Form_agregar_cliente();
            formadd.pasado += Formadd_pasado3;



            if (cbo_factura.Text == "Factura Crédito fiscal")
            {
               
                comprobante_fiscal();

                if(lb_cliente.Text =="")
                {
                    formadd.ShowDialog();
                }
             

            }

           else  if (cbo_factura.Text == "Factura Gubernamental")
            {
                
                gubernamental();
                if (lb_cliente.Text == "")
                {
                    formadd.ShowDialog();
                }


            }

            else if (cbo_factura.Text == "Factura de Consumo")
            {

                consumo();
                //if (lb_cliente.Text == "")
                //{
                //    formadd.ShowDialog();
                //}


            }


        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void Formadd_pasado3(string cliente, string rnc, string documento)
        {
            // Estamos pasando el cliente y el RNC a el formulario agregar comprobantes a la factura.

            try
            {
                clientep = cliente;
                rncp = rnc;
                lb_rnc.Text = rnc;
                lb_cliente.Text = clientep;
                if (rnc == "")
                {
                    cbo_factura.Text = "Factura de Consumo";
                }
                else
                {

                }
                //  MessageBox.Show(clientep + "  " + rncp);

            }

            catch { }


        }
        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_cliente.Text = ".";
            Form_Lista_cotizaciones formadd = new Form_Lista_cotizaciones();
            formadd.pasado += Formadd_pasado2;
            formadd.ShowDialog();
        }

        private void cotizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cotizacion abrir = new Form_cotizacion();
            abrir.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_vista_cliente formadd = new Form_vista_cliente();
            formadd.pasado += Formadd_pasado1;
            formadd.ShowDialog();
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void cuadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCuadrecaja abrir = new formCuadrecaja();
            abrir.ShowDialog();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresos abrir = new Ingresos();
            abrir.ShowDialog();
        }

        private void dgvDescripcion_Producto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvDescripcion_Producto.Columns["quitar"].Index && e.RowIndex >= 0)
                {

                    dgvDescripcion_Producto.Rows.Remove(dgvDescripcion_Producto.CurrentRow);
                    //MessageBox.Show("Producto Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    operacion();
                    //display();

                }



            }


            catch { }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_efectivo_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void texttarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtcredito_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void picguardar_Click(object sender, EventArgs e)
        {
            suma();
            if (idcliente ==2 && credito >0)
            {
                MessageBox.Show("Por favor seleccionar cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                cobrar();
                if(idcliente !=2)
                {
                    addcxc();
                }
                idcliente = 2;
                lbClient.Text = "0001";
                cbo_factura.Text = "Factura de Consumo";
                secuencia_comprobantes = "";
                tipocomprobantes = "";
                consumo();
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

    }
 }





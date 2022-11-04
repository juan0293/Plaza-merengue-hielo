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
    public partial class Form_comprobantes : Form
    {
        public Form_comprobantes()
        {
            InitializeComponent();
        }
        public string idcomp;

        public void listarComprobantes()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.comprobantes.ToList().Where(b => b.idomprobantes == Convert.ToInt32(idcomp));
                    foreach (var ocomprobantes in lst)
                    {
                        cbo_tipo.Text = ocomprobantes.Tipo;
                        txt_secuencia.Text = ocomprobantes.secuencia;
                        txt_cantidad.Text = ocomprobantes.cantidad.ToString();
                        dtpvencimiento.Text = ocomprobantes.fecha.ToString();
                        idcomp = ocomprobantes.idomprobantes.ToString();

                        if (ocomprobantes.estado == true)
                        {
                            rdb_desactivar.Checked = false;
                            rdb_activar.Checked = true;
                        }
                        else
                        {
                            rdb_activar.Checked = false;
                            rdb_desactivar.Checked = true;
                        }


                    }

                }

            }

            catch { }
        }
        public void agregar()
        {
            try
            {


                using (beutyEntities db = new beutyEntities())

                {

                    comprobantes ocomprobates = new comprobantes();
                    ocomprobates.Tipo = cbo_tipo.Text;
                    ocomprobates.estado = true;
                    ocomprobates.cantidad = Convert.ToInt32(txt_cantidad.Text);
                    ocomprobates.fecha = DateTime.Now;
                    ocomprobates.secuencia = txt_secuencia.Text;
                    ocomprobates.secuencia_finalizar = txt_finalizar_secuencia.Text;
                    db.comprobantes.Add(ocomprobates);
                    db.SaveChanges();
                    MessageBox.Show("Comprobantes Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch { MessageBox.Show("Algo salio Mal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void modificar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {

                    int id = Convert.ToInt32(idcomp);

                    comprobantes ocomprobates = db.comprobantes.Find(id);

                    ocomprobates.Tipo = cbo_tipo.Text;
                    //ocomprobates.estado = true;
                    ocomprobates.cantidad = Convert.ToInt32(txt_cantidad.Text);
                    ocomprobates.fecha = DateTime.Now;
                    ocomprobates.secuencia = txt_secuencia.Text;
                    ocomprobates.secuencia_finalizar = txt_finalizar_secuencia.Text;
                    db.Entry(ocomprobates).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Comprobante eliminado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            catch { }
        }
        public void Activar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {

                    int id = Convert.ToInt32(idcomp);

                    comprobantes ocomprobates = db.comprobantes.Find(id);


                    ocomprobates.estado = true;

                    db.Entry(ocomprobates).State = EntityState.Modified;
                    db.SaveChanges();
                    //MessageBox.Show("Comprobante Activado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarComprobantes();
                }

            }

            catch { }
        }
        public void desactivar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {

                    int id = Convert.ToInt32(idcomp);

                    comprobantes ocomprobates = db.comprobantes.Find(id);


                    ocomprobates.estado = false;

                    db.Entry(ocomprobates).State = EntityState.Modified;
                    db.SaveChanges();
                    //MessageBox.Show("Comprobante desativado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarComprobantes();
                }

            }

            catch { }
        }
        //public void listarBuscarnombre()
        //{
        //    try
        //    {
        //        using (HospitalEntities db = new HospitalEntities())

        //        {
        //            var lst = from m in db.comprobantes
        //                      where m.numero.Contains(txt_buscar.Text)
        //                      select m;
        //            comprobanteBindingSource.Clear();
        //            comprobanteBindingSource.DataSource = lst.ToList();

        //        }
        //    }
        //    catch { }
        //}

        //public void ConsultarNcf()
        //{
        //    try
        //    {

        //        using (beutyEntities db = new beutyEntities())

        //        {
        //            int id = Convert.ToInt32(idcomp);
        //            int lst = db.registro_comprobantes.Where(c => c.idcomp == id).Count();
        //            int numero_comprobantes = lst;
        //            int ncf_inicio = Convert.ToInt32(txt_secuencia.Text);
        //            if (numero_comprobantes <= 0)
        //            {
        //                txt_proximo.Text = txt_secuencia.Text;
        //            }
        //            else
        //            {
        //                int resultado = numero_comprobantes + ncf_inicio;

        //                if (resultado <= Convert.ToInt32(txt_finalizar_secuencia.Text))
        //                {
        //                    txt_proximo.Text = resultado.ToString().PadLeft(8, '0');
        //                }

        //                else
        //                {

        //                    MessageBox.Show("No tiene comprobantes disponibles", "Alertas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //                }

        //            }

        //        }
        //    }
        //    catch { }

        //}
        public void ConsultarNcf()
        {
            try
            {

                using (beutyEntities db = new beutyEntities())

                {
                    int id = Convert.ToInt32(idcomp);
                    int lst = db.registro_comprobantes.Where(c => c.idcomp == id).Count();
                    int numero_comprobantes = lst;
                    int ncf_inicio = Convert.ToInt32(txt_secuencia.Text);
                    if (numero_comprobantes <= 0)
                    {
                        txt_proximo.Text = txt_secuencia.Text;
                    }
                    else
                    {
                        int resultado = numero_comprobantes + ncf_inicio;

                        if (resultado <= Convert.ToInt32(txt_finalizar_secuencia.Text))
                        {
                            txt_proximo.Text = resultado.ToString().PadLeft(8, '0');
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
        public void generar_secuencia()
        {
            try
            {
                int inicio = Convert.ToInt32(txt_secuencia.Text);
                int cantidad = Convert.ToInt32(txt_cantidad.Text);
                int resultado = inicio + cantidad;

                txt_finalizar_secuencia.Text = resultado.ToString().PadLeft(8, '0');
            }
            catch { }
        }
        private string GenerateId()
        {
            int lastAddedId = 8; // get this value from database
            string demo = Convert.ToString(lastAddedId + 1).PadLeft(4, '0');
            return demo;
            // it will return 0009
        }
        private void Auto()
        {
            txt_proximo.Text = "A-" + GenerateId();
            // here it will set the text as "A-0009"
        }
        private void Form_comprobantes_Load(object sender, EventArgs e)
        {
            listarComprobantes();
            generar_secuencia();
            ConsultarNcf();
        }

        private void txt_secuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_proximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_finalizar_secuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            generar_secuencia();
        }

        private void rdb_activar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_activar.Checked == true && rdb_desactivar.Checked == false)
            {
                Activar();
            }
        }

        private void rdb_desactivar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_activar.Checked == false && rdb_desactivar.Checked == true)
            {
                desactivar();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (idcomp == null)
            {
                if (txt_secuencia.Text == "")
                {
                    MessageBox.Show("Por favor completar el campo inicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txt_cantidad.Text == "")
                {
                    MessageBox.Show("Por favor completar el campo inicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (cbo_tipo.Text == "")
                {
                    MessageBox.Show("Por favor completar el campo inicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    agregar();
                    Close();
                }
            }
            else
            {
                modificar();
                Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class Form_compra : Form
    {
        public int idproducto, idcategoria, idimpuesto, idformapago, idnumeroprovedor;
        public string idproveedor, idbusquedad;
        public DateTime fechapago;
        public double numerofactura;
        public Form_compra()
        {
            InitializeComponent();
        }
        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void dgvdetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvdetalle.CurrentCell.ColumnIndex == 2)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
            if (dgvdetalle.CurrentCell.ColumnIndex == 3)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
            if (dgvdetalle.CurrentCell.ColumnIndex == 4)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }

            if (dgvdetalle.CurrentCell.ColumnIndex == 5)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
        }
        public void eventobuscar()
        {
            try
            {
                foreach (DataGridViewRow row in dgvdetalle.SelectedRows)

                {
                    string idprd = Convert.ToString(row.Cells[6].Value);
                    string codigo = Convert.ToString(row.Cells[0].Value);

                    if (idprd == "")
                    {

                      
                        Form_Buscar formadd = new Form_Buscar();
                        formadd.pasado += Formadd_pasado;
                        formadd.txtBuscar.Text = codigo.ToString();
                        formadd.ShowDialog();
                    }
                    else
                    {
                        dgvdetalle.AllowUserToAddRows = true;
                    }

                }
            }
            catch { }
        }
        public void eventolistar()
        {
            try
            {
                foreach (DataGridViewRow row in dgvdetalle.SelectedRows)

                {
                    string codigo = Convert.ToString(row.Cells[6].Value);

                    if (codigo == "")
                    {
                        listarproducto();
                        sumar();
                    }
                }
            }
            catch { }
        }
        public void listarproducto()
        {
            try
            {
                foreach (DataGridViewRow row in dgvdetalle.SelectedRows)
                {
                    idbusquedad = row.Cells[1].Value.ToString();

                }

                using (beutyEntities db = new beutyEntities())

                {

                    var lst = db.Producto.Where(p => p.codigo == idbusquedad);
                    foreach (var oproducto in lst)
                    {

                        string celda = dgvdetalle.CurrentCell.RowIndex.ToString();

                        int cantidades = int.Parse(celda);
                        dgvdetalle.Rows[cantidades].Cells[1].Value = oproducto.Nombre;
                        //dgvdetalle.Rows[cantidades].Cells[3].Value = oproducto.detalle;
                        dgvdetalle.Rows[cantidades].Cells[2].Value = oproducto.precio_neto;
                        dgvdetalle.Rows[cantidades].Cells[3].Value = oproducto.itbis;
                        dgvdetalle.Rows[cantidades].Cells[4].Value = oproducto.precio_salida;
                        dgvdetalle.Rows[cantidades].Cells[5].Value = 0;
                        dgvdetalle.Rows[cantidades].Cells[6].Value = oproducto.Codigo_ID;


                    }

                }
            }

            catch { }
        }
  
   
        public void sumar()
        {
            try
            {
                //Sumar factura
                int totalfilas = dgvdetalle.Rows.Count;

                lb_cantidad.Text = totalfilas.ToString();

                double totalcliente = 0.00; totalcliente = dgvdetalle.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[2].Value));
                lb_total.Text = totalcliente.ToString();
                Double Tpago2 = 0.00;
                if (Double.TryParse(lb_total.Text, out Tpago2))
                    lb_total.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

                ///
                double totalitbis = 0.00; totalitbis = dgvdetalle.Rows.Cast<DataGridViewRow>()
                   .Sum(t => Convert.ToDouble(t.Cells[3].Value));
                lb_itebis.Text = totalitbis.ToString();
                Double Tpago3 = 0.00;
                if (Double.TryParse(lb_itebis.Text, out Tpago3))
                    lb_itebis.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago3);

            }
            catch { }

        }
        private void Formadd_pasado(string dato)
        {

            listarproducto();
            sumar();
            dgvdetalle.AllowUserToAddRows = true;
        }
        private void dgvdetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            eventolistar();
            eventobuscar();
        }
    }
}

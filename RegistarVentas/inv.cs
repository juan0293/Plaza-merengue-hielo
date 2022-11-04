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
    public partial class inv : Form
    {
        public double entrada, salida = 0.00;
        public string id_s;
        public int idcategoria;
      
        public inv()
        {
            InitializeComponent();
        }
        public void resfrescar()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    viewinventarioBindingSource.DataSource = db.View_inventario.ToList().Where(c=> c.estatus == true);

                }
            }
            catch { }
        }
        public void listarcategoria()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.categoria;
                    foreach (var ocategoria in lst)
                    {
                        cboCategoria.Items.Add(ocategoria.nombre);
                    }

                }

            }

            catch { }
        }
        public void listarIDcategoria()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    var lst = db.categoria.Where(c => c.nombre == cboCategoria.Text); ;
                    foreach (var ocategoria in lst)
                    {
                        idcategoria = ocategoria.idcategoria;
                    }

                }

            }

            catch { }
        }
        public void listarBuscarCategoria()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                    viewinventarioBindingSource.Clear();
                    viewinventarioBindingSource.DataSource = db.View_inventario.ToList().Where(c => c.Categoria == idcategoria && c.estatus == true);

                }
            }
            catch { }
        }
        public void listarBuscarnombre()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {
                              var lst = from m in db.View_inventario
                              where m.Nombre.Contains(txtBuscar.Text) 
                              select m;
                              viewinventarioBindingSource.Clear();
                              viewinventarioBindingSource.DataSource = lst.ToList().Where(m=> m.estatus == true);
                }
            }
            catch { }
        }
        public void listarBuscarcodigo()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                   
                {
                    viewinventarioBindingSource.Clear();
                   
                    string cod = Convert.ToString(txtBuscar.Text.Trim());
                    viewinventarioBindingSource.DataSource = db.View_inventario.ToList().Where(c => c.codigo == cod && c.estatus == true);

                }
            }
            catch { }
        }
        public void metodo()
        {
            if (rdb_nombre.Checked == true && rdbCodigo.Checked == false)
            {
                listarBuscarnombre();
            }
            else if (rdb_nombre.Checked == false && rdbCodigo.Checked == true)
            {
                listarBuscarcodigo();
            }
            else
            {
                MessageBox.Show("Por favor selecionar la opcion de busquedad","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void Activarestado()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idproducto = Convert.ToInt32(row.Cells[5].Value);

                        Producto oproducto = db.Producto.Find(idproducto);
                        oproducto.estatus = true;
                        db.Entry(oproducto).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Producto Activo");
                    }

                }
            }
            catch { }
        }
        public void desactivarestao()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {

                        int idproducto = Convert.ToInt32(row.Cells[5].Value);

                        Producto oproducto = db.Producto.Find(idproducto);
                        oproducto.estatus = false;
                        db.Entry(oproducto).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Producto Inactivo");
                    }

                }
            }
            catch { }
        }
        //public void editarinventario()
        //{
        //    try
        //    {
        //        using (beutyEntities3 db = new beutyEntities3())
        //        {
        //            foreach (DataGridViewRow row in dgvproducto.SelectedRows)
        //            {

        //                int idproducto = Convert.ToInt32(row.Cells[4].Value);

        //                foreach (var oproducto in db.Inventarios.Where(c => c.Producto_Id == idproducto))
        //                {
        //                    oproducto.cantidad = 0;
                                       
        //                    db.Inventarios.Add(oproducto);

        //                    db.Entry(oproducto).State = EntityState.Modified;

        //                }
        //                db.SaveChanges();
        //                MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }

        //        }
        //    }
        //    catch { }
        //}

        private void inv_Load(object sender, EventArgs e)
        {
            rdb_nombre.Checked = true;
            listarcategoria();
            resfrescar();

        }


        private void Formadd_pasado(string dato)
        {
            resfrescar();

        }

        private void Txt_Buscar_p_Leave(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //foreach (DataGridViewRow row in Dgv_inv.SelectedRows)
                //{
                //    Global.Codigo = row.Cells[0].Value.ToString();

                //}

                //Registro_Producto registro = new Registro_Producto();
                //registro.MdiParent = this.ParentForm;
                //registro.Show();
            }
            catch { }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            metodo();
        }

        private void rdbcategoria_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbcategoria.Checked == true)
            {
                cboCategoria.Enabled = true;
                txtBuscar.Clear();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            resfrescar();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarIDcategoria();
            listarBuscarCategoria();
        }

        private void dgvproducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvproducto.Rows)
            {

                string estado = Convert.ToString(row.Cells[4].Value);


                if (estado == "True")
                {
                    row.Cells[4].Value = "Activo";



                }
                if (estado == "False")
                {


                    row.Cells[4].Value = "Inactivo";



                }
              

            }
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvproducto.Columns["cambiarestado"].Index && e.RowIndex >= 0)
                {

                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)

                    {
                            string estado = Convert.ToString(row.Cells[4].Value);


                        if (estado == "True")
                        {  
                            desactivarestao();
                        }
                       if (estado == "False")
                        {
                            Activarestado();
                        }
                    }
                    resfrescar();
                    }
                    if (e.ColumnIndex == dgvproducto.Columns["ajustar"].Index && e.RowIndex >= 0)
                     {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {


                        Form_Ajustar ajustar = new Form_Ajustar();
                        ajustar.pasado1 += Formadd_pasado;
                        //ajustar.txt_existencia.Text = row.Cells[11].Value.ToString();
                        ajustar.lbdetalle.Text = row.Cells[8].Value.ToString();
                        ajustar.lbNombre.Text = row.Cells[7].Value.ToString();
                        ajustar.txtprecioventa.Text = row.Cells[11].Value.ToString();
                        ajustar.txtcompra.Text = row.Cells[13].Value.ToString();
                        ajustar.id_producto = Convert.ToInt32(row.Cells[5].Value.ToString());
                        ajustar.ShowDialog();


                    }

                }
                if (e.ColumnIndex == dgvproducto.Columns["seleccionar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {


                        Registro_Producto ajustar = new Registro_Producto();
                        ajustar.pasado += Formadd_pasado;
                        ajustar.idproduct = row.Cells[5].Value.ToString();
                        ajustar.txt_codigo.Text = row.Cells[6].Value.ToString();
                        ajustar.txtnombre.Text = row.Cells[7].Value.ToString();
                        ajustar.txtDetalle.Text = row.Cells[8].Value.ToString();
                        ajustar.txt_precioentrada.Text = row.Cells[9].Value.ToString();
                        ajustar.txt_preciosalida.Text = row.Cells[10].Value.ToString();

                        if(Convert.ToBoolean(row.Cells[14].Value) ==true)
                        {
                            ajustar.chItbis.Checked = true;
                        }
                        else
                        {
                            ajustar.chItbis.Checked = false;
                        }
                        //ajustar.cboProveedor.Text = row.Cells[11].Value.ToString();
                        //ajustar.cboCategoria.Text = row.Cells[12].Value.ToString();
                        ajustar.ShowDialog();


                    }

                }
                if (e.ColumnIndex == dgvproducto.Columns["Ajuste"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {


                        Form_actualizar ajustar = new Form_actualizar();
                       
                        //ajustar.txt_existencia.Text = row.Cells[11].Value.ToString();
                        ajustar.idproducto = row.Cells[5].Value.ToString();                      
                        ajustar.ShowDialog();


                    }

                }



            }
            catch { }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            try
            {



                if (MessageBox.Show("El Producto será eliminado definitivamente", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                 
                    using (beutyEntities db = new beutyEntities())
                    {
                        foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                        {

                            int idproducto = Convert.ToInt32(row.Cells[5].Value);

                            Producto oproducto = db.Producto.Find(idproducto);
                            oproducto.estatus = false;
                            db.Entry(oproducto).State = EntityState.Modified;
                            db.SaveChanges();
                            MessageBox.Show("Producto Eliminado");
                        }

                    }

                    resfrescar();

                }
                else
                {

                }
            }
            catch { }

        }

        private void Dgv_inv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        } 
    }
}

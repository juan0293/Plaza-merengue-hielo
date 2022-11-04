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
    public partial class Form_lista_Comprobantes : Form
    {
      

      
        public Form_lista_Comprobantes()
        {
            InitializeComponent();
        }
        public void listarCreditoFiscal()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    comprobantesBindingSource.DataSource = db.comprobantes.ToList().Where(b => b.Tipo == "B01" && b.estado == true);
                    int lst = db.comprobantes.Where(c => c.Tipo == "B01" && c.estado == true).Count();
                    if (lst <= 0)
                    {
                        comprobantesBindingSource.Clear();
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

                    comprobantesBindingSource1.DataSource = db.comprobantes.ToList().Where(b => b.Tipo == "B15" && b.estado == true);
                    int lst = db.comprobantes.Where(c => c.Tipo == "B15" && c.estado == true).Count();
                    if (lst <= 0)
                    {
                        comprobantesBindingSource1.Clear();
                    }
                }

            }

            catch { }
        }
        public void listarconsumo()
        {
            try
            {
                using (beutyEntities db = new beutyEntities())

                {

                    comprobantesBindingSource2.DataSource = db.comprobantes.ToList().Where(b => b.Tipo == "B02" && b.estado == true);
                    int lst = db.comprobantes.Where(c => c.Tipo == "B02" && c.estado == true).Count();
                    if (lst <= 0)
                    {
                        comprobantesBindingSource2.Clear();
                    }
                }

            }

            catch { }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (dgv_comprobantes.RowCount > 0)
            {
                MessageBox.Show("Ya existe una secuencia agregada, por favor eliminar para poder agregar una nueva", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form_comprobantes abrir = new Form_comprobantes();
                abrir.Show();
            }
        }

        private void Form_lista_Comprobantes_Load(object sender, EventArgs e)
        {
            listarCreditoFiscal();
            listarGubernamental();
            listarconsumo();
        }

        private void btn_modificar1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGubernamental.SelectedRows)
            {
                Form_comprobantes abrir = new Form_comprobantes();

                abrir.idcomp = row.Cells[0].Value.ToString();
                abrir.Show();

            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dgii.gov.do/Paginas/default.aspx");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dgii.gov.do/Paginas/default.aspx");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dgii.gov.do/Paginas/default.aspx");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            //if (tabControl1.SelectedTab == tabPage2)
            //{

            //    comprobantesBindingSource.Clear();
            //    listarCreditoFiscal();
            //}

            //if (tabControl1.SelectedTab == tabPage2)
            //{
            //    comprobantesBindingSource1.Clear();
            //    listarGubernamental();
            //}
            //if (tabControl1.SelectedTab == tabPage3)
            //{
            //    comprobantesBindingSource1.Clear();
            //    listarconsumo();
            //}
        }

        private void dgvGubernamental_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvGubernamental.Rows)
                {

                    bool estado = Convert.ToBoolean(row.Cells[6].Value);


                    if (estado == true)
                    {
                        row.Cells[7].Value = "Activo";

                    }
                    else
                    {
                        row.Cells[7].Value = "Desativada";


                    }

                    row.Cells[3].Value = row.Cells[1].Value.ToString() + row.Cells[2].Value.ToString();

                }
            }
            catch { }
        }

        private void dgv_comprobantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgv_comprobantes.Rows)
                {

                    bool estado = Convert.ToBoolean(row.Cells[6].Value);


                    if (estado == true)
                    {
                        row.Cells[7].Value = "Activo";

                    }
                    else
                    {
                        row.Cells[7].Value = "Desativada";


                    }

                    row.Cells[3].Value = row.Cells[1].Value.ToString() + row.Cells[2].Value.ToString();

                }
            }
            catch { }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_comprobantes.SelectedRows)
            {
                Form_comprobantes abrir = new Form_comprobantes();

                abrir.idcomp = row.Cells[0].Value.ToString();
                abrir.Show();

            }
        }

        private void btn_agregar1_Click(object sender, EventArgs e)
        {

            if (dgvGubernamental.RowCount > 0)
            {
                MessageBox.Show("Ya existe una secuencia agregada, por favor eliminar para poder agregar una nueva", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form_comprobantes abrir = new Form_comprobantes();
                abrir.Show();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_consumo.RowCount > 0)
            {
                MessageBox.Show("Ya existe una secuencia agregada, por favor eliminar para poder agregar una nueva", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form_comprobantes abrir = new Form_comprobantes();
                abrir.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_consumo.SelectedRows)
            {
                Form_comprobantes abrir = new Form_comprobantes();

                abrir.idcomp = row.Cells[0].Value.ToString();
                abrir.Show();

            }
        }

        private void dgv_consumo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgv_consumo.Rows)
                {

                    bool estado = Convert.ToBoolean(row.Cells[6].Value);


                    if (estado == true)
                    {
                        row.Cells[7].Value = "Activo";

                    }
                    else
                    {
                        row.Cells[7].Value = "Desativada";


                    }

                    row.Cells[3].Value = row.Cells[1].Value.ToString() + row.Cells[2].Value.ToString();

                }
            }
            catch { }
        }
    }
}

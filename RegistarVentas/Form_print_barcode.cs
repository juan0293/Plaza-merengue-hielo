using Microsoft.Reporting.WinForms;
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
    public partial class Form_print_barcode : Form
    {
        public List<datos> datos = new List<datos>();
        public int cantidad;
        public Form_print_barcode()
        {
            InitializeComponent();
        }
        private void AutoPrint()
        {
            AutoPrintCls autoprintme = new AutoPrintCls(reportViewer1.LocalReport);
            autoprintme.Print();
        }
        private void Form_print_barcode_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", datos));
            this.reportViewer1.RefreshReport();
            //for (int i = 0; i < cantidad; i++)
            //{
            //    AutoPrint();
            //}     
            //Close();
        }
    }
}

using BL.Pizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Pizzeria
{
    public partial class FormReporteNuestrasPizzas : Form
    {
        public FormReporteNuestrasPizzas()
        {
            InitializeComponent();

            var _nuestraspizzasBL = new NuestrasPizzasBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _nuestraspizzasBL.Pedido();

            var reporte = new ReporteNuestrasPizzas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        } 
    }
}

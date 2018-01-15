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

namespace Escritorio.Reportes
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void ClientesTests_Load(object sender, EventArgs e)
        {

            comboBox1Reporte.Items.Add("Total de Ventas por día");
            comboBox1Reporte.Items.Add("Clientes por Volumen de Compra");
            comboBox1Reporte.Items.Add("Clientes por Última Compra");
            comboBox1Reporte.Items.Add("Productos por Volumen de Venta");
            comboBox1Reporte.Items.Add("Ventas por Productos por horario");
            comboBox1Reporte.Items.Add("Envios por horario");
        }

        private void comboBoxReporte_SelectedIndexChanged(object sender, EventArgs e)
        {

            DateTime from = DateTime.Parse(dateTimePickerFrom.Value.Date.ToShortDateString());
            DateTime toParam = DateTime.Parse(dateTimePickerTo.Value.Date.ToShortDateString());
            DateTime to = toParam.AddDays(1);
            DateTime GeneratedDateTime = DateTime.Now;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("from", from.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("to", toParam.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("generatedDate", GeneratedDateTime.ToString()));

            switch (comboBox1Reporte.SelectedItem.ToString().Trim())
            {
    

                case "Total de Ventas por día":
            
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Escritorio.Reportes.Reports.MontoVentaXDia.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    this.montoVentaXDiaTableAdapter.Fill(this.dataSetReportes.MontoVentaXDia, from, to);
                    reportDataSource.Name = "MontoVentaXDiaDataSet";
                    reportDataSource.Value = this.montoVentaXDiaBindingSource;

                    break;

                case "Clientes por Volumen de Compra":
                    
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Escritorio.Reportes.Reports.ClientesQueMasCompraron.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    this.clientesQueMasCompraronTableAdapter.Fill(this.dataSetReportes.ClientesQueMasCompraron, from, to);
                    reportDataSource.Name = "ClientesQueMasCompraronDataSet";
                    reportDataSource.Value = this.ClientesQueMasCompraronBindingSource;

                    break;

                case "Clientes por Última Compra":
                    
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Escritorio.Reportes.Reports.ClientesXUltimaCompra.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    this.clientesXUltimaCompraTableAdapter.Fill(this.dataSetReportes.ClientesXUltimaCompra,from,to);
                    reportDataSource.Name = "ClientesXUltimaCompraDataSet";
                    reportDataSource.Value = this.ClientesXUltimaCompraBindingSource;

                    break;
                case "Productos por Volumen de Venta":

                    reportViewer1.LocalReport.ReportEmbeddedResource = "Escritorio.Reportes.Reports.ProductosXVenta.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    this.productosXVentaTableAdapter.Fill(this.dataSetReportes.ProductosXVenta, from, to);
                    reportDataSource.Name = "ProductosXVentaDataSet";
                    reportDataSource.Value = this.ProductosXVentaBindingSource;
                    
                    break;

                case "Ventas por Productos por horario":

                    reportViewer1.LocalReport.ReportEmbeddedResource = "Escritorio.Reportes.Reports.VentaXProductoXHora.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    this.ventaXProductoXHoraTableAdapter.Fill(this.dataSetReportes.VentaXProductoXHora,from,to);
                    reportDataSource.Name = "VentaXProductoXHoraDataSet";
                    reportDataSource.Value = this.VentaXProductoXHoraBindingSource;

                    break;

                case "Envios por horario":

                    reportViewer1.LocalReport.ReportEmbeddedResource = "Escritorio.Reportes.Reports.DeliveryXHora.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    this.deliveryXHoraTableAdapter.Fill(this.dataSetReportes.DeliveryXHora,from,to);
                    reportDataSource.Name = "DeliveryXHoraDataSet";
                    reportDataSource.Value = this.DeliveryXHoraBindingSource;

                    break;
                    
                default:
                    break;
            }
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

    }
}

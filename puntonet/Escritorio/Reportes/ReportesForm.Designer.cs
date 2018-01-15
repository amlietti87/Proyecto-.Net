namespace Escritorio.Reportes
{
    partial class ReportesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VentaXProductoXHoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportes = new Escritorio.Reportes.DataSets.DataSetReportes();
            this.ProductosXVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientesXUltimaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientesQueMasCompraronBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.montoVentaXDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.montoVentaXDiaTableAdapter = new Escritorio.Reportes.DataSets.DataSetReportesTableAdapters.MontoVentaXDiaTableAdapter();
            this.clientesQueMasCompraronTableAdapter = new Escritorio.Reportes.DataSets.DataSetReportesTableAdapters.ClientesQueMasCompraronTableAdapter();
            this.dataSetReportes1 = new Escritorio.Reportes.DataSets.DataSetReportes();
            this.clientesXUltimaCompraTableAdapter = new Escritorio.Reportes.DataSets.DataSetReportesTableAdapters.ClientesXUltimaCompraTableAdapter();
            this.ProductosPorVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosPorVenta1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosPorVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosPorVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosXVentaTableAdapter = new Escritorio.Reportes.DataSets.DataSetReportesTableAdapters.ProductosXVentaTableAdapter();
            this.ventaXProductoXHoraTableAdapter = new Escritorio.Reportes.DataSets.DataSetReportesTableAdapters.VentaXProductoXHoraTableAdapter();
            this.DeliveryXHoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryXHoraTableAdapter = new Escritorio.Reportes.DataSets.DataSetReportesTableAdapters.DeliveryXHoraTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1Reporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VentaXProductoXHoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosXVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesXUltimaCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesQueMasCompraronBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoVentaXDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosPorVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosPorVenta1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosPorVentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosPorVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryXHoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentaXProductoXHoraBindingSource
            // 
            this.VentaXProductoXHoraBindingSource.DataMember = "VentaXProductoXHora";
            this.VentaXProductoXHoraBindingSource.DataSource = this.dataSetReportes;
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductosXVentaBindingSource
            // 
            this.ProductosXVentaBindingSource.DataMember = "ProductosXVenta";
            this.ProductosXVentaBindingSource.DataSource = this.dataSetReportes;
            // 
            // ClientesXUltimaCompraBindingSource
            // 
            this.ClientesXUltimaCompraBindingSource.DataMember = "ClientesXUltimaCompra";
            this.ClientesXUltimaCompraBindingSource.DataSource = this.dataSetReportes;
            // 
            // ClientesQueMasCompraronBindingSource
            // 
            this.ClientesQueMasCompraronBindingSource.DataMember = "ClientesQueMasCompraron";
            this.ClientesQueMasCompraronBindingSource.DataSource = this.dataSetReportes;
            // 
            // montoVentaXDiaBindingSource
            // 
            this.montoVentaXDiaBindingSource.DataMember = "MontoVentaXDia";
            this.montoVentaXDiaBindingSource.DataSource = this.dataSetReportes;
            // 
            // montoVentaXDiaTableAdapter
            // 
            this.montoVentaXDiaTableAdapter.ClearBeforeFill = true;
            // 
            // clientesQueMasCompraronTableAdapter
            // 
            this.clientesQueMasCompraronTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetReportes1
            // 
            this.dataSetReportes1.DataSetName = "DataSetReportes";
            this.dataSetReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesXUltimaCompraTableAdapter
            // 
            this.clientesXUltimaCompraTableAdapter.ClearBeforeFill = true;
            // 
            // productosXVentaTableAdapter
            // 
            this.productosXVentaTableAdapter.ClearBeforeFill = true;
            // 
            // ventaXProductoXHoraTableAdapter
            // 
            this.ventaXProductoXHoraTableAdapter.ClearBeforeFill = true;
            // 
            // DeliveryXHoraBindingSource
            // 
            this.DeliveryXHoraBindingSource.DataMember = "DeliveryXHora";
            this.DeliveryXHoraBindingSource.DataSource = this.dataSetReportes;
            // 
            // deliveryXHoraTableAdapter
            // 
            this.deliveryXHoraTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1Reporte);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerTo);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerFrom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(764, 391);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 10;
            // 
            // comboBox1Reporte
            // 
            this.comboBox1Reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Reporte.FormattingEnabled = true;
            this.comboBox1Reporte.Location = new System.Drawing.Point(556, 14);
            this.comboBox1Reporte.Name = "comboBox1Reporte";
            this.comboBox1Reporte.Size = new System.Drawing.Size(181, 21);
            this.comboBox1Reporte.TabIndex = 14;
            this.comboBox1Reporte.SelectedIndexChanged += new System.EventHandler(this.comboBoxReporte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desde";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(285, 14);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 11;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(54, 14);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 10;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(764, 347);
            this.reportViewer1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reporte";
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 391);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReportesForm";
            this.Text = "ReportesForm";
            this.Load += new System.EventHandler(this.ClientesTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentaXProductoXHoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosXVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesXUltimaCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesQueMasCompraronBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoVentaXDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosPorVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosPorVenta1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosPorVentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosPorVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryXHoraBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.BindingSource productosPorVenta1BindingSource;
        private Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
        private System.Windows.Forms.BindingSource productosPorVentasBindingSource;
        private System.Windows.Forms.BindingSource ProductosPorVentaBindingSource;
        private System.Windows.Forms.BindingSource productosPorVentaBindingSource1;
        private System.Windows.Forms.BindingSource montoVentaXDiaBindingSource;
        private DataSets.DataSetReportes dataSetReportes;
        private DataSets.DataSetReportesTableAdapters.MontoVentaXDiaTableAdapter montoVentaXDiaTableAdapter;
        private System.Windows.Forms.BindingSource ClientesQueMasCompraronBindingSource;
        private DataSets.DataSetReportesTableAdapters.ClientesQueMasCompraronTableAdapter clientesQueMasCompraronTableAdapter;
        private System.Windows.Forms.BindingSource ClientesXUltimaCompraBindingSource;
        private DataSets.DataSetReportes dataSetReportes1;
        private DataSets.DataSetReportesTableAdapters.ClientesXUltimaCompraTableAdapter clientesXUltimaCompraTableAdapter;
        private System.Windows.Forms.BindingSource ProductosXVentaBindingSource;
        private DataSets.DataSetReportesTableAdapters.ProductosXVentaTableAdapter productosXVentaTableAdapter;
        private System.Windows.Forms.BindingSource VentaXProductoXHoraBindingSource;
        private DataSets.DataSetReportesTableAdapters.VentaXProductoXHoraTableAdapter ventaXProductoXHoraTableAdapter;
        private System.Windows.Forms.BindingSource DeliveryXHoraBindingSource;
        private DataSets.DataSetReportesTableAdapters.DeliveryXHoraTableAdapter deliveryXHoraTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1Reporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
    }
}
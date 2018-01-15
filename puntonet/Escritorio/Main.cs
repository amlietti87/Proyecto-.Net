using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace Escritorio
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            Text = String.Format("Delivery Macana v{0}", Application.ProductVersion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void webConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WebConf()).ShowDialog();
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AcercaDe()).ShowDialog();
        }

        private void salir_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Caja_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Caja()).ShowDialog();
        }

        private void Clientes_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //(new Clientes()).Show();
            Clientes FormHijo = Application.OpenForms.OfType<Clientes>().FirstOrDefault() ?? new Clientes();
            AddFormInPanel(FormHijo);
        }

        private void Productos_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(new Productos()).Show();
            Productos FormHijo = Application.OpenForms.OfType<Productos>().FirstOrDefault() ?? new Productos();
            AddFormInPanel(FormHijo);
        }

        private void Reportes_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.ReportesForm FormHijo = Application.OpenForms.OfType<Reportes.ReportesForm>().FirstOrDefault() ?? new Reportes.ReportesForm();
            AddFormInPanel(FormHijo);
        }

        private void NuevoPedido_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Pedidos.Add FormHijo = Application.OpenForms.OfType<Pedidos.Add>().FirstOrDefault() ?? new Pedidos.Add();
            FormHijo.autoCompleteTextBoxs();
            AddFormInPanel(FormHijo);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos.StatusList FormHijo = Application.OpenForms.OfType<Pedidos.StatusList>().FirstOrDefault() ?? new Pedidos.StatusList();
            FormHijo.updateGridStatusList(); //actualizar cada vez que se presiona el menu
            AddFormInPanel(FormHijo);
        }
    }
}

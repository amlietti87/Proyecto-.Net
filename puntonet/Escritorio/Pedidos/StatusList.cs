using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Pedidos
{
    public partial class StatusList : Form
    {
        Timer refreshTimer = new Timer();
        private Database.DataClassesDataContext dc = new Database.DataClassesDataContext();
        public StatusList()
        {
            InitializeComponent();

            //temporizador para actualizar datagrid
            //refreshTimer.Interval = 5000;  //5s, en milisegundos
            //refreshTimer.Tick += new EventHandler(refreshTimer_Tick);
            //refreshTimer.Start();

            //updateGridStatusList();

            // Query para estados en combobox
            var MisEstados =
                from c in dc.Estados_Pedidos
                select new { EstadoID = c.Estado_Id, Descr = c.Descripcion };

            comboBox_Estado.DataSource = MisEstados.ToList();
            comboBox_Estado.DisplayMember = "Descr";
            comboBox_Estado.ValueMember = "EstadoID";
        }


        void refreshTimer_Tick(object sender, EventArgs e)
        {
            //updateGridStatusList(); desactivado por innecesario de momento
        }

        public void updateGridStatusList()
        {
            dgv_pedidosPendientes.DataSource = null;

            var queryDatagrid = (from c in dc.Fechas_Estados_Pedidos
                                 orderby c.Fecha descending
                                 group c by new { c.Pedido_Id } into grouping
                                 select new
                                 {
                                     PedidoID = grouping.FirstOrDefault().Pedido_Id,
                                     Cliente = grouping.FirstOrDefault().Pedido.Cliente.Apellido.Trim() + " " + grouping.FirstOrDefault().Pedido.Cliente.Nombre.Trim(),
                                     Domicilio = grouping.FirstOrDefault().Pedido.Cliente.Direccion,
                                     Fecha = grouping.FirstOrDefault().Fecha,
                                     Telefono = grouping.FirstOrDefault().Pedido.Cliente.Telefono,
                                     Estado = grouping.FirstOrDefault().Estados_Pedido.Descripcion,
                                     Enviar = grouping.FirstOrDefault().Pedido.Enviar
                                 }

                ).Where(g => g.Estado != "Entregado" && g.Estado != "Cancelado");

            dgv_pedidosPendientes.DataSource = queryDatagrid.ToList();

            lbl_CountRecibido.Text= "Recibidos: "+queryDatagrid.Count(n => n.Estado == "Recibido");
            lbl_CountCocina.Text = "En Cocina: " + queryDatagrid.Count(n => n.Estado == "Cocina");
            lbl_CountEnviado.Text = "Enviados: " + queryDatagrid.Count(n => n.Estado == "Enviado");

        }

        private void comboBox_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgv_pedidosPendientes.CurrentRow != null)
            {
                int PedidoID = (Int32)dgv_pedidosPendientes.CurrentRow.Cells[0].Value;
                Database.Fechas_Estados_Pedido MiEstadoPedido = new Database.Fechas_Estados_Pedido();
                MiEstadoPedido.Estado_Id = (Int32)comboBox_Estado.SelectedValue;
                MiEstadoPedido.Pedido_Id = PedidoID;
                MiEstadoPedido.Fecha = DateTime.Now;
                dc.Fechas_Estados_Pedidos.InsertOnSubmit(MiEstadoPedido);
                dc.SubmitChanges();
                updateGridStatusList();
            }
            else
            {
                //System.Console.WriteLine("no selecciono fila");
            }
        }

        private void dgv_detallePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_pedidosPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_pedidosPendientes.CurrentRow != null)
            {
                int PedidoID = (Int32)dgv_pedidosPendientes.CurrentRow.Cells[0].Value;
                Database.Fechas_Estados_Pedido MiEstadoPedido = new Database.Fechas_Estados_Pedido();
                //update datagrid
                dgv_detallePedido.DataSource = null;
                var queryDatagrid = (from c in dc.Pedidos_Productos
                                     join p in dc.Productos on c.Producto_Cod equals p.Prod_Cod
                                     join w in dc.Pedidos on c.Pedido_Id equals w.Pedido_Id
                                     where c.Pedido_Id == PedidoID
                                     select new
                                     {
                                         Codigo = c.Producto_Cod,
                                         Descripcion = p.Prod_Desc,
                                         Cantidad = c.Cantidad_Producto,
                                         PrecioUnitario = p.Prod_Precio, //no habria que mostrar el precio unitario porque es el precio unitario actual y no el de momento del pedido, lo mismo para descripción
                                         AbonaCon = w.AbonaCon,
                                         TotalACobrar = w.TotalACobrar
                                     }).ToList();

                dgv_detallePedido.DataSource = (queryDatagrid.Select(i => new { i.Codigo, i.Descripcion, i.Cantidad, i.PrecioUnitario })).ToList();

                //calcular total 
                Decimal total = queryDatagrid.Select(i => i.TotalACobrar).FirstOrDefault();
                text_TotalCompra.Text = total.ToString();
                //obtener abonacon
                Decimal AbonaCon = queryDatagrid.Select(i => i.AbonaCon).FirstOrDefault();
                text_AbonaCon.Text = AbonaCon.ToString();
                //calcular vuelto
                if (AbonaCon != 0)
                {
                    text_Vuelto.Text = (AbonaCon - total).ToString();
                }
                else
                {
                    text_Vuelto.Text = "0.00";
                }

            }
            else
            {
                //System.Console.WriteLine("daragrid2: no selecciono fila");
            }
        }
    }
}

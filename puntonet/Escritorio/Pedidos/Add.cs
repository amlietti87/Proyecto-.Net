using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace Escritorio.Pedidos
{
    public partial class Add : Form
    {
        private Database.DataClassesDataContext dc = new Database.DataClassesDataContext();
        private List<Database.Pedidos_Producto> CarritoPedidos = new List<Database.Pedidos_Producto>();
        private Decimal TotalCompra = 0;

        public Add()
        {
            InitializeComponent();
        }

        private bool ValidarDatosPagos()
        {
            bool val = true;
            if (!TextValidator.ValidarFloat(text_AbonaCon.Text))
            {
                val = false;
                Validaciones.SetError(text_AbonaCon, "Debe ingresar un monto valida!");
            }
            return val;

        }
        private bool ValidarDatosCompra()
        {
            bool val = true;
            if (textBoxProductoCodigo.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(textBoxProductoCodigo, "Debe Ingresar un Codigo!");
            }
            else if (!TextValidator.ValidarEntero(textBoxProductoCodigo.Text))
            {
                val = false;
                Validaciones.SetError(textBoxProductoCodigo, "Debe ingresar un codigo valido!");
            }

            int CantidadProducto = 0;
            Int32.TryParse(textBoxProductoCantidad.Text, out CantidadProducto);
            if (textBoxProductoCantidad.Text.Trim() == "" || CantidadProducto < 1)
            {
                val = false;
                Validaciones.SetError(textBoxProductoCantidad, "Debe Ingresar una cantidad!");
                textBoxProductoCantidad.Text = "1";
            }
            else if (!TextValidator.ValidarEntero(textBoxProductoCantidad.Text))
            {
                val = false;
                Validaciones.SetError(textBoxProductoCantidad, "Debe ingresar una cantidad valida!");
            }
            return val;
        }

        private bool ValidarDatosCliente()
        {
            bool val = true;
            if (txt_Nombre.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_Nombre, "Debe Ingresar un Nombre!");
            }
            else if (!TextValidator.ValidarString(txt_Nombre.Text))
            {
                val = false;
                Validaciones.SetError(txt_Nombre, "El nombre debe contener unicamente letras!");
            }


            if (txt_Apellido.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_Apellido, "Debe Ingresar un Apellido!");
            }
            else if (!TextValidator.ValidarString(txt_Apellido.Text))
            {
                val = false;
                Validaciones.SetError(txt_Apellido, "El Apellido debe contener unicamente letras!");
            }

            if (txt_Telefono.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_Telefono, "Debe Ingresar un teléfono!");
            }
            else if (!TextValidator.ValidarTelefono(txt_Telefono.Text))
            {
                val = false;
                Validaciones.SetError(txt_Telefono, "Ingrese un teléfono entre 7 y 13 dígitos");
            }


            if (txt_Domicilio.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_Domicilio, "Debe Ingresar un Domicilio!");
            }
            else if (!TextValidator.ValidarStringEntero(txt_Domicilio.Text))
            {
                val = false;
                Validaciones.SetError(txt_Domicilio, "Debe ingresar un domicilio valido!");
            }

            return val;
        }

        public void autoCompleteTextBoxs()
        {
            var telefonos = dc.Clientes.Select(c => c.Telefono).Distinct().ToArray();
            AutoCompleteStringCollection ACSCtelefonos = new AutoCompleteStringCollection();
            ACSCtelefonos.AddRange(telefonos);
            txt_Telefono.AutoCompleteCustomSource = ACSCtelefonos;
            txt_Telefono.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Telefono.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            var apellidos = dc.Clientes.Select(c => c.Apellido).Distinct().ToArray();
            AutoCompleteStringCollection ACSCapellidos = new AutoCompleteStringCollection();
            ACSCapellidos.AddRange(apellidos);
            txt_Apellido.AutoCompleteCustomSource = ACSCapellidos;
            txt_Apellido.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Apellido.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            var direcciones = dc.Clientes.Select(c => c.Direccion).Distinct().ToArray();
            AutoCompleteStringCollection ACSCdirecciones = new AutoCompleteStringCollection();
            ACSCdirecciones.AddRange(direcciones);
            txt_Domicilio.AutoCompleteCustomSource = ACSCdirecciones;
            txt_Domicilio.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Domicilio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            var codigosproductos = dc.Productos.Select(c => c.Prod_Cod.ToString()).Distinct().ToArray();
            AutoCompleteStringCollection ACSCCodigosProductos = new AutoCompleteStringCollection();
            ACSCCodigosProductos.AddRange(codigosproductos);
            textBoxProductoCodigo.AutoCompleteCustomSource = ACSCCodigosProductos;
            textBoxProductoCodigo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxProductoCodigo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = dc.Clientes.Where(w => w.Telefono == txt_Telefono.Text.Trim()).FirstOrDefault();
                txt_Apellido.Text = query.Apellido.Trim();
                txt_Nombre.Text = query.Nombre.Trim();
                txt_Domicilio.Text = query.Direccion.Trim();
            }
            catch
            {
            }
        }

        private void txt_Apellido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = dc.Clientes.Where(w => w.Apellido == txt_Apellido.Text.Trim()).FirstOrDefault();
                txt_Telefono.Text = query.Telefono.Trim();
                txt_Nombre.Text = query.Nombre.Trim();
                txt_Domicilio.Text = query.Direccion.Trim();
            }
            catch
            {
            }
        }

        private void txt_Domicilio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = dc.Clientes.Where(w => w.Direccion == txt_Domicilio.Text.Trim()).FirstOrDefault();
                txt_Telefono.Text = query.Telefono.Trim();
                txt_Nombre.Text = query.Nombre.Trim();
                txt_Apellido.Text = query.Apellido.Trim();
            }
            catch
            {
            }
        }

        private void AceptarCliente_Click(object sender, EventArgs e)
        {
            // Validacion de los datos del cliente.
            if (ValidarDatosCliente())
            {
                var ClientExistByTel = dc.Clientes.Where(w => w.Telefono == txt_Telefono.Text).FirstOrDefault();
                //verificar el telefono de cliente existe
                if (ClientExistByTel == null)
                {
                    MessageBox.Show("Debe elegir un cliente por su teléfono!");
                    return;
                }

                groupBox_Cliente.Enabled = false;
                groupBox_Pedido.Enabled = true;
            }

        }

        private void CancelarPedido_Click(object sender, EventArgs e)
        {
            //deberia resetear todos los formularios
            limparFormularios();
        }

        private void limparFormularios()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is DataGridView)
                        (control as DataGridView).DataSource = null;
                    else if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
            CarritoPedidos.Clear();
            groupBox_Cliente.Enabled = true;
            groupBox_Pedido.Enabled = false;

            // this.Controls.Clear();
            // this.InitializeComponent();

        }

        private void ConfirmarPedido_Click(object sender, EventArgs e)
        {
            // Validacion de los campos, mas precisamente con cuanto abona.
            if (ValidarDatosPagos())
            {
                //verificar existe seleccionado un cliente y al menos 1 producto en carrito
                if (CarritoPedidos.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto al pedido!");
                    return;
                }

                //generar un nuevo pedido
                Database.Pedido MiPedido = new Database.Pedido();
                MiPedido.Cliente_Id = dc.Clientes.Where(w => w.Telefono == txt_Telefono.Text).Select(x => x.Id).FirstOrDefault();
                MiPedido.Enviar = checkBox_Enviar.Checked;

                Decimal TotalDeCompra = 0;
                Decimal AbonaCompraCon = 0;
                Decimal.TryParse(text_TotalCompra.Text, out TotalDeCompra);
                Decimal.TryParse(text_AbonaCon.Text, out AbonaCompraCon);
                MiPedido.TotalACobrar = TotalDeCompra;
                MiPedido.AbonaCon = AbonaCompraCon;

                dc.Pedidos.InsertOnSubmit(MiPedido);
                dc.SubmitChanges();
                int PedidoID = MiPedido.Pedido_Id;
                //Guardar productos de pedido
                foreach (Database.Pedidos_Producto carr in CarritoPedidos)
                {
                    carr.Pedido_Id = MiPedido.Pedido_Id;
                    dc.Pedidos_Productos.InsertOnSubmit(carr);

                }

                //Guardar Estado_Pedido
                Database.Fechas_Estados_Pedido MiEstadoPedido = new Database.Fechas_Estados_Pedido();
                MiEstadoPedido.Estado_Id = 1; //Recibido
                MiEstadoPedido.Pedido_Id = MiPedido.Pedido_Id;
                MiEstadoPedido.Fecha = DateTime.Now;
                dc.Fechas_Estados_Pedidos.InsertOnSubmit(MiEstadoPedido);
                dc.SubmitChanges();

                limparFormularios();
            }


        }

        private void textBoxProductoCodigo_TextChanged(object sender, EventArgs e)
        {
            FindProductByID();
        }

        private bool FindProductByID()
        {
            try
            {
                var query = dc.Productos.Where(w => w.Prod_Cod == Convert.ToInt32(textBoxProductoCodigo.Text.Trim())).FirstOrDefault();
                textBoxProductoDescripcion.Text = query.Prod_Desc.Trim();
                return true;
            }
            catch
            {
                textBoxProductoDescripcion.Text = "producto no encontrado";
                return false;
            }
        }

        private void updateTextVuelto()
        {
            Decimal abonaConMonto = 0;
            Decimal TotalDeLaCompra = 0;
            Decimal.TryParse(text_AbonaCon.Text, out abonaConMonto);
            Decimal.TryParse(text_TotalCompra.Text, out TotalDeLaCompra);
            if (abonaConMonto != 0)
            {
                text_Vuelto.Text = (abonaConMonto - TotalDeLaCompra).ToString();
            }
            else
            {
                text_Vuelto.Text = "0";
            }

        }

        private void btn_AddProducto_Click(object sender, EventArgs e)
        {
            //no agregar productos inexistentes
            if (!FindProductByID())
                return;


            // Validacion de datos ingresados.
            if (ValidarDatosCompra())
            {
                
                int CantidadProducto = 0;
                Int32.TryParse(textBoxProductoCantidad.Text, out CantidadProducto);

                Database.Pedidos_Producto newpedidos_Producto = new Database.Pedidos_Producto();
                newpedidos_Producto.Producto_Cod = Int32.Parse(textBoxProductoCodigo.Text);
                newpedidos_Producto.Cantidad_Producto = CantidadProducto;

                CarritoPedidos.Add(newpedidos_Producto);

                updateListado();
            }

        }

        private void updateListado()
        {
            //update datagrid
            dataGridView1.DataSource = null;

            var queryDatagrid = (from c in CarritoPedidos
                                 join p in dc.Productos on c.Producto_Cod equals p.Prod_Cod
                                 select new
                                 {
                                     Codigo = c.Producto_Cod,
                                     Descripcion = p.Prod_Desc,
                                     Cantidad = c.Cantidad_Producto,
                                     PrecioUnitario = p.Prod_Precio
                                 }).ToList();
            dataGridView1.DataSource = queryDatagrid;

            //calcular total compra 
            TotalCompra = 0;
            foreach (Database.Pedidos_Producto carr in CarritoPedidos)
            {

                var preciounitario = dc.Productos.Where(w => w.Prod_Cod == carr.Producto_Cod).Select(g => g.Prod_Precio).FirstOrDefault();
                TotalCompra += (carr.Cantidad_Producto * preciounitario);
                System.Console.WriteLine("cantidad " + carr.Cantidad_Producto + " precio unidad" + preciounitario);
            }
            text_TotalCompra.Text = TotalCompra.ToString();
            updateTextVuelto();
        }

        private void text_AbonaCon_TextChanged(object sender, EventArgs e)
        {
            updateTextVuelto();
        }

        private void btn_DelProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                CarritoPedidos.RemoveAt(dataGridView1.CurrentRow.Index);
                updateListado();
            }
            else
            {
                //System.Console.WriteLine("no selecciono fila");
            }

        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_Domicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void textBoxProductoCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void textBoxProductoCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void text_AbonaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }
    }
}

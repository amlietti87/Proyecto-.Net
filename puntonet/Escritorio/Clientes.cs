using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Utilities;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Clientes : Form
    {
        String operacion;
        public Clientes()
        {
            InitializeComponent();
            Cliente_Load();
        }

        void ListarClientes()
        {
            Database.DataClassesDataContext cc = new Database.DataClassesDataContext();
            dgv_Clientes.DataSource = cc.Clientes;
        }

        void Cliente_Load()
        {
            this.ListarClientes();
            this.LimpiarCampos();
            grp_Datos.Enabled = false;
            grp_Listado.Enabled = true;
            dgv_Clientes.AllowUserToAddRows = false;
            dgv_Clientes.ReadOnly = true;

        }

        void LimpiarCampos()
        {
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_Domicilio.Text = "";
            txt_Telefono.Text = "";

        }

        private bool ValidarCampos()
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
                Validaciones.SetError(txt_Telefono, "Debe Ingresar un Telefono!");
            }
            else if (!TextValidator.ValidarTelefono(txt_Telefono.Text))
            {
                val = false;
                Validaciones.SetError(txt_Telefono, "Ingrese un telefono valido!");
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

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            grp_Datos.Enabled = true;
            grp_Listado.Enabled = false;
            LimpiarCampos();
            operacion = "agregar";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
			if(txt_Apellido.Text == "")
			{
				MessageBox.Show("Debe elegir un cliente para modificar");
				this.Cliente_Load();
			}
			else
			{
				Validaciones.Clear();
				grp_Datos.Enabled = true;
				grp_Listado.Enabled = false;
				operacion = "modificar";
			}
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
			if(txt_Nombre.Text == "")
			{
				MessageBox.Show("No hay un cliente seleccionado para eliminar");
				this.Cliente_Load();
			}else
			{
				try
				{
					Database.DataClassesDataContext cc = new Database.DataClassesDataContext();
					int ClienteId = Convert.ToInt32(dgv_Clientes.CurrentRow.Cells[0].Value);
					Database.Cliente clientedelete = cc.Clientes.Single(w => w.Id == ClienteId);
					cc.Clientes.DeleteOnSubmit(clientedelete);
					cc.SubmitChanges();
					MessageBox.Show("El Cliente ha sido eliminado!");
					this.Cliente_Load();
				}
				catch (Exception ex)
				{
					System.Console.WriteLine(ex.Message);
					MessageBox.Show("No se ha podido eliminar al cliente!");
					this.Cliente_Load();
				}
			}
            

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            Database.DataClassesDataContext cc = new Database.DataClassesDataContext();

            if (ValidarCampos())
            {
                switch (operacion)
                {
                    case "agregar":
                        try
                        {
                            Database.Cliente newcliente = new Database.Cliente();
                            newcliente.Nombre = txt_Nombre.Text.Trim();
                            newcliente.Apellido = txt_Apellido.Text.Trim();
                            newcliente.Direccion = txt_Domicilio.Text.Trim();
                            newcliente.Telefono = txt_Telefono.Text.Trim();
                            cc.Clientes.InsertOnSubmit(newcliente);
                            cc.SubmitChanges();
                            MessageBox.Show("Nuevo cliente cargado!");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("No se pudo guardar el cliente ingresado!");
                            break;
                        }


                    case "modificar":
                        try
                        {
                            int ClienteId = Convert.ToInt32(dgv_Clientes.CurrentRow.Cells[0].Value);
                            var query = cc.Clientes.Where(w => w.Id == ClienteId).FirstOrDefault();
                            query.Nombre = txt_Nombre.Text.Trim();
                            query.Apellido = txt_Apellido.Text.Trim();
                            query.Direccion = txt_Domicilio.Text.Trim();
                            query.Telefono = txt_Telefono.Text.Trim();
                            cc.SubmitChanges();
                            MessageBox.Show("Cliente Actualizado!");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("No se pudo actualizar correctamente el cliente!");
                            break;
                        }

                }
                this.Cliente_Load();
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            this.Cliente_Load();
        }

        private void dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_Nombre.Text = dgv_Clientes.CurrentRow.Cells[1].Value.ToString().Trim();
            txt_Apellido.Text = dgv_Clientes.CurrentRow.Cells[2].Value.ToString().Trim();
            txt_Domicilio.Text = dgv_Clientes.CurrentRow.Cells[3].Value.ToString().Trim();
            txt_Telefono.Text = dgv_Clientes.CurrentRow.Cells[4].Value.ToString().Trim();

        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }
    }
}

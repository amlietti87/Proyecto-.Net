using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Utilities;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Productos : Form
    {
        String operacion;
        public Productos()
        {
            InitializeComponent();
            Productos_Load();
        }

        void ListarProductos()
        {
            Database.DataClassesDataContext cp = new Database.DataClassesDataContext();
            dgv_Productos.DataSource = cp.Productos;
        }

        void Productos_Load()
        {
            this.ListarProductos();
            this.LimpiarCampos();
            grp_ListadoProduc.Enabled = true;
            grp_Productos.Enabled = false;
            dgv_Productos.AllowUserToAddRows = false;
            dgv_Productos.ReadOnly = true;

        }

        void LimpiarCampos()
        {
            txt_Codigo.Text = "";
            txt_Producto.Text = "";
            txt_Precio.Text = "";
            cb_Web.Checked = false;
        }

        private bool ValidarCampos()
        {
            bool val = true;
            if (txt_Codigo.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_Codigo, "Debe ingresar un codigo!");
            }
            else if (!TextValidator.ValidarEntero(txt_Codigo.Text))
            {
                val = false;
                Validaciones.SetError(txt_Codigo, "El codigo es unicamente numerico");
            }

            if (txt_Producto.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_Producto, "Debe Ingresar un Producto!");
            }
            else if (!TextValidator.ValidarStringEntero(txt_Producto.Text) && (!TextValidator.ValidarString(txt_Producto.Text)))
            {
                val = false;
                Validaciones.SetError(txt_Producto, "Producto mal ingresado!");
            }

            if (txt_Precio.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_Precio, "Debe Ingresar un Precio para el producto!");
            }
            else if (!TextValidator.ValidarFloat(txt_Precio.Text))
            {
                val = false;
                Validaciones.SetError(txt_Precio, "El precio del producto debe ser numero y con 2 decimales");
            }

            return val;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            txt_Codigo.ReadOnly = false;
            grp_Productos.Enabled = true;
            grp_ListadoProduc.Enabled = false;
            LimpiarCampos();
            operacion = "agregar";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
			
			if (txt_Codigo.Text == ""){
				MessageBox.Show("Debe seleccionar un producto para modificar!");
				this.Productos_Load();
			} else {
				Validaciones.Clear();
				txt_Codigo.ReadOnly = true;
				grp_Productos.Enabled = true;
				grp_ListadoProduc.Enabled = false;
				operacion = "modificar";
			}
            
        }

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Codigo.Text = dgv_Productos.CurrentRow.Cells[0].Value.ToString().Trim();
            txt_Producto.Text = dgv_Productos.CurrentRow.Cells[1].Value.ToString().Trim();
            txt_Precio.Text = dgv_Productos.CurrentRow.Cells[2].Value.ToString().Trim();
            cb_Web.Checked = Convert.ToBoolean(dgv_Productos.CurrentRow.Cells[3].Value.ToString());

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
			if(txt_Codigo.Text == "")
			{
				MessageBox.Show("Debe seleccionar un producto para eliminar!");
				this.Productos_Load();
			}
			else
			{
				try
				{
					Database.DataClassesDataContext cp = new Database.DataClassesDataContext();
					int ProductoId = Convert.ToInt32(dgv_Productos.CurrentRow.Cells[0].Value);
					Database.Producto productodelete = cp.Productos.Single(w => w.Prod_Cod == ProductoId);
					cp.Productos.DeleteOnSubmit(productodelete);
					cp.SubmitChanges();
					MessageBox.Show("El Producto ha sido eliminado!");
					this.Productos_Load();
				}
				catch (Exception ex)
				{
					System.Console.WriteLine(ex.Message);
					MessageBox.Show("No se ha podido eliminar el producto seleccionado!");
					this.Productos_Load();
				}
			}
            
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            Database.DataClassesDataContext cp = new Database.DataClassesDataContext();

            if (ValidarCampos())
            {
                switch (operacion)
                {
                    case "agregar":
                        try
                        {
                            Database.Producto newproducto = new Database.Producto();
                            newproducto.Prod_Cod = Int32.Parse(txt_Codigo.Text);
                            newproducto.Prod_Desc = txt_Producto.Text;
                            newproducto.Prod_Precio = Decimal.Parse(txt_Precio.Text);
                            if (cb_Web.Checked)
                            {
                                newproducto.Prod_Web = true;
                            }
                            else
                            {
                                newproducto.Prod_Web = false;
                            }
                            cp.Productos.InsertOnSubmit(newproducto);
                            cp.SubmitChanges();
                            MessageBox.Show("Nuevo producto cargado!");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("No se pudo guardar el producto ingresado!");
                            break;
                        }


                    case "modificar":
                        try
                        {
                            int ProductoId = Convert.ToInt32(dgv_Productos.CurrentRow.Cells[0].Value);
                            var query = cp.Productos.Where(w => w.Prod_Cod == ProductoId).FirstOrDefault();
                            query.Prod_Cod = Int32.Parse(txt_Codigo.Text); ;
                            query.Prod_Desc = txt_Producto.Text;
                            query.Prod_Precio = Decimal.Parse(txt_Precio.Text);
                            if (cb_Web.Checked)
                            {
                                query.Prod_Web = true;
                            }
                            else
                            {
                                query.Prod_Web = false;
                            }
                            cp.SubmitChanges();
                            MessageBox.Show("Producto Actualizado!");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("No se pudo actualizar correctamente el producto!");
                            break;
                        }

                }
                this.Productos_Load();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            this.Productos_Load();
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }
    }
}

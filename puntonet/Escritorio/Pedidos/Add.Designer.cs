namespace Escritorio.Pedidos
{
    partial class Add
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
			this.groupBox_Cliente = new System.Windows.Forms.GroupBox();
			this.checkBox_Enviar = new System.Windows.Forms.CheckBox();
			this.AceptarCliente = new System.Windows.Forms.Button();
			this.txt_Telefono = new System.Windows.Forms.TextBox();
			this.txt_Domicilio = new System.Windows.Forms.TextBox();
			this.txt_Apellido = new System.Windows.Forms.TextBox();
			this.txt_Nombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox_Pedido = new System.Windows.Forms.GroupBox();
			this.btn_DelProducto = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_AddProducto = new System.Windows.Forms.Button();
			this.textBoxProductoCantidad = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxProductoCodigo = new System.Windows.Forms.TextBox();
			this.textBoxProductoDescripcion = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_ConfirmarPedido = new System.Windows.Forms.Button();
			this.btn_CancelarPedido = new System.Windows.Forms.Button();
			this.text_TotalCompra = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.text_AbonaCon = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.text_Vuelto = new System.Windows.Forms.TextBox();
			this.Validaciones = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox_Cliente.SuspendLayout();
			this.groupBox_Pedido.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Validaciones)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox_Cliente
			// 
			this.groupBox_Cliente.Controls.Add(this.checkBox_Enviar);
			this.groupBox_Cliente.Controls.Add(this.AceptarCliente);
			this.groupBox_Cliente.Controls.Add(this.txt_Telefono);
			this.groupBox_Cliente.Controls.Add(this.txt_Domicilio);
			this.groupBox_Cliente.Controls.Add(this.txt_Apellido);
			this.groupBox_Cliente.Controls.Add(this.txt_Nombre);
			this.groupBox_Cliente.Controls.Add(this.label4);
			this.groupBox_Cliente.Controls.Add(this.label3);
			this.groupBox_Cliente.Controls.Add(this.label2);
			this.groupBox_Cliente.Controls.Add(this.label1);
			this.groupBox_Cliente.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox_Cliente.Location = new System.Drawing.Point(0, 0);
			this.groupBox_Cliente.Name = "groupBox_Cliente";
			this.groupBox_Cliente.Size = new System.Drawing.Size(752, 105);
			this.groupBox_Cliente.TabIndex = 0;
			this.groupBox_Cliente.TabStop = false;
			this.groupBox_Cliente.Text = "Cliente";
			// 
			// checkBox_Enviar
			// 
			this.checkBox_Enviar.AutoSize = true;
			this.checkBox_Enviar.Location = new System.Drawing.Point(620, 33);
			this.checkBox_Enviar.Name = "checkBox_Enviar";
			this.checkBox_Enviar.Size = new System.Drawing.Size(56, 17);
			this.checkBox_Enviar.TabIndex = 21;
			this.checkBox_Enviar.Text = "Enviar";
			this.checkBox_Enviar.UseVisualStyleBackColor = true;
			// 
			// AceptarCliente
			// 
			this.AceptarCliente.Location = new System.Drawing.Point(620, 58);
			this.AceptarCliente.Name = "AceptarCliente";
			this.AceptarCliente.Size = new System.Drawing.Size(110, 23);
			this.AceptarCliente.TabIndex = 20;
			this.AceptarCliente.Text = "Elegir Cliente";
			this.AceptarCliente.UseVisualStyleBackColor = true;
			this.AceptarCliente.Click += new System.EventHandler(this.AceptarCliente_Click);
			// 
			// txt_Telefono
			// 
			this.txt_Telefono.Location = new System.Drawing.Point(122, 35);
			this.txt_Telefono.MaxLength = 30;
			this.txt_Telefono.Name = "txt_Telefono";
			this.txt_Telefono.Size = new System.Drawing.Size(163, 20);
			this.txt_Telefono.TabIndex = 19;
			this.txt_Telefono.TextChanged += new System.EventHandler(this.txt_Telefono_TextChanged);
			this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_KeyPress);
			// 
			// txt_Domicilio
			// 
			this.txt_Domicilio.Location = new System.Drawing.Point(415, 35);
			this.txt_Domicilio.MaxLength = 30;
			this.txt_Domicilio.Name = "txt_Domicilio";
			this.txt_Domicilio.Size = new System.Drawing.Size(163, 20);
			this.txt_Domicilio.TabIndex = 18;
			this.txt_Domicilio.TextChanged += new System.EventHandler(this.txt_Domicilio_TextChanged);
			this.txt_Domicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Domicilio_KeyPress);
			// 
			// txt_Apellido
			// 
			this.txt_Apellido.Location = new System.Drawing.Point(122, 61);
			this.txt_Apellido.MaxLength = 30;
			this.txt_Apellido.Name = "txt_Apellido";
			this.txt_Apellido.Size = new System.Drawing.Size(163, 20);
			this.txt_Apellido.TabIndex = 17;
			this.txt_Apellido.TextChanged += new System.EventHandler(this.txt_Apellido_TextChanged);
			this.txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_KeyPress);
			// 
			// txt_Nombre
			// 
			this.txt_Nombre.Location = new System.Drawing.Point(415, 61);
			this.txt_Nombre.MaxLength = 30;
			this.txt_Nombre.Name = "txt_Nombre";
			this.txt_Nombre.Size = new System.Drawing.Size(163, 20);
			this.txt_Nombre.TabIndex = 16;
			this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Telefono";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(326, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Domicilio";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Apellido";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(326, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Nombre";
			// 
			// groupBox_Pedido
			// 
			this.groupBox_Pedido.Controls.Add(this.btn_DelProducto);
			this.groupBox_Pedido.Controls.Add(this.dataGridView1);
			this.groupBox_Pedido.Controls.Add(this.btn_AddProducto);
			this.groupBox_Pedido.Controls.Add(this.textBoxProductoCantidad);
			this.groupBox_Pedido.Controls.Add(this.label7);
			this.groupBox_Pedido.Controls.Add(this.textBoxProductoCodigo);
			this.groupBox_Pedido.Controls.Add(this.textBoxProductoDescripcion);
			this.groupBox_Pedido.Controls.Add(this.label6);
			this.groupBox_Pedido.Controls.Add(this.label5);
			this.groupBox_Pedido.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox_Pedido.Enabled = false;
			this.groupBox_Pedido.Location = new System.Drawing.Point(0, 105);
			this.groupBox_Pedido.Name = "groupBox_Pedido";
			this.groupBox_Pedido.Size = new System.Drawing.Size(752, 220);
			this.groupBox_Pedido.TabIndex = 1;
			this.groupBox_Pedido.TabStop = false;
			this.groupBox_Pedido.Text = "Pedido";
			// 
			// btn_DelProducto
			// 
			this.btn_DelProducto.Location = new System.Drawing.Point(620, 55);
			this.btn_DelProducto.Name = "btn_DelProducto";
			this.btn_DelProducto.Size = new System.Drawing.Size(110, 23);
			this.btn_DelProducto.TabIndex = 30;
			this.btn_DelProducto.Text = "Eliminar selección";
			this.btn_DelProducto.UseVisualStyleBackColor = true;
			this.btn_DelProducto.Click += new System.EventHandler(this.btn_DelProducto_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 84);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ShowCellErrors = false;
			this.dataGridView1.ShowCellToolTips = false;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.ShowRowErrors = false;
			this.dataGridView1.Size = new System.Drawing.Size(694, 130);
			this.dataGridView1.TabIndex = 29;
			// 
			// btn_AddProducto
			// 
			this.btn_AddProducto.Location = new System.Drawing.Point(620, 26);
			this.btn_AddProducto.Name = "btn_AddProducto";
			this.btn_AddProducto.Size = new System.Drawing.Size(110, 23);
			this.btn_AddProducto.TabIndex = 21;
			this.btn_AddProducto.Text = "Agregar Producto";
			this.btn_AddProducto.UseVisualStyleBackColor = true;
			this.btn_AddProducto.Click += new System.EventHandler(this.btn_AddProducto_Click);
			// 
			// textBoxProductoCantidad
			// 
			this.textBoxProductoCantidad.Location = new System.Drawing.Point(533, 39);
			this.textBoxProductoCantidad.MaxLength = 3;
			this.textBoxProductoCantidad.Name = "textBoxProductoCantidad";
			this.textBoxProductoCantidad.Size = new System.Drawing.Size(49, 20);
			this.textBoxProductoCantidad.TabIndex = 28;
			this.textBoxProductoCantidad.Text = "1";
			this.textBoxProductoCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductoCantidad_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(478, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 13);
			this.label7.TabIndex = 27;
			this.label7.Text = "Cantidad";
			// 
			// textBoxProductoCodigo
			// 
			this.textBoxProductoCodigo.Location = new System.Drawing.Point(122, 36);
			this.textBoxProductoCodigo.MaxLength = 4;
			this.textBoxProductoCodigo.Name = "textBoxProductoCodigo";
			this.textBoxProductoCodigo.Size = new System.Drawing.Size(64, 20);
			this.textBoxProductoCodigo.TabIndex = 26;
			this.textBoxProductoCodigo.TextChanged += new System.EventHandler(this.textBoxProductoCodigo_TextChanged);
			this.textBoxProductoCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductoCodigo_KeyPress);
			// 
			// textBoxProductoDescripcion
			// 
			this.textBoxProductoDescripcion.Location = new System.Drawing.Point(295, 36);
			this.textBoxProductoDescripcion.MaxLength = 80;
			this.textBoxProductoDescripcion.Name = "textBoxProductoDescripcion";
			this.textBoxProductoDescripcion.ReadOnly = true;
			this.textBoxProductoDescripcion.Size = new System.Drawing.Size(163, 20);
			this.textBoxProductoDescripcion.TabIndex = 25;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(206, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 23;
			this.label6.Text = "Descripción";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 24;
			this.label5.Text = "Código Producto";
			// 
			// btn_ConfirmarPedido
			// 
			this.btn_ConfirmarPedido.Location = new System.Drawing.Point(500, 416);
			this.btn_ConfirmarPedido.Name = "btn_ConfirmarPedido";
			this.btn_ConfirmarPedido.Size = new System.Drawing.Size(110, 23);
			this.btn_ConfirmarPedido.TabIndex = 21;
			this.btn_ConfirmarPedido.Text = "Confirmar Pedido";
			this.btn_ConfirmarPedido.UseVisualStyleBackColor = true;
			this.btn_ConfirmarPedido.Click += new System.EventHandler(this.ConfirmarPedido_Click);
			// 
			// btn_CancelarPedido
			// 
			this.btn_CancelarPedido.Location = new System.Drawing.Point(631, 416);
			this.btn_CancelarPedido.Name = "btn_CancelarPedido";
			this.btn_CancelarPedido.Size = new System.Drawing.Size(110, 23);
			this.btn_CancelarPedido.TabIndex = 22;
			this.btn_CancelarPedido.Text = "Cancelar Pedido";
			this.btn_CancelarPedido.UseVisualStyleBackColor = true;
			this.btn_CancelarPedido.Click += new System.EventHandler(this.CancelarPedido_Click);
			// 
			// text_TotalCompra
			// 
			this.text_TotalCompra.Location = new System.Drawing.Point(662, 331);
			this.text_TotalCompra.MaxLength = 18;
			this.text_TotalCompra.Name = "text_TotalCompra";
			this.text_TotalCompra.ReadOnly = true;
			this.text_TotalCompra.Size = new System.Drawing.Size(68, 20);
			this.text_TotalCompra.TabIndex = 30;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(586, 334);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 30;
			this.label8.Text = "Total Compra";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(586, 360);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 31;
			this.label9.Text = "Abona con";
			// 
			// text_AbonaCon
			// 
			this.text_AbonaCon.Location = new System.Drawing.Point(662, 357);
			this.text_AbonaCon.MaxLength = 18;
			this.text_AbonaCon.Name = "text_AbonaCon";
			this.text_AbonaCon.Size = new System.Drawing.Size(68, 20);
			this.text_AbonaCon.TabIndex = 32;
			this.text_AbonaCon.TextChanged += new System.EventHandler(this.text_AbonaCon_TextChanged);
			this.text_AbonaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_AbonaCon_KeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(586, 386);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 33;
			this.label10.Text = "Vuelto";
			// 
			// text_Vuelto
			// 
			this.text_Vuelto.Location = new System.Drawing.Point(662, 383);
			this.text_Vuelto.MaxLength = 18;
			this.text_Vuelto.Name = "text_Vuelto";
			this.text_Vuelto.ReadOnly = true;
			this.text_Vuelto.Size = new System.Drawing.Size(68, 20);
			this.text_Vuelto.TabIndex = 34;
			// 
			// Validaciones
			// 
			this.Validaciones.ContainerControl = this;
			// 
			// Add
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 451);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.text_Vuelto);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.text_AbonaCon);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.text_TotalCompra);
			this.Controls.Add(this.btn_CancelarPedido);
			this.Controls.Add(this.btn_ConfirmarPedido);
			this.Controls.Add(this.groupBox_Pedido);
			this.Controls.Add(this.groupBox_Cliente);
			this.Name = "Add";
			this.Text = "Add";
			this.groupBox_Cliente.ResumeLayout(false);
			this.groupBox_Cliente.PerformLayout();
			this.groupBox_Pedido.ResumeLayout(false);
			this.groupBox_Pedido.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Validaciones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Cliente;
        private System.Windows.Forms.GroupBox groupBox_Pedido;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Domicilio;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AceptarCliente;
        private System.Windows.Forms.Button btn_ConfirmarPedido;
        private System.Windows.Forms.Button btn_CancelarPedido;
        private System.Windows.Forms.TextBox textBoxProductoCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxProductoCodigo;
        private System.Windows.Forms.TextBox textBoxProductoDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_TotalCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_AbonaCon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_Vuelto;
        private System.Windows.Forms.CheckBox checkBox_Enviar;
        private System.Windows.Forms.Button btn_DelProducto;
		private System.Windows.Forms.ErrorProvider Validaciones;
	}
}
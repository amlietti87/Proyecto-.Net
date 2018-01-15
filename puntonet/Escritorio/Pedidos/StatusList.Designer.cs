namespace Escritorio.Pedidos
{
    partial class StatusList
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
			this.groupBox_PedidosSinEntregar = new System.Windows.Forms.GroupBox();
			this.lbl_CountEnviado = new System.Windows.Forms.Label();
			this.lbl_CountCocina = new System.Windows.Forms.Label();
			this.lbl_CountRecibido = new System.Windows.Forms.Label();
			this.dgv_pedidosPendientes = new System.Windows.Forms.DataGridView();
			this.comboBox_Estado = new System.Windows.Forms.ComboBox();
			this.dataClassesDataContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox_detallePedido = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.text_Vuelto = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.text_AbonaCon = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.text_TotalCompra = new System.Windows.Forms.TextBox();
			this.dgv_detallePedido = new System.Windows.Forms.DataGridView();
			this.groupBox_PedidosSinEntregar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_pedidosPendientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataClassesDataContextBindingSource)).BeginInit();
			this.groupBox_detallePedido.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox_PedidosSinEntregar
			// 
			this.groupBox_PedidosSinEntregar.Controls.Add(this.lbl_CountEnviado);
			this.groupBox_PedidosSinEntregar.Controls.Add(this.lbl_CountCocina);
			this.groupBox_PedidosSinEntregar.Controls.Add(this.lbl_CountRecibido);
			this.groupBox_PedidosSinEntregar.Controls.Add(this.dgv_pedidosPendientes);
			this.groupBox_PedidosSinEntregar.Controls.Add(this.comboBox_Estado);
			this.groupBox_PedidosSinEntregar.Location = new System.Drawing.Point(12, 12);
			this.groupBox_PedidosSinEntregar.Name = "groupBox_PedidosSinEntregar";
			this.groupBox_PedidosSinEntregar.Size = new System.Drawing.Size(805, 175);
			this.groupBox_PedidosSinEntregar.TabIndex = 0;
			this.groupBox_PedidosSinEntregar.TabStop = false;
			this.groupBox_PedidosSinEntregar.Text = "Pedidos Sin Entregar";
			// 
			// lbl_CountEnviado
			// 
			this.lbl_CountEnviado.AutoSize = true;
			this.lbl_CountEnviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_CountEnviado.Location = new System.Drawing.Point(688, 117);
			this.lbl_CountEnviado.Name = "lbl_CountEnviado";
			this.lbl_CountEnviado.Size = new System.Drawing.Size(63, 13);
			this.lbl_CountEnviado.TabIndex = 5;
			this.lbl_CountEnviado.Text = "Enviados:";
			// 
			// lbl_CountCocina
			// 
			this.lbl_CountCocina.AutoSize = true;
			this.lbl_CountCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_CountCocina.Location = new System.Drawing.Point(688, 95);
			this.lbl_CountCocina.Name = "lbl_CountCocina";
			this.lbl_CountCocina.Size = new System.Drawing.Size(69, 13);
			this.lbl_CountCocina.TabIndex = 4;
			this.lbl_CountCocina.Text = "En Cocina:";
			// 
			// lbl_CountRecibido
			// 
			this.lbl_CountRecibido.AutoSize = true;
			this.lbl_CountRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_CountRecibido.Location = new System.Drawing.Point(689, 72);
			this.lbl_CountRecibido.Name = "lbl_CountRecibido";
			this.lbl_CountRecibido.Size = new System.Drawing.Size(71, 13);
			this.lbl_CountRecibido.TabIndex = 3;
			this.lbl_CountRecibido.Text = "Recibidos: ";
			// 
			// dgv_pedidosPendientes
			// 
			this.dgv_pedidosPendientes.AllowUserToAddRows = false;
			this.dgv_pedidosPendientes.AllowUserToDeleteRows = false;
			this.dgv_pedidosPendientes.AllowUserToOrderColumns = true;
			this.dgv_pedidosPendientes.AllowUserToResizeRows = false;
			this.dgv_pedidosPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv_pedidosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_pedidosPendientes.Dock = System.Windows.Forms.DockStyle.Left;
			this.dgv_pedidosPendientes.Location = new System.Drawing.Point(3, 16);
			this.dgv_pedidosPendientes.MultiSelect = false;
			this.dgv_pedidosPendientes.Name = "dgv_pedidosPendientes";
			this.dgv_pedidosPendientes.ReadOnly = true;
			this.dgv_pedidosPendientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgv_pedidosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_pedidosPendientes.ShowCellToolTips = false;
			this.dgv_pedidosPendientes.ShowEditingIcon = false;
			this.dgv_pedidosPendientes.Size = new System.Drawing.Size(679, 156);
			this.dgv_pedidosPendientes.TabIndex = 2;
			this.dgv_pedidosPendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidosPendientes_CellClick);
			// 
			// comboBox_Estado
			// 
			this.comboBox_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Estado.FormattingEnabled = true;
			this.comboBox_Estado.Location = new System.Drawing.Point(691, 19);
			this.comboBox_Estado.Name = "comboBox_Estado";
			this.comboBox_Estado.Size = new System.Drawing.Size(108, 21);
			this.comboBox_Estado.TabIndex = 1;
			this.comboBox_Estado.SelectedIndexChanged += new System.EventHandler(this.comboBox_Estado_SelectedIndexChanged);
			// 
			// dataClassesDataContextBindingSource
			// 
			this.dataClassesDataContextBindingSource.DataSource = typeof(Database.DataClassesDataContext);
			// 
			// groupBox_detallePedido
			// 
			this.groupBox_detallePedido.Controls.Add(this.label10);
			this.groupBox_detallePedido.Controls.Add(this.text_Vuelto);
			this.groupBox_detallePedido.Controls.Add(this.label9);
			this.groupBox_detallePedido.Controls.Add(this.text_AbonaCon);
			this.groupBox_detallePedido.Controls.Add(this.label8);
			this.groupBox_detallePedido.Controls.Add(this.text_TotalCompra);
			this.groupBox_detallePedido.Controls.Add(this.dgv_detallePedido);
			this.groupBox_detallePedido.Location = new System.Drawing.Point(11, 193);
			this.groupBox_detallePedido.Name = "groupBox_detallePedido";
			this.groupBox_detallePedido.Size = new System.Drawing.Size(806, 180);
			this.groupBox_detallePedido.TabIndex = 2;
			this.groupBox_detallePedido.TabStop = false;
			this.groupBox_detallePedido.Text = "Detalle de Pedido";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(650, 71);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 45;
			this.label10.Text = "Vuelto";
			// 
			// text_Vuelto
			// 
			this.text_Vuelto.Location = new System.Drawing.Point(726, 68);
			this.text_Vuelto.MaxLength = 18;
			this.text_Vuelto.Name = "text_Vuelto";
			this.text_Vuelto.ReadOnly = true;
			this.text_Vuelto.Size = new System.Drawing.Size(68, 20);
			this.text_Vuelto.TabIndex = 46;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(650, 45);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 43;
			this.label9.Text = "Abona con";
			// 
			// text_AbonaCon
			// 
			this.text_AbonaCon.Location = new System.Drawing.Point(726, 42);
			this.text_AbonaCon.MaxLength = 18;
			this.text_AbonaCon.Name = "text_AbonaCon";
			this.text_AbonaCon.ReadOnly = true;
			this.text_AbonaCon.Size = new System.Drawing.Size(68, 20);
			this.text_AbonaCon.TabIndex = 44;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(650, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 41;
			this.label8.Text = "Total Compra";
			// 
			// text_TotalCompra
			// 
			this.text_TotalCompra.Location = new System.Drawing.Point(726, 16);
			this.text_TotalCompra.MaxLength = 18;
			this.text_TotalCompra.Name = "text_TotalCompra";
			this.text_TotalCompra.ReadOnly = true;
			this.text_TotalCompra.Size = new System.Drawing.Size(68, 20);
			this.text_TotalCompra.TabIndex = 42;
			// 
			// dgv_detallePedido
			// 
			this.dgv_detallePedido.AllowUserToAddRows = false;
			this.dgv_detallePedido.AllowUserToDeleteRows = false;
			this.dgv_detallePedido.AllowUserToOrderColumns = true;
			this.dgv_detallePedido.AllowUserToResizeRows = false;
			this.dgv_detallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv_detallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_detallePedido.Dock = System.Windows.Forms.DockStyle.Left;
			this.dgv_detallePedido.Location = new System.Drawing.Point(3, 16);
			this.dgv_detallePedido.MultiSelect = false;
			this.dgv_detallePedido.Name = "dgv_detallePedido";
			this.dgv_detallePedido.ReadOnly = true;
			this.dgv_detallePedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgv_detallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_detallePedido.ShowCellErrors = false;
			this.dgv_detallePedido.ShowCellToolTips = false;
			this.dgv_detallePedido.ShowEditingIcon = false;
			this.dgv_detallePedido.Size = new System.Drawing.Size(638, 161);
			this.dgv_detallePedido.TabIndex = 0;
			this.dgv_detallePedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detallePedido_CellClick);
			// 
			// StatusList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 385);
			this.Controls.Add(this.groupBox_detallePedido);
			this.Controls.Add(this.groupBox_PedidosSinEntregar);
			this.Name = "StatusList";
			this.Text = "StatusList";
			this.groupBox_PedidosSinEntregar.ResumeLayout(false);
			this.groupBox_PedidosSinEntregar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_pedidosPendientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataClassesDataContextBindingSource)).EndInit();
			this.groupBox_detallePedido.ResumeLayout(false);
			this.groupBox_detallePedido.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_PedidosSinEntregar;
        private System.Windows.Forms.GroupBox groupBox_detallePedido;
        private System.Windows.Forms.ComboBox comboBox_Estado;
        private System.Windows.Forms.DataGridView dgv_pedidosPendientes;
        private System.Windows.Forms.BindingSource dataClassesDataContextBindingSource;
        private System.Windows.Forms.DataGridView dgv_detallePedido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_Vuelto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_AbonaCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_TotalCompra;
        private System.Windows.Forms.Label lbl_CountRecibido;
        private System.Windows.Forms.Label lbl_CountEnviado;
        private System.Windows.Forms.Label lbl_CountCocina;
    }
}
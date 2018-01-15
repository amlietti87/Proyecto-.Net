namespace Escritorio
{
    partial class Productos
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
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.prodCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPrecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodWebDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_Productos = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.cb_Web = new System.Windows.Forms.CheckBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Validaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_ListadoProduc = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.grp_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).BeginInit();
            this.grp_ListadoProduc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.AutoGenerateColumns = false;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCodDataGridViewTextBoxColumn,
            this.prodDescDataGridViewTextBoxColumn,
            this.prodPrecioDataGridViewTextBoxColumn,
            this.prodWebDataGridViewCheckBoxColumn});
            this.dgv_Productos.DataSource = this.productoBindingSource;
            this.dgv_Productos.Location = new System.Drawing.Point(11, 17);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.Size = new System.Drawing.Size(445, 187);
            this.dgv_Productos.TabIndex = 0;
            this.dgv_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellClick);
            // 
            // prodCodDataGridViewTextBoxColumn
            // 
            this.prodCodDataGridViewTextBoxColumn.DataPropertyName = "Prod_Cod";
            this.prodCodDataGridViewTextBoxColumn.HeaderText = "Prod_Cod";
            this.prodCodDataGridViewTextBoxColumn.Name = "prodCodDataGridViewTextBoxColumn";
            // 
            // prodDescDataGridViewTextBoxColumn
            // 
            this.prodDescDataGridViewTextBoxColumn.DataPropertyName = "Prod_Desc";
            this.prodDescDataGridViewTextBoxColumn.HeaderText = "Prod_Desc";
            this.prodDescDataGridViewTextBoxColumn.Name = "prodDescDataGridViewTextBoxColumn";
            // 
            // prodPrecioDataGridViewTextBoxColumn
            // 
            this.prodPrecioDataGridViewTextBoxColumn.DataPropertyName = "Prod_Precio";
            this.prodPrecioDataGridViewTextBoxColumn.HeaderText = "Prod_Precio";
            this.prodPrecioDataGridViewTextBoxColumn.Name = "prodPrecioDataGridViewTextBoxColumn";
            // 
            // prodWebDataGridViewCheckBoxColumn
            // 
            this.prodWebDataGridViewCheckBoxColumn.DataPropertyName = "Prod_Web";
            this.prodWebDataGridViewCheckBoxColumn.HeaderText = "Prod_Web";
            this.prodWebDataGridViewCheckBoxColumn.Name = "prodWebDataGridViewCheckBoxColumn";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Database.Producto);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(510, 36);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 1;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(510, 99);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(510, 162);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Publicar en Web";
            // 
            // grp_Productos
            // 
            this.grp_Productos.Controls.Add(this.btn_Cancelar);
            this.grp_Productos.Controls.Add(this.btn_Confirmar);
            this.grp_Productos.Controls.Add(this.cb_Web);
            this.grp_Productos.Controls.Add(this.txt_Precio);
            this.grp_Productos.Controls.Add(this.txt_Producto);
            this.grp_Productos.Controls.Add(this.txt_Codigo);
            this.grp_Productos.Controls.Add(this.label4);
            this.grp_Productos.Controls.Add(this.label1);
            this.grp_Productos.Controls.Add(this.label3);
            this.grp_Productos.Controls.Add(this.label2);
            this.grp_Productos.Location = new System.Drawing.Point(1, 219);
            this.grp_Productos.Name = "grp_Productos";
            this.grp_Productos.Size = new System.Drawing.Size(621, 145);
            this.grp_Productos.TabIndex = 7;
            this.grp_Productos.TabStop = false;
            this.grp_Productos.Text = "Gestion Productos";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(245, 99);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(129, 99);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 17;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // cb_Web
            // 
            this.cb_Web.AutoSize = true;
            this.cb_Web.Location = new System.Drawing.Point(334, 64);
            this.cb_Web.Name = "cb_Web";
            this.cb_Web.Size = new System.Drawing.Size(15, 14);
            this.cb_Web.TabIndex = 16;
            this.cb_Web.UseVisualStyleBackColor = true;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(104, 60);
            this.txt_Precio.MaxLength = 18;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 15;
            this.txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Precio_KeyPress);
            // 
            // txt_Producto
            // 
            this.txt_Producto.Location = new System.Drawing.Point(334, 34);
            this.txt_Producto.MaxLength = 80;
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(252, 20);
            this.txt_Producto.TabIndex = 14;
            this.txt_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Producto_KeyPress);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(104, 34);
            this.txt_Codigo.MaxLength = 4;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 13;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Codigo ";
            // 
            // Validaciones
            // 
            this.Validaciones.ContainerControl = this;
            // 
            // grp_ListadoProduc
            // 
            this.grp_ListadoProduc.Controls.Add(this.btn_Eliminar);
            this.grp_ListadoProduc.Controls.Add(this.btn_Modificar);
            this.grp_ListadoProduc.Controls.Add(this.btn_Nuevo);
            this.grp_ListadoProduc.Controls.Add(this.dgv_Productos);
            this.grp_ListadoProduc.Location = new System.Drawing.Point(1, 1);
            this.grp_ListadoProduc.Name = "grp_ListadoProduc";
            this.grp_ListadoProduc.Size = new System.Drawing.Size(619, 212);
            this.grp_ListadoProduc.TabIndex = 8;
            this.grp_ListadoProduc.TabStop = false;
            this.grp_ListadoProduc.Text = "Productos";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 356);
            this.Controls.Add(this.grp_ListadoProduc);
            this.Controls.Add(this.grp_Productos);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.grp_Productos.ResumeLayout(false);
            this.grp_Productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).EndInit();
            this.grp_ListadoProduc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPrecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prodWebDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.ErrorProvider Validaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grp_ListadoProduc;
		private System.Windows.Forms.CheckBox cb_Web;
		private System.Windows.Forms.TextBox txt_Precio;
		private System.Windows.Forms.TextBox txt_Producto;
		private System.Windows.Forms.TextBox txt_Codigo;
		private System.Windows.Forms.Button btn_Confirmar;
		private System.Windows.Forms.Button btn_Cancelar;
	}
}
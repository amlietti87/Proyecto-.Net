namespace Escritorio
{
    partial class Caja
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
			this.textMontoApertura = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textFechaApertura = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textMontoCierre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textFechaCierre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textEstado = new System.Windows.Forms.TextBox();
			this.btnAbrirCaja = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnCerrarCaja = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textSaldo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textEfectivoEnCaja = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textMontoApertura
			// 
			this.textMontoApertura.Location = new System.Drawing.Point(135, 18);
			this.textMontoApertura.MaxLength = 18;
			this.textMontoApertura.Name = "textMontoApertura";
			this.textMontoApertura.Size = new System.Drawing.Size(143, 20);
			this.textMontoApertura.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Monto Apertura";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Fecha Apertura";
			// 
			// textFechaApertura
			// 
			this.textFechaApertura.Location = new System.Drawing.Point(135, 44);
			this.textFechaApertura.Name = "textFechaApertura";
			this.textFechaApertura.ReadOnly = true;
			this.textFechaApertura.Size = new System.Drawing.Size(143, 20);
			this.textFechaApertura.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ingreso Por Ventas";
			// 
			// textMontoCierre
			// 
			this.textMontoCierre.Location = new System.Drawing.Point(135, 70);
			this.textMontoCierre.MaxLength = 18;
			this.textMontoCierre.Name = "textMontoCierre";
			this.textMontoCierre.ReadOnly = true;
			this.textMontoCierre.Size = new System.Drawing.Size(143, 20);
			this.textMontoCierre.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(38, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Fecha Cierre";
			// 
			// textFechaCierre
			// 
			this.textFechaCierre.Location = new System.Drawing.Point(135, 96);
			this.textFechaCierre.Name = "textFechaCierre";
			this.textFechaCierre.ReadOnly = true;
			this.textFechaCierre.Size = new System.Drawing.Size(143, 20);
			this.textFechaCierre.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(38, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Estado";
			// 
			// textEstado
			// 
			this.textEstado.Location = new System.Drawing.Point(135, 143);
			this.textEstado.Name = "textEstado";
			this.textEstado.ReadOnly = true;
			this.textEstado.Size = new System.Drawing.Size(143, 20);
			this.textEstado.TabIndex = 8;
			// 
			// btnAbrirCaja
			// 
			this.btnAbrirCaja.Location = new System.Drawing.Point(41, 207);
			this.btnAbrirCaja.Name = "btnAbrirCaja";
			this.btnAbrirCaja.Size = new System.Drawing.Size(75, 23);
			this.btnAbrirCaja.TabIndex = 10;
			this.btnAbrirCaja.Text = "Abrir Caja";
			this.btnAbrirCaja.UseVisualStyleBackColor = true;
			this.btnAbrirCaja.Click += new System.EventHandler(this.BtnAbrirCaja_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(203, 207);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 11;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnCerrarCaja
			// 
			this.btnCerrarCaja.Location = new System.Drawing.Point(122, 207);
			this.btnCerrarCaja.Name = "btnCerrarCaja";
			this.btnCerrarCaja.Size = new System.Drawing.Size(75, 23);
			this.btnCerrarCaja.TabIndex = 12;
			this.btnCerrarCaja.Text = "Cerrar Caja";
			this.btnCerrarCaja.UseVisualStyleBackColor = true;
			this.btnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(38, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Saldo";
			// 
			// textSaldo
			// 
			this.textSaldo.Location = new System.Drawing.Point(135, 167);
			this.textSaldo.MaxLength = 18;
			this.textSaldo.Name = "textSaldo";
			this.textSaldo.ReadOnly = true;
			this.textSaldo.Size = new System.Drawing.Size(143, 20);
			this.textSaldo.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(38, 123);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Efectivo en Caja";
			// 
			// textEfectivoEnCaja
			// 
			this.textEfectivoEnCaja.Location = new System.Drawing.Point(135, 120);
			this.textEfectivoEnCaja.MaxLength = 18;
			this.textEfectivoEnCaja.Name = "textEfectivoEnCaja";
			this.textEfectivoEnCaja.Size = new System.Drawing.Size(143, 20);
			this.textEfectivoEnCaja.TabIndex = 15;
			this.textEfectivoEnCaja.TextChanged += new System.EventHandler(this.TextEfectivoEnCaja_TextChanged);
			// 
			// Caja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 242);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textEfectivoEnCaja);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textSaldo);
			this.Controls.Add(this.btnCerrarCaja);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAbrirCaja);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textEstado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textFechaCierre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textMontoCierre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textFechaApertura);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textMontoApertura);
			this.Name = "Caja";
			this.Text = "Caja";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMontoApertura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFechaApertura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMontoCierre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFechaCierre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Button btnAbrirCaja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textEfectivoEnCaja;
    }
}
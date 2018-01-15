namespace Escritorio
{
    partial class WebConf
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.NombreComercial = new System.Windows.Forms.TextBox();
            this.TelefonoContacto = new System.Windows.Forms.TextBox();
            this.Domicilio = new System.Windows.Forms.TextBox();
            this.HorarioAtencion = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.lblNombreComercial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxPublicarCatalogo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(251, 203);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 0;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(129, 203);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // NombreComercial
            // 
            this.NombreComercial.Location = new System.Drawing.Point(129, 29);
            this.NombreComercial.MaxLength = 80;
            this.NombreComercial.Name = "NombreComercial";
            this.NombreComercial.Size = new System.Drawing.Size(347, 20);
            this.NombreComercial.TabIndex = 2;
            // 
            // TelefonoContacto
            // 
            this.TelefonoContacto.Location = new System.Drawing.Point(129, 55);
            this.TelefonoContacto.MaxLength = 80;
            this.TelefonoContacto.Name = "TelefonoContacto";
            this.TelefonoContacto.Size = new System.Drawing.Size(347, 20);
            this.TelefonoContacto.TabIndex = 3;
            // 
            // Domicilio
            // 
            this.Domicilio.Location = new System.Drawing.Point(129, 81);
            this.Domicilio.MaxLength = 80;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Size = new System.Drawing.Size(347, 20);
            this.Domicilio.TabIndex = 4;
            // 
            // HorarioAtencion
            // 
            this.HorarioAtencion.Location = new System.Drawing.Point(129, 107);
            this.HorarioAtencion.MaxLength = 80;
            this.HorarioAtencion.Name = "HorarioAtencion";
            this.HorarioAtencion.Size = new System.Drawing.Size(347, 20);
            this.HorarioAtencion.TabIndex = 5;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(129, 133);
            this.Descripcion.MaxLength = 100;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(347, 20);
            this.Descripcion.TabIndex = 6;
            // 
            // lblNombreComercial
            // 
            this.lblNombreComercial.AutoSize = true;
            this.lblNombreComercial.Location = new System.Drawing.Point(27, 32);
            this.lblNombreComercial.Name = "lblNombreComercial";
            this.lblNombreComercial.Size = new System.Drawing.Size(93, 13);
            this.lblNombreComercial.TabIndex = 7;
            this.lblNombreComercial.Text = "Nomber Comercial";
            this.lblNombreComercial.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefono";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Horario de Atención";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción";
            // 
            // checkBoxPublicarCatalogo
            // 
            this.checkBoxPublicarCatalogo.AutoSize = true;
            this.checkBoxPublicarCatalogo.Location = new System.Drawing.Point(30, 159);
            this.checkBoxPublicarCatalogo.Name = "checkBoxPublicarCatalogo";
            this.checkBoxPublicarCatalogo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxPublicarCatalogo.Size = new System.Drawing.Size(109, 17);
            this.checkBoxPublicarCatalogo.TabIndex = 13;
            this.checkBoxPublicarCatalogo.Text = "Publicar Catalogo";
            this.checkBoxPublicarCatalogo.UseVisualStyleBackColor = true;
            // 
            // WebConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 244);
            this.Controls.Add(this.checkBoxPublicarCatalogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreComercial);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.HorarioAtencion);
            this.Controls.Add(this.Domicilio);
            this.Controls.Add(this.TelefonoContacto);
            this.Controls.Add(this.NombreComercial);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Cancelar);
            this.Name = "WebConf";
            this.Text = "Web Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox NombreComercial;
        private System.Windows.Forms.TextBox TelefonoContacto;
        private System.Windows.Forms.TextBox Domicilio;
        private System.Windows.Forms.TextBox HorarioAtencion;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label lblNombreComercial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxPublicarCatalogo;
    }
}
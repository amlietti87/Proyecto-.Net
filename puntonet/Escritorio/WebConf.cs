using System;
using Database;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class WebConf : Form
    {
        public WebConf()
        {
            InitializeComponent();
            DataClassesDataContext dc = new Database.DataClassesDataContext();
            try
            {
                var query = dc.WebConf.Where(w => w.Id == 1).FirstOrDefault();
                NombreComercial.Text = (query.NombreComercial).ToString().Trim();
                Descripcion.Text = (query.Descripcion).ToString().Trim();
                TelefonoContacto.Text = (query.TelefonoContacto).ToString().Trim();
                HorarioAtencion.Text = (query.HorarioAtencion).ToString().Trim();
                Domicilio.Text = (query.Domicilio).ToString().Trim();
                checkBoxPublicarCatalogo.Checked = (query.PublicarCatalago);
            }
            catch
            {

            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Database.DataClassesDataContext dc = new Database.DataClassesDataContext();
            var query = dc.WebConf.Where(w => w.Id == 1).FirstOrDefault();

            query.NombreComercial = NombreComercial.Text;
            query.HorarioAtencion = HorarioAtencion.Text;
            query.TelefonoContacto = TelefonoContacto.Text;
            query.Domicilio = Domicilio.Text;
            query.Descripcion = Descripcion.Text;
            query.PublicarCatalago = checkBoxPublicarCatalogo.Checked;
            dc.SubmitChanges();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

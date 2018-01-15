using System;
using System.Collections.Generic;
using System.Linq;
using Database;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Database.DataClassesDataContext dataContext = new Database.DataClassesDataContext();
                // System.Diagnostics.Debug.WriteLine(" AHIA" +dataContext.WebConfs.Where(id => id.Id == 1));
                //We insertedEmployee = db.Employees.FirstOrDefault(e ⇒e.Name.Equals("Michael"));
                WebConf mywebconf = dataContext.WebConf.FirstOrDefault(id => id.Id == 1);
                LabelNombreComercial.Text = (mywebconf.NombreComercial);
                LabelDescripcion.Text = (mywebconf.Descripcion);
                LabelDomicilio.Text = (mywebconf.Domicilio);
                LabelHorarioAtencion.Text = (mywebconf.HorarioAtencion);
                LabelTelefonoContacto.Text = (mywebconf.TelefonoContacto);
                GridViewProductos.Visible = (mywebconf.PublicarCatalago);
            }
            catch
            {

            }
        }
    }
}
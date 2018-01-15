using Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Utilities;
namespace Escritorio
{
    public partial class Caja : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        public Caja()
        {
            InitializeComponent();
            CargarCaja();
        }

        private void CargarCaja()
        {

            try
            {
                dc = new DataClassesDataContext();
                var query = dc.Caja.Where(w => w.Id == 1).FirstOrDefault();

                textMontoApertura.Text = (query.Monto_Apertura).ToString();
                textMontoCierre.Text = (query.Monto_Cierre).ToString();
                textFechaApertura.Text = (query.Fecha_Apertura).ToString();
                textFechaCierre.Text = (query.Fecha_Cierre).ToString();
                textEfectivoEnCaja.Text = (query.EfectivoCaja).ToString();
                textSaldo.Text = (query.Saldo.HasValue) ? (query.Saldo).Value.ToString("+#.##;-#.##;0") : "";
                calcularMontoCierre();
                if (query.Estado)
                {
                    //caja en estado abierta
                    textEstado.Text = "Abierta";
                    textMontoApertura.Enabled = false;
                    textEfectivoEnCaja.Enabled = true;
                    btnAbrirCaja.Enabled = false;
                    btnCerrarCaja.Enabled = true;
                }
                else
                {
                    //caja en estado cerrada u otro
                    textEstado.Text = "Cerrada";
                    textMontoApertura.Enabled = true;
                    textEfectivoEnCaja.Enabled = false;
                    btnAbrirCaja.Enabled = true;
                    btnCerrarCaja.Enabled = false;
                }

            }
            catch
            {
                //inicializar caja si no existe
                Database.Caja InicializarCaja = new Database.Caja();
                InicializarCaja.Id = 1;
                dc.Caja.InsertOnSubmit(InicializarCaja);
                dc.SubmitChanges();
            }
        }

        private bool ValidarFormulario(string InputToValidate, string ReferName)
        {

            if (!TextValidator.ValidarFloat(InputToValidate))
            {
                MessageBox.Show(ReferName + ": Inserte valores numéricos del 0 al 9 y ','");
                return false;
            };


            return true;
        }

        private void BtnAbrirCaja_Click(object sender, EventArgs e)
        {

            if (ValidarFormulario(textMontoApertura.Text, "Monto Apertura"))
            {


                DataClassesDataContext dc = new DataClassesDataContext();
                var query = dc.Caja.Where(w => w.Id == 1).FirstOrDefault();

                query.Estado = true;
                query.Monto_Apertura = Decimal.Parse(textMontoApertura.Text);
                query.Monto_Cierre = 0;
                query.Fecha_Apertura = DateTime.Now;
                query.Fecha_Cierre = null;
                query.Saldo = null;
                query.EfectivoCaja = null;
                dc.SubmitChanges();
                CargarCaja();
            };
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario(textEfectivoEnCaja.Text, "Efectivo En Caja"))
            {

                String EstadoSaldo = CheckSaldo() ? "" : " Atención: el saldo no es 0";
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cerrar la caja?" + EstadoSaldo, "Cerrar Caja", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                DataClassesDataContext dc = new DataClassesDataContext();
                var query = dc.Caja.Where(w => w.Id == 1).FirstOrDefault();

                query.Estado = false;
                query.Monto_Apertura = 0;
                query.Monto_Cierre = 0;
                query.Fecha_Cierre = DateTime.Now;
                query.Saldo = (textSaldo.Text != "") ? Decimal.Parse(textSaldo.Text) : 0m;
                query.EfectivoCaja = (textEfectivoEnCaja.Text != "") ? Decimal.Parse(textEfectivoEnCaja.Text) : 0m;
                dc.SubmitChanges();

                CargarCaja();
            }


        }
        private Decimal CalculateSaldo()
        {
            Decimal.TryParse(textMontoApertura.Text, out Decimal montoapertura);
            Decimal.TryParse(textEfectivoEnCaja.Text, out Decimal efectivocaja);
            Decimal.TryParse(textMontoCierre.Text, out Decimal montocierre);
            Decimal saldo = efectivocaja - montoapertura - montocierre;
            return saldo;
        }

        private void UpdateSaldoText(Decimal saldo)
        {
            textSaldo.Text = saldo.ToString("+#.##;-#.##;0");

            if (CheckSaldo())
            {
                textSaldo.BackColor = Color.Green;
                textSaldo.ForeColor = Color.White;


            }
            else
            {
                textSaldo.BackColor = Color.Red;
                textSaldo.ForeColor = Color.White;


            }
        }
        private bool CheckSaldo()
        {
            Decimal saldo = CalculateSaldo();

            if (saldo != 0)
            {


                return false;
            }
            else
            {

                return true;
            }
        }
        private void TextEfectivoEnCaja_TextChanged(object sender, EventArgs e)
        {
            if (textEstado.Text.Equals("Abierta"))
            {
                UpdateSaldoText(CalculateSaldo());
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calcularMontoCierre()
        {
            try
            {
                var montoCierreCalculado = (from c in dc.Fechas_Estados_Pedidos
                                            join w in dc.Pedidos on c.Pedido_Id equals w.Pedido_Id
                                            where c.Estados_Pedido.Estado_Id == 4 && c.Fecha >= dc.Caja.Select(q => q.Fecha_Apertura).FirstOrDefault()
                                            && (dc.Caja.Select(q => q.Fecha_Cierre).FirstOrDefault() != null ? c.Fecha <= dc.Caja.Select(q => q.Fecha_Cierre).FirstOrDefault() : true)
                                            select new
                                            {
                                                TotalACobrar = w.TotalACobrar
                                            }).Sum(i => i.TotalACobrar);
                textMontoCierre.Text = montoCierreCalculado.ToString();
            }
            catch
            {
                textMontoCierre.Text = "0.00";
            }
        }
    }
}

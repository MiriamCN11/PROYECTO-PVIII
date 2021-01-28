using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nominaCS2._1
{
    public partial class ReciboPago : Form
    {
        public ReciboPago()
        {
            InitializeComponent();
            lblNombre.Text = Empleados.nombre + " " + Empleados.apellidoP + " " + Empleados.apellidoM ;

            lblRFC.Text = Empleados.rfc;
            lblNSS.Text = Convert.ToString(Empleados.nss);
            lblAL.Text = Empleados.areaL;

            lblSalDia.Text = Convert.ToString(Nominas.salarioD);
            lblDiasP.Text = Convert.ToString(Nominas.diasP);
            lblHrsE.Text = Convert.ToString(Nominas.hrsEx);

            lblSalN.Text = Convert.ToString(Nominas.salarioN);
            lblSepDia.Text = Convert.ToString(Nominas.septimoD);
            lblpagoHrsE.Text = Convert.ToString(Nominas.pagohrsEx);
            lblBonoA.Text = Convert.ToString(Nominas.bonoAs);
            lblBonoP.Text = Convert.ToString(Nominas.bonoPT);

            lblTotalP.Text = Convert.ToString(Nominas.totalPE);

            lblISR.Text = Convert.ToString(Nominas.isr);
            lblIMSS.Text = Convert.ToString(Nominas.ims);

            lblTotalD.Text = Convert.ToString(Nominas.totalDE);

            lblNeto.Text = Convert.ToString(Nominas.neto);
        }

        private void btnMENU_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Menu menuInicial = new Menu();
            //mandarla a llamar y que se muestre
            menuInicial.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Nomina nomina = new Nomina();
            //mandarla a llamar y que se muestre
            nomina.Show();
        }
    }
}

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
    public partial class Buscar : Form
    {
        
        public int idBuscar;
        public Buscar()
        {
            InitializeComponent();
            btnBuscar.Enabled = true;
            btnModificarOPC.Enabled = false;
            btnEliminar.Enabled = false;
            btnNominaOPC.Enabled = false;
            btnMENU.Enabled = true;
        }

        private void btnMENU_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Menu menuInicial = new Menu();
            //mandarla a llamar y que se muestre
            menuInicial.Show();
        }

        private void btnModificarOPC_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Modificar m = new Modificar();
            //mandarla a llamar y que se muestre
            m.Show();
        }

        private void btnNominaOPC_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Nomina n = new Nomina();
            //mandarla a llamar y que se muestre
            n.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEmpleado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarE();
        }

        private void buscarEmpleado()
        {
            if (string.IsNullOrEmpty(txtIDBuscar.Text))
            {
                MessageBox.Show("Favor de llenar el espacio...");
            }
            else
            {
                idBuscar = Convert.ToInt32(txtIDBuscar.Text);
                if(idBuscar == Empleados.id)
                {
                    lstDatos.Items.Add("ID: " + Empleados.id);
                    lstDatos.Items.Add("Nombre: " + Empleados.nombre);
                    lstDatos.Items.Add("Apellido Paterno: " + Empleados.apellidoP);
                    lstDatos.Items.Add("Apellido Materno: " + Empleados.apellidoM);
                    lstDatos.Items.Add("Area Laboral: " + Empleados.areaL);
                    lstDatos.Items.Add("Turno: " + Empleados.turno);
                    lstDatos.Items.Add("Horas Trabajadas: " + Empleados.hrsT);
                    lstDatos.Items.Add("Sueldo Base: " + Empleados.sueldoB);
                    lstDatos.Items.Add("Tipo de pago: " + Empleados.tPago);
                    lstDatos.Items.Add("RFC: " + Empleados.rfc);
                    lstDatos.Items.Add("NSS: " + Empleados.nss);

                    btnBuscar.Enabled = false;
                    btnModificarOPC.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnNominaOPC.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ese ID no existe. Vuelva a intentar");
                }
            }
        }

        private void eliminarE()
        {
            Empleados.id = 0;
            Empleados.nombre = null;
            Empleados.apellidoP = null;
            Empleados.apellidoM = null;
            Empleados.areaL = null;
            Empleados.turno = null;
            Empleados.hrsT = 0;
            Empleados.sueldoB = 0;
            Empleados.tPago = null;
            Empleados.rfc = null;
            Empleados.nss = 0;

            txtIDBuscar.Clear();
            lstDatos.Items.Clear();

            MessageBox.Show("Se elimino con exito al empleado.");
            btnBuscar.Enabled = true;
            btnModificarOPC.Enabled = false;
            btnEliminar.Enabled = false;
            btnNominaOPC.Enabled = false;
        }
    }
}

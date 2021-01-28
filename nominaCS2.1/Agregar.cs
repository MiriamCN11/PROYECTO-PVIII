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
    public partial class Agregar : Form
    {
        //Empleados emp = new Empleados();
        public Agregar()
        {
            InitializeComponent();
            //AREAS DE TRABAJO
            //cbxAreaL.Items.Add("");
            cbxAreaL.Items.Add("Gerencia General");
            cbxAreaL.Items.Add("Finanzas");
            cbxAreaL.Items.Add("Recursos Humanos");
            cbxAreaL.Items.Add("Administración");
            cbxAreaL.Items.Add("Marketing");
            cbxAreaL.Items.Add("Contabilidad");
            cbxAreaL.Items.Add("Ventas");
            cbxAreaL.Items.Add("Capacitacion del personal");
            cbxAreaL.Items.Add("Contratación");
            cbxAreaL.Items.Add("Seguros");
            cbxAreaL.Items.Add("Departamentos de producción");
            cbxAreaL.Items.Add("Equipo de instalación");
            cbxAreaL.Items.Add("Departamento de calidad");
            cbxAreaL.Items.Add("Publicidad");
            cbxAreaL.Items.Add("Promociones");
            //TURNOS DE TRABAJO
            //cbxTurno.Items.Add("");
            cbxTurno.Items.Add("Matutino");
            cbxTurno.Items.Add("Vespertino");
            cbxTurno.Items.Add("Nocturno");
            //TIPO DE PAGO
            //cbxTipoP.Items.Add("");
            cbxTipoP.Items.Add("Semanal");
            cbxTipoP.Items.Add("Catorcenal");
            cbxTipoP.Items.Add("Quincenal");
            //HORAS DE TRABAJO AL DIA 
            cbxHrs.Items.Add("1");
            cbxHrs.Items.Add("2");
            cbxHrs.Items.Add("3");
            cbxHrs.Items.Add("4");
            cbxHrs.Items.Add("5");
            cbxHrs.Items.Add("6");
            cbxHrs.Items.Add("7");
            cbxHrs.Items.Add("8");
            cbxHrs.Items.Add("9");
            cbxHrs.Items.Add("10");
            cbxHrs.Items.Add("11");
            cbxHrs.Items.Add("12");
            cbxHrs.Items.Add("13");
            cbxHrs.Items.Add("14");
            cbxHrs.Items.Add("15");
            cbxHrs.Items.Add("16");
            cbxHrs.Items.Add("17");
            cbxHrs.Items.Add("18");
            cbxHrs.Items.Add("19");
            cbxHrs.Items.Add("20");
            cbxHrs.Items.Add("21");
            cbxHrs.Items.Add("22");
            cbxHrs.Items.Add("23");
            cbxHrs.Items.Add("24");
        }

        private void btnMENU_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Menu menuInicial = new Menu();
            //mandarla a llamar y que se muestre
            menuInicial.Show();
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            empleado();

            txtID.Text = "";
            txtNombres.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            cbxAreaL.Text = "";
            cbxTurno.Text = "";
            cbxHrs.Text = "";
            txtSueldoB.Text = "";
            cbxTipoP.Text = "";
            txtRFC.Text = "";
            txtNSS.Text = "";
        }

        public void empleado()
        {
            if(string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if(string.IsNullOrEmpty(txtNombres.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if (string.IsNullOrEmpty(txtApellidoP.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if (string.IsNullOrEmpty(txtApellidoM.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if (string.IsNullOrEmpty(cbxAreaL.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if (string.IsNullOrEmpty(cbxTurno.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if (string.IsNullOrEmpty(cbxHrs.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if (string.IsNullOrEmpty(txtSueldoB.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if (string.IsNullOrEmpty(cbxTipoP.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if (string.IsNullOrEmpty(txtRFC.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else if (string.IsNullOrEmpty(txtNSS.Text))
            {
                MessageBox.Show("Favor de llenar todos los espacios...");
            }
            else
            {
                Empleados.id = Convert.ToInt32(txtID.Text);
                Empleados.nombre = txtNombres.Text;
                Empleados.apellidoP = txtApellidoP.Text;
                Empleados.apellidoM = txtApellidoM.Text;
                Empleados.areaL = cbxAreaL.Text;
                Empleados.turno = cbxTurno.Text;
                Empleados.hrsT = Convert.ToInt32(cbxHrs.Text);
                Empleados.sueldoB = Convert.ToDouble(txtSueldoB.Text);
                Empleados.tPago = cbxTipoP.Text;
                Empleados.rfc = txtRFC.Text;
                Empleados.nss = Convert.ToInt64(txtNSS.Text);



                MessageBox.Show("SE HAN GUARDADO CON EXITO LOS DATOS");
            }
        }
    }
}

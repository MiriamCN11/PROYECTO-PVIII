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
    public partial class Login : Form
    {
        string usuario;
        string contraseña;

        public Login()
        {
            InitializeComponent();
            usuario = "admin";
            contraseña = "02042020";
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("¡Usuario o contraseña no validos!");
            }
            else if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("¡Usuario o contraseña no validos!...");
            }
            else if (txtUsuario.Text != usuario)
            {
                MessageBox.Show("¡Usuario o contraseña no validos!...");
            }
            else if (txtContraseña.Text != contraseña)
            {
                MessageBox.Show("¡Usuario o contraseña no validos!...");
            }
            else
            {
                this.Hide();//ocultar la ventana 
                Menu menuInicial = new Menu();
                //mandarla a llamar y que se muestre
                menuInicial.Show();
                MessageBox.Show("BIENVENID@");
            }
        }

        private void linkLblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Registro r = new Registro();
            //mandarla a llamar y que se muestre
            r.Show();
        }
    }
}

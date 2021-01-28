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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAgregarOPC_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Agregar a = new Agregar();
            //mandarla a llamar y que se muestre
            a.Show();
        }

        private void btnBuscarOPC_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Buscar b = new Buscar();
            //mandarla a llamar y que se muestre
            b.Show();
        }

        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            if (textNombre.Text.Trim() == "" || textContraseña.Text.Trim()  "") 
            {
                MetroMessageBox.Show(this, "No se pueden dejar espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textNombre.Text == "admin" && textContraseña.Text == "1234")
            {
                MetroMessageBox.Show(this, "Bienvenido", "Inicio de sesión correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

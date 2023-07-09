using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        //usuario
        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            pictureBox2.Image = Properties.Resources.usuario1;
            panel1.ForeColor = Color.FromArgb(0, 158, 253);
            txtUsuario.ForeColor = Color.FromArgb(0, 158, 253);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                pictureBox2.Image = Properties.Resources.usuario;
                txtUsuario.ForeColor = Color.WhiteSmoke;
                txtUsuario.UseSystemPasswordChar = false;
            }
        }
        //contraseña
        private void txtContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtContraseña.PasswordChar = '*';
            pictureBox4.Image = Properties.Resources.desbloquear;
            panel3.ForeColor = Color.FromArgb(0, 158, 253);
            txtContraseña.ForeColor = Color.FromArgb(0, 158, 253);
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                pictureBox4.Image = Properties.Resources.candado;
                txtContraseña.ForeColor = Color.WhiteSmoke;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}

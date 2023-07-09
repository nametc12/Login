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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();
        //cerrar
        private void label2_Click(object sender, EventArgs e)
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
        //correo

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            txtCorreo.Clear();
            pictureBox3.Image = Properties.Resources.correo_electronico1;
            panel2.ForeColor = Color.FromArgb(0, 158, 253);
            txtCorreo.ForeColor = Color.FromArgb(0, 158, 253);

        }
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                pictureBox3.Image = Properties.Resources.correo_electronico;
                txtCorreo.ForeColor = Color.WhiteSmoke;
                txtCorreo.UseSystemPasswordChar = false;
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
        //Facebook
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm2.Left += 10;
            if (frm2.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm2.Left -= 10;
            if (frm2.Left <= 525)
            {
                timer2.Stop();
            }
        }


        //twitter
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            frm3.Left += 10;
            if (frm3.Left >= 830)
            {
                timer3.Stop();
                this.TopMost = false;
                frm3.TopMost = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            frm3.Left -= 10;
            if (frm3.Left <= 525)
            {
                timer4.Stop();
            }
        }
        //google+
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            frm4.Left += 10;
            if (frm4.Left >= 830)
            {
                timer5.Stop();
                this.TopMost = false;
                frm4.TopMost = true;
                timer6.Start();
            }
        }
        private void timer6_Tick_1(object sender, EventArgs e)
        {
            frm4.Left -= 10;
            if (frm4.Left <= 525)
            {
                timer6.Stop();
            }
        }


        //login
        private void Form1_Load(object sender, EventArgs e)
        {
            frm2.Show();
            frm3.Show();
            frm4.Show();
        }


    }
}

﻿using DAS_D1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_D1
{
    public partial class LoginForm : Form
    {
        List <User> users = new List<User>() {
            new User ("fRuiz", "buenanota", "Fernando Ruiz"),
            new User ("jLopez", "123", "Jasson Lopez"),
            new User ("rSantos", "abc", "Romeo Santos")
        };
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User? user = users.Find(user => user.verifycredentials(tbxUsername.Text, tbxPassword.Text));
            if (user != null)
            {
                this.Close();

                AppForm appForm = new AppForm();
                appForm.Show();

                MessageBox.Show("Has accedido correctamente.");
            }

            else 
            { this.Close();

                MessageBox.Show("Usuario o contraseña inválidos.");

            }



        }


    }
}

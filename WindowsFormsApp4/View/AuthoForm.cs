﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Model;
using WindowsFormsApp4.Presenter;

namespace WindowsFormsApp4.View
{
    public partial class AuthoForm : Form, IAuthoView
    {
        public AuthoForm()
        {
            InitializeComponent();
            labelError.Text = "";
        }

        public string UserName
        {
            get { return textBoxUsername.Text; }
            set { textBoxUsername.Text = value; }
        }
        public string Pass
        {
            get { return textBoxPassword.Text; }
            set { textBoxPassword.Text = value; }
        }
        public string ErrorMessage
        {
            get { return labelError.Text; }
            set { labelError.Text = value; }
        }
        public AuthoPresenter authoPresenter { get; set; }

        private void AuthoForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (authoPresenter.LogIn(UserName, Pass))
            {
                this.Visible = false;
                SignInForm signInForm = new SignInForm(this);
                signInForm.Show();
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            authoPresenter.ErrorMessage();
            this.Visible = false;
            SignInForm signInForm = new SignInForm(this);
            var presenter = new SignInPresenter(signInForm);
            signInForm.Show();
            signInForm.Location = this.Location;
        }
    }
}

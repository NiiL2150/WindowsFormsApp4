using System;
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
    public partial class SignInForm : Form, ISignInView
    {
        public SignInForm(AuthoForm authoForm)
        {
            parentForm = authoForm;
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
        public SignInPresenter signInPresenter { get; set; }
        public AuthoForm parentForm { get; set; }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (signInPresenter.SignIn(UserName, Pass))
            {
                this.Close();
            }
        }

        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Visible = true;
        }
    }
}

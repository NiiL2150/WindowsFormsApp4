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
        public SignInForm()
        {
            InitializeComponent();
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
        public IAuthoView parentForm { get; set; }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        public void CloseReturn()
        {
            parentForm.Vision = true;
            this.Close();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            signInPresenter.SignIn(UserName, Pass);
        }
    }
}

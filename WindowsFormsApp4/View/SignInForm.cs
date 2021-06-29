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
            labelError.Text = "";
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
        public AuthoForm parentForm { get; set; }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            User user = parentForm.authoPresenter.repository.GetUserByName(UserName);
            if (user == null)
            {
                if(UserName.Length!=0 && Pass.Length != 0)
                {
                    signInPresenter.ErrorMessage();
                    parentForm.authoPresenter.repository.SaveUser(new User(UserName, Pass));
                    this.Close();
                }
                else
                {
                    signInPresenter.ErrorMessage("Can't be null!");
                }
            }
            else
            {
                signInPresenter.ErrorMessage("This user already exists!");
            }
        }

        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Visible = true;
        }
    }
}

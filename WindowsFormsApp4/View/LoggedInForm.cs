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
    public partial class LoggedInForm : Form, ILoggedInView
    {
        public LoggedInForm()
        {
            InitializeComponent();
        }

        private void LoggedInForm_Load(object sender, EventArgs e)
        {

        }

        public User LoggedInUser { get; set; }

        public User FindUser { get; set; }

        public int PostNumber
        {
            get
            {
                return vScrollBarPosts.Value;
            }
            set
            {
                vScrollBarPosts.Value = value;
            }
        }

        public int PostMaximum
        {
            get
            {
                return vScrollBarPosts.Maximum;
            }
            set
            {
                vScrollBarPosts.Maximum = value;
            }
        }

        public string FindUserName
        {
            get
            {
                return SearchTextBox.Text;
            }
            set
            {
                SearchTextBox.Text = value;
            }
        }

        public string Author
        {
            get
            {
                return labelAuthor.Text;
            }
            set
            {
                labelAuthor.Text = value;
            }
        }

        public string FoundPost
        {
            get
            {
                return textBoxPost.Text;
            }
            set
            {
                textBoxPost.Text = value;
            }
        }

        public string NewPost
        {
            get
            {
                return textBoxNewPost.Text;
            }
            set
            {
                textBoxNewPost.Text = value;
            }
        }

        public bool IsEditing
        {
            get
            {
                return !textBoxPost.ReadOnly;
            }
            set
            {
                textBoxPost.ReadOnly = !value;
                textBoxPost.Enabled = true;
            }
        }
        public bool CanEdit
        {
            get
            {
                return buttonEdit.Enabled;
            }
            set
            {
                buttonEdit.Enabled = value;
                buttonPost.Enabled = value;
                textBoxNewPost.Enabled = value;
            }
        }

        public LoggedInPresenter loggedInPresenter { get; set; }
        public IAuthoView parentForm { get; set; }

        public void CloseReturn()
        {
            parentForm.Vision = true;
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CloseReturn();
        }

        private void buttonMyPage_Click(object sender, EventArgs e)
        {
            loggedInPresenter.MyPageLoad();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            loggedInPresenter.SearchUser();
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {
            loggedInPresenter.SearchUser();
        }

        private void vScrollBarPosts_ValueChanged(object sender, EventArgs e)
        {
            loggedInPresenter.ChangePost();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            loggedInPresenter.NewPost();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            loggedInPresenter.EditPost();
        }

        private void buttonEdit_MouseClick(object sender, MouseEventArgs e)
        {
            loggedInPresenter.EditPost();
        }
    }
}

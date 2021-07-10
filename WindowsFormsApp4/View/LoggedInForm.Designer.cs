
namespace WindowsFormsApp4.View
{
    partial class LoggedInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.vScrollBarPosts = new System.Windows.Forms.VScrollBar();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxNewPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMyPage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.textBoxPost);
            this.panel1.Controls.Add(this.labelAuthor);
            this.panel1.Controls.Add(this.vScrollBarPosts);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 212);
            this.panel1.TabIndex = 1;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(225, 7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(34, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            this.buttonEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonEdit_MouseClick);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPost.Location = new System.Drawing.Point(3, 35);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ReadOnly = true;
            this.textBoxPost.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxPost.Size = new System.Drawing.Size(257, 177);
            this.textBoxPost.TabIndex = 3;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.Location = new System.Drawing.Point(3, 3);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(159, 29);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Author name";
            // 
            // vScrollBarPosts
            // 
            this.vScrollBarPosts.LargeChange = 1;
            this.vScrollBarPosts.Location = new System.Drawing.Point(263, 0);
            this.vScrollBarPosts.Maximum = 1;
            this.vScrollBarPosts.Name = "vScrollBarPosts";
            this.vScrollBarPosts.Size = new System.Drawing.Size(17, 212);
            this.vScrollBarPosts.TabIndex = 0;
            this.vScrollBarPosts.Value = 1;
            this.vScrollBarPosts.ValueChanged += new System.EventHandler(this.vScrollBarPosts_ValueChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(216, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(61, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseClick);
            // 
            // textBoxNewPost
            // 
            this.textBoxNewPost.Location = new System.Drawing.Point(0, 236);
            this.textBoxNewPost.Multiline = true;
            this.textBoxNewPost.Name = "textBoxNewPost";
            this.textBoxNewPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNewPost.Size = new System.Drawing.Size(246, 86);
            this.textBoxNewPost.TabIndex = 4;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(244, 236);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(36, 86);
            this.buttonPost.TabIndex = 5;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(86, 0);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(130, 23);
            this.SearchTextBox.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(0, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMyPage
            // 
            this.buttonMyPage.Location = new System.Drawing.Point(31, 0);
            this.buttonMyPage.Name = "buttonMyPage";
            this.buttonMyPage.Size = new System.Drawing.Size(56, 23);
            this.buttonMyPage.TabIndex = 7;
            this.buttonMyPage.Text = "My page";
            this.buttonMyPage.UseVisualStyleBackColor = true;
            this.buttonMyPage.Click += new System.EventHandler(this.buttonMyPage_Click);
            // 
            // LoggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 323);
            this.Controls.Add(this.buttonMyPage);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxNewPost);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoggedInForm";
            this.Text = "Logged in";
            this.Load += new System.EventHandler(this.LoggedInForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.VScrollBar vScrollBarPosts;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxNewPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMyPage;
    }
}
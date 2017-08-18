using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CardMatch.UI
{
    partial class windowLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowLogin));
            this.containerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.containerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // containerLayout
            // 
            this.containerLayout.ColumnCount = 2;
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.containerLayout.Controls.Add(this.textBoxUserName, 1, 0);
            this.containerLayout.Controls.Add(this.labelUserName, 0, 0);
            this.containerLayout.Controls.Add(this.labelPassword, 0, 1);
            this.containerLayout.Controls.Add(this.textBoxPassword, 1, 1);
            this.containerLayout.Location = new System.Drawing.Point(42, 147);
            this.containerLayout.Name = "containerLayout";
            this.containerLayout.RowCount = 2;
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerLayout.Size = new System.Drawing.Size(230, 53);
            this.containerLayout.TabIndex = 0;
            this.containerLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(79, 3);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(148, 20);
            this.textBoxUserName.TabIndex = 1;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(3, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(43, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Usuario";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(3, 26);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Contraseña";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(79, 29);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(148, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(197, 207);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 34);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Ingresar";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // imgLogin
            // 
            this.imgLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogin.ErrorImage = null;
            this.imgLogin.ImageLocation = "..\\\\Debug\\\\imgs\\\\8biticon.jpg";
            this.imgLogin.Location = new System.Drawing.Point(122, 39);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(100, 100);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogin.TabIndex = 2;
            this.imgLogin.TabStop = false;
            this.imgLogin.WaitOnLoad = true;
            this.imgLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Location = new System.Drawing.Point(39, 218);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(60, 13);
            this.linkLabelRegister.TabIndex = 3;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Registrarse";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // windowLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 295);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.imgLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.containerLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "windowLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar - Juego de Pares";
            this.Load += new System.EventHandler(this.windowLogin_Load);
            this.containerLayout.ResumeLayout(false);
            this.containerLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel containerLayout;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
    }
}
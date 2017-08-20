namespace MatchPairGame
{
    partial class RegisterForm
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
            this.layoutregisterform = new System.Windows.Forms.TableLayoutPanel();
            this.contregisterform = new System.Windows.Forms.Label();
            this.nombreregisterform = new System.Windows.Forms.Label();
            this.apellidoregisterform = new System.Windows.Forms.Label();
            this.bdregisterform = new System.Windows.Forms.Label();
            this.emailregisterform = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.usuarioregisterform = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonCancelRegister = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.layoutregisterform.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutregisterform
            // 
            this.layoutregisterform.ColumnCount = 2;
            this.layoutregisterform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.49462F));
            this.layoutregisterform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.50538F));
            this.layoutregisterform.Controls.Add(this.contregisterform, 0, 1);
            this.layoutregisterform.Controls.Add(this.nombreregisterform, 0, 2);
            this.layoutregisterform.Controls.Add(this.apellidoregisterform, 0, 3);
            this.layoutregisterform.Controls.Add(this.bdregisterform, 0, 4);
            this.layoutregisterform.Controls.Add(this.emailregisterform, 0, 5);
            this.layoutregisterform.Controls.Add(this.textBoxPassword, 1, 1);
            this.layoutregisterform.Controls.Add(this.textBoxName, 1, 2);
            this.layoutregisterform.Controls.Add(this.textBoxLastName, 1, 3);
            this.layoutregisterform.Controls.Add(this.textBirthDate, 1, 4);
            this.layoutregisterform.Controls.Add(this.textBoxEmail, 1, 5);
            this.layoutregisterform.Controls.Add(this.usuarioregisterform, 0, 0);
            this.layoutregisterform.Controls.Add(this.textBoxUserName, 1, 0);
            this.layoutregisterform.Location = new System.Drawing.Point(108, 35);
            this.layoutregisterform.Name = "layoutregisterform";
            this.layoutregisterform.RowCount = 6;
            this.layoutregisterform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutregisterform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutregisterform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.layoutregisterform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.layoutregisterform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.layoutregisterform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.layoutregisterform.Size = new System.Drawing.Size(317, 379);
            this.layoutregisterform.TabIndex = 0;
            this.layoutregisterform.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // contregisterform
            // 
            this.contregisterform.AutoSize = true;
            this.contregisterform.Location = new System.Drawing.Point(3, 89);
            this.contregisterform.Name = "contregisterform";
            this.contregisterform.Size = new System.Drawing.Size(61, 13);
            this.contregisterform.TabIndex = 1;
            this.contregisterform.Text = "Contraseña";
            // 
            // nombreregisterform
            // 
            this.nombreregisterform.AutoSize = true;
            this.nombreregisterform.Location = new System.Drawing.Point(3, 178);
            this.nombreregisterform.Name = "nombreregisterform";
            this.nombreregisterform.Size = new System.Drawing.Size(44, 13);
            this.nombreregisterform.TabIndex = 2;
            this.nombreregisterform.Text = "Nombre";
            // 
            // apellidoregisterform
            // 
            this.apellidoregisterform.AutoSize = true;
            this.apellidoregisterform.Location = new System.Drawing.Point(3, 225);
            this.apellidoregisterform.Name = "apellidoregisterform";
            this.apellidoregisterform.Size = new System.Drawing.Size(44, 13);
            this.apellidoregisterform.TabIndex = 3;
            this.apellidoregisterform.Text = "Apellido";
            // 
            // bdregisterform
            // 
            this.bdregisterform.AutoSize = true;
            this.bdregisterform.Location = new System.Drawing.Point(3, 273);
            this.bdregisterform.Name = "bdregisterform";
            this.bdregisterform.Size = new System.Drawing.Size(58, 26);
            this.bdregisterform.TabIndex = 4;
            this.bdregisterform.Text = "Fecha de nacimiento";
            // 
            // emailregisterform
            // 
            this.emailregisterform.AutoSize = true;
            this.emailregisterform.Location = new System.Drawing.Point(3, 327);
            this.emailregisterform.Name = "emailregisterform";
            this.emailregisterform.Size = new System.Drawing.Size(59, 26);
            this.emailregisterform.TabIndex = 5;
            this.emailregisterform.Text = "Correo electronico";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(93, 92);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(221, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(93, 181);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(221, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(93, 228);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(221, 20);
            this.textBoxLastName.TabIndex = 11;
            // 
            // textBirthDate
            // 
            this.textBirthDate.Location = new System.Drawing.Point(93, 276);
            this.textBirthDate.Name = "textBirthDate";
            this.textBirthDate.Size = new System.Drawing.Size(221, 20);
            this.textBirthDate.TabIndex = 12;
            this.textBirthDate.TextChanged += new System.EventHandler(this.textBirthDate_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(93, 330);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(221, 20);
            this.textBoxEmail.TabIndex = 13;
            // 
            // usuarioregisterform
            // 
            this.usuarioregisterform.AutoSize = true;
            this.usuarioregisterform.Location = new System.Drawing.Point(3, 0);
            this.usuarioregisterform.Name = "usuarioregisterform";
            this.usuarioregisterform.Size = new System.Drawing.Size(43, 13);
            this.usuarioregisterform.TabIndex = 0;
            this.usuarioregisterform.Text = "Usuario";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(93, 3);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(221, 20);
            this.textBoxUserName.TabIndex = 8;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCancelRegister
            // 
            this.buttonCancelRegister.Location = new System.Drawing.Point(281, 429);
            this.buttonCancelRegister.Name = "buttonCancelRegister";
            this.buttonCancelRegister.Size = new System.Drawing.Size(75, 41);
            this.buttonCancelRegister.TabIndex = 2;
            this.buttonCancelRegister.Text = "Cancelar";
            this.buttonCancelRegister.UseVisualStyleBackColor = true;
            this.buttonCancelRegister.Click += new System.EventHandler(this.buttonCancelRegister_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(160, 429);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 41);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Registrar";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(569, 486);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonCancelRegister);
            this.Controls.Add(this.layoutregisterform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerform";
            this.layoutregisterform.ResumeLayout(false);
            this.layoutregisterform.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutregisterform;
        private System.Windows.Forms.Label contregisterform;
        private System.Windows.Forms.Label nombreregisterform;
        private System.Windows.Forms.Label apellidoregisterform;
        private System.Windows.Forms.Label bdregisterform;
        private System.Windows.Forms.Label emailregisterform;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBirthDate;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label usuarioregisterform;
        private System.Windows.Forms.Button buttonCancelRegister;
        private System.Windows.Forms.Button buttonRegister;
    }
}
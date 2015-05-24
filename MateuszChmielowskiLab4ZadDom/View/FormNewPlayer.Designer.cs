namespace MateuszChmielowskiLab4ZadDom
{
    partial class FormNewPlayer
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonCreatePlayer = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelWrongLogin = new System.Windows.Forms.Label();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.labelDifferentPasswords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(133, 111);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(37, 16);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(136, 130);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(186, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // buttonCreatePlayer
            // 
            this.buttonCreatePlayer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreatePlayer.Location = new System.Drawing.Point(136, 246);
            this.buttonCreatePlayer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCreatePlayer.Name = "buttonCreatePlayer";
            this.buttonCreatePlayer.Size = new System.Drawing.Size(186, 31);
            this.buttonCreatePlayer.TabIndex = 3;
            this.buttonCreatePlayer.Text = "Utwórz konto";
            this.buttonCreatePlayer.UseVisualStyleBackColor = true;
            this.buttonCreatePlayer.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(136, 174);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(186, 22);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(133, 155);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(38, 16);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Hasło:";
            // 
            // labelWrongLogin
            // 
            this.labelWrongLogin.AutoSize = true;
            this.labelWrongLogin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWrongLogin.ForeColor = System.Drawing.Color.Red;
            this.labelWrongLogin.Location = new System.Drawing.Point(328, 133);
            this.labelWrongLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWrongLogin.Name = "labelWrongLogin";
            this.labelWrongLogin.Size = new System.Drawing.Size(67, 16);
            this.labelWrongLogin.TabIndex = 0;
            this.labelWrongLogin.Text = "Login zajęty.";
            this.labelWrongLogin.Visible = false;
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRepeatPassword.Location = new System.Drawing.Point(133, 199);
            this.labelRepeatPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(38, 16);
            this.labelRepeatPassword.TabIndex = 0;
            this.labelRepeatPassword.Text = "Hasło:";
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(136, 218);
            this.textBoxRepeatPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.PasswordChar = '*';
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(186, 22);
            this.textBoxRepeatPassword.TabIndex = 2;
            this.textBoxRepeatPassword.UseSystemPasswordChar = true;
            // 
            // labelDifferentPasswords
            // 
            this.labelDifferentPasswords.AutoSize = true;
            this.labelDifferentPasswords.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDifferentPasswords.ForeColor = System.Drawing.Color.Red;
            this.labelDifferentPasswords.Location = new System.Drawing.Point(328, 221);
            this.labelDifferentPasswords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDifferentPasswords.Name = "labelDifferentPasswords";
            this.labelDifferentPasswords.Size = new System.Drawing.Size(106, 16);
            this.labelDifferentPasswords.TabIndex = 0;
            this.labelDifferentPasswords.Text = "Niejednakowe hasła.";
            this.labelDifferentPasswords.Visible = false;
            // 
            // FormNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 410);
            this.Controls.Add(this.buttonCreatePlayer);
            this.Controls.Add(this.textBoxRepeatPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelRepeatPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelDifferentPasswords);
            this.Controls.Add(this.labelWrongLogin);
            this.Controls.Add(this.labelLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormNewPlayer";
            this.Text = "Nowe konto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonCreatePlayer;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelWrongLogin;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label labelDifferentPasswords;
    }
}
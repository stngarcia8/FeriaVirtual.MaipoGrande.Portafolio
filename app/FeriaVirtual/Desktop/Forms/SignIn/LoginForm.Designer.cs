using System.Windows.Forms;
using System.Drawing;
using MetroFramework.Controls;
using MetroFramework;

namespace FeriaVirtual.App.Desktop.Forms.SignIn
{
    partial class LoginForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.UsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.AceptFormButton = new MetroFramework.Controls.MetroButton();
            this.CancelFormButton = new MetroFramework.Controls.MetroButton();
            this.FormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(150, 75);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(127, 19);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Nombre de usuario:";
            // 
            // UsernameTextBox
            // 
            // 
            // 
            // 
            this.UsernameTextBox.CustomButton.Image = null;
            this.UsernameTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.UsernameTextBox.CustomButton.Name = "";
            this.UsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTextBox.CustomButton.TabIndex = 1;
            this.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTextBox.CustomButton.UseSelectable = true;
            this.UsernameTextBox.CustomButton.Visible = false;
            this.UsernameTextBox.Lines = new string[0];
            this.UsernameTextBox.Location = new System.Drawing.Point(150, 100);
            this.UsernameTextBox.MaxLength = 50;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.SelectionLength = 0;
            this.UsernameTextBox.SelectionStart = 0;
            this.UsernameTextBox.ShortcutsEnabled = true;
            this.UsernameTextBox.ShowClearButton = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(250, 23);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.UseSelectable = true;
            this.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(150, 175);
            this.PasswordTextBox.MaxLength = 50;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.ShowClearButton = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 23);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(150, 150);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 19);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Contraseña:";
            // 
            // AceptFormButton
            // 
            this.AceptFormButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AceptFormButton.Location = new System.Drawing.Point(225, 225);
            this.AceptFormButton.Name = "AceptFormButton";
            this.AceptFormButton.Size = new System.Drawing.Size(75, 23);
            this.AceptFormButton.TabIndex = 5;
            this.AceptFormButton.Text = "Aceptar";
            this.AceptFormButton.UseSelectable = true;
            this.AceptFormButton.Click += new System.EventHandler(this.AceptFormButton_Click);
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelFormButton.Location = new System.Drawing.Point(325, 225);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(75, 23);
            this.CancelFormButton.TabIndex = 6;
            this.CancelFormButton.Text = "Cancelar";
            this.CancelFormButton.UseSelectable = true;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // FormPictureBox
            // 
            this.FormPictureBox.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.form_login;
            this.FormPictureBox.Location = new System.Drawing.Point(0, 75);
            this.FormPictureBox.Name = "FormPictureBox";
            this.FormPictureBox.Size = new System.Drawing.Size(125, 125);
            this.FormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormPictureBox.TabIndex = 0;
            this.FormPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.AceptFormButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelFormButton;
            this.ClientSize = new System.Drawing.Size(424, 274);
            this.Controls.Add(this.CancelFormButton);
            this.Controls.Add(this.AceptFormButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.FormPictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(29, 66, 29, 22);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FormPictureBox;
        private MetroFramework.Controls.MetroLabel UsernameLabel;
        private MetroFramework.Controls.MetroTextBox UsernameTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroButton AceptFormButton;
        private MetroFramework.Controls.MetroButton CancelFormButton;
    }
}
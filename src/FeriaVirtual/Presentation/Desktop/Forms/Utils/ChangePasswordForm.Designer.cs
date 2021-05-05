
namespace FeriaVirtual.App.Desktop.Forms.Utils
{
    partial class ChangePasswordForm
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
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.FormPictureBox = new System.Windows.Forms.PictureBox();
            this.NewPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.NewPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ReNewPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ReNewPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.FormChangePasswordButton = new MetroFramework.Controls.MetroButton();
            this.FormCancelButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPictureBox
            // 
            this.FormPictureBox.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.form_password;
            this.FormPictureBox.Location = new System.Drawing.Point(25, 75);
            this.FormPictureBox.Name = "FormPictureBox";
            this.FormPictureBox.Size = new System.Drawing.Size(125, 125);
            this.FormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormPictureBox.TabIndex = 0;
            this.FormPictureBox.TabStop = false;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(175, 75);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(116, 19);
            this.NewPasswordLabel.TabIndex = 1;
            this.NewPasswordLabel.Text = "Nueva contraseña:";
            // 
            // NewPasswordTextBox
            // 
            // 
            // 
            // 
            this.NewPasswordTextBox.CustomButton.Image = null;
            this.NewPasswordTextBox.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.NewPasswordTextBox.CustomButton.Name = "";
            this.NewPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NewPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewPasswordTextBox.CustomButton.TabIndex = 1;
            this.NewPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewPasswordTextBox.CustomButton.UseSelectable = true;
            this.NewPasswordTextBox.CustomButton.Visible = false;
            this.NewPasswordTextBox.Lines = new string[0];
            this.NewPasswordTextBox.Location = new System.Drawing.Point(350, 75);
            this.NewPasswordTextBox.MaxLength = 50;
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '●';
            this.NewPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewPasswordTextBox.SelectedText = "";
            this.NewPasswordTextBox.SelectionLength = 0;
            this.NewPasswordTextBox.SelectionStart = 0;
            this.NewPasswordTextBox.ShortcutsEnabled = true;
            this.NewPasswordTextBox.ShowClearButton = true;
            this.NewPasswordTextBox.Size = new System.Drawing.Size(300, 23);
            this.NewPasswordTextBox.TabIndex = 2;
            this.NewPasswordTextBox.UseSelectable = true;
            this.NewPasswordTextBox.UseSystemPasswordChar = true;
            this.NewPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ReNewPasswordTextBox
            // 
            // 
            // 
            // 
            this.ReNewPasswordTextBox.CustomButton.Image = null;
            this.ReNewPasswordTextBox.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.ReNewPasswordTextBox.CustomButton.Name = "";
            this.ReNewPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ReNewPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ReNewPasswordTextBox.CustomButton.TabIndex = 1;
            this.ReNewPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ReNewPasswordTextBox.CustomButton.UseSelectable = true;
            this.ReNewPasswordTextBox.CustomButton.Visible = false;
            this.ReNewPasswordTextBox.Lines = new string[0];
            this.ReNewPasswordTextBox.Location = new System.Drawing.Point(350, 125);
            this.ReNewPasswordTextBox.MaxLength = 50;
            this.ReNewPasswordTextBox.Name = "ReNewPasswordTextBox";
            this.ReNewPasswordTextBox.PasswordChar = '●';
            this.ReNewPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReNewPasswordTextBox.SelectedText = "";
            this.ReNewPasswordTextBox.SelectionLength = 0;
            this.ReNewPasswordTextBox.SelectionStart = 0;
            this.ReNewPasswordTextBox.ShortcutsEnabled = true;
            this.ReNewPasswordTextBox.ShowClearButton = true;
            this.ReNewPasswordTextBox.Size = new System.Drawing.Size(300, 23);
            this.ReNewPasswordTextBox.TabIndex = 4;
            this.ReNewPasswordTextBox.UseSelectable = true;
            this.ReNewPasswordTextBox.UseSystemPasswordChar = true;
            this.ReNewPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ReNewPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ReNewPasswordLabel
            // 
            this.ReNewPasswordLabel.AutoSize = true;
            this.ReNewPasswordLabel.Location = new System.Drawing.Point(175, 125);
            this.ReNewPasswordLabel.Name = "ReNewPasswordLabel";
            this.ReNewPasswordLabel.Size = new System.Drawing.Size(166, 19);
            this.ReNewPasswordLabel.TabIndex = 3;
            this.ReNewPasswordLabel.Text = "rescriba Nueva contraseña:";
            // 
            // FormChangePasswordButton
            // 
            this.FormChangePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FormChangePasswordButton.Location = new System.Drawing.Point(350, 175);
            this.FormChangePasswordButton.Name = "FormChangePasswordButton";
            this.FormChangePasswordButton.Size = new System.Drawing.Size(175, 23);
            this.FormChangePasswordButton.TabIndex = 5;
            this.FormChangePasswordButton.Text = "&Cambiar contraseña";
            this.FormChangePasswordButton.UseSelectable = true;
            this.FormChangePasswordButton.Click += new System.EventHandler(this.FormChangePasswordButton_Click);
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.Location = new System.Drawing.Point(550, 175);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(100, 23);
            this.FormCancelButton.TabIndex = 6;
            this.FormCancelButton.Text = "Cancelar";
            this.FormCancelButton.UseSelectable = true;
            this.FormCancelButton.Click += new System.EventHandler(this.FormCancelButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.FormChangePasswordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.FormCancelButton;
            this.ClientSize = new System.Drawing.Size(686, 241);
            this.ControlBox = false;
            this.Controls.Add(this.FormCancelButton);
            this.Controls.Add(this.FormChangePasswordButton);
            this.Controls.Add(this.ReNewPasswordTextBox);
            this.Controls.Add(this.ReNewPasswordLabel);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.FormPictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.Padding = new System.Windows.Forms.Padding(26, 60, 26, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cambio de contraseña";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FormPictureBox;
        private MetroFramework.Controls.MetroLabel NewPasswordLabel;
        private MetroFramework.Controls.MetroTextBox NewPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox ReNewPasswordTextBox;
        private MetroFramework.Controls.MetroLabel ReNewPasswordLabel;
        private MetroFramework.Controls.MetroButton FormChangePasswordButton;
        private MetroFramework.Controls.MetroButton FormCancelButton;
    }
}
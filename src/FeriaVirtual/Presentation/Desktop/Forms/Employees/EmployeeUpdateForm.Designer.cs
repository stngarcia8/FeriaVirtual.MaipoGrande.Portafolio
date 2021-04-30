
namespace FeriaVirtual.App.Desktop.Forms.Employees
{
    partial class EmployeeUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUpdateForm));
            this.CancelFormButton = new MetroFramework.Controls.MetroButton();
            this.UpdateFormButton = new MetroFramework.Controls.MetroButton();
            this.UsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.EmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EmailLabel = new MetroFramework.Controls.MetroLabel();
            this.ProfileComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ProfileLabel = new MetroFramework.Controls.MetroLabel();
            this.CredentialDataTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.RutTextBox = new MetroFramework.Controls.MetroTextBox();
            this.RutLabel = new MetroFramework.Controls.MetroLabel();
            this.LastnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LastnameLabel = new MetroFramework.Controls.MetroLabel();
            this.FirstnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FirstnameLabel = new MetroFramework.Controls.MetroLabel();
            this.PersonalDataTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.FormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelFormButton.Location = new System.Drawing.Point(500, 325);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(100, 23);
            this.CancelFormButton.TabIndex = 39;
            this.CancelFormButton.Text = "Cancelar";
            this.CancelFormButton.UseSelectable = true;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // UpdateFormButton
            // 
            this.UpdateFormButton.Location = new System.Drawing.Point(350, 325);
            this.UpdateFormButton.Name = "UpdateFormButton";
            this.UpdateFormButton.Size = new System.Drawing.Size(125, 23);
            this.UpdateFormButton.TabIndex = 38;
            this.UpdateFormButton.Text = "&Actualizar empleado";
            this.UpdateFormButton.UseSelectable = true;
            this.UpdateFormButton.Click += new System.EventHandler(this.UpdateFormButton_Click);
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
            this.UsernameTextBox.Location = new System.Drawing.Point(350, 276);
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
            this.UsernameTextBox.TabIndex = 34;
            this.UsernameTextBox.UseSelectable = true;
            this.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(200, 276);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(71, 19);
            this.UsernameLabel.TabIndex = 33;
            this.UsernameLabel.Text = "Username:";
            // 
            // EmailTextBox
            // 
            // 
            // 
            // 
            this.EmailTextBox.CustomButton.Image = null;
            this.EmailTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.EmailTextBox.CustomButton.Name = "";
            this.EmailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmailTextBox.CustomButton.TabIndex = 1;
            this.EmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmailTextBox.CustomButton.UseSelectable = true;
            this.EmailTextBox.CustomButton.Visible = false;
            this.EmailTextBox.Lines = new string[0];
            this.EmailTextBox.Location = new System.Drawing.Point(350, 251);
            this.EmailTextBox.MaxLength = 254;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.SelectionLength = 0;
            this.EmailTextBox.SelectionStart = 0;
            this.EmailTextBox.ShortcutsEnabled = true;
            this.EmailTextBox.ShowClearButton = true;
            this.EmailTextBox.Size = new System.Drawing.Size(250, 23);
            this.EmailTextBox.TabIndex = 32;
            this.EmailTextBox.UseSelectable = true;
            this.EmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(200, 251);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 19);
            this.EmailLabel.TabIndex = 31;
            this.EmailLabel.Text = "Email:";
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.ItemHeight = 23;
            this.ProfileComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Consultor"});
            this.ProfileComboBox.Location = new System.Drawing.Point(350, 226);
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(250, 29);
            this.ProfileComboBox.TabIndex = 30;
            this.ProfileComboBox.UseSelectable = true;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Location = new System.Drawing.Point(200, 226);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(41, 19);
            this.ProfileLabel.TabIndex = 29;
            this.ProfileLabel.Text = "Perfil:";
            // 
            // CredentialDataTitleLabel
            // 
            this.CredentialDataTitleLabel.AutoSize = true;
            this.CredentialDataTitleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CredentialDataTitleLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CredentialDataTitleLabel.Location = new System.Drawing.Point(200, 201);
            this.CredentialDataTitleLabel.Name = "CredentialDataTitleLabel";
            this.CredentialDataTitleLabel.Size = new System.Drawing.Size(234, 25);
            this.CredentialDataTitleLabel.TabIndex = 28;
            this.CredentialDataTitleLabel.Text = "Información de credencial";
            // 
            // RutTextBox
            // 
            this.RutTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.RutTextBox.CustomButton.Image = null;
            this.RutTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.RutTextBox.CustomButton.Name = "";
            this.RutTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RutTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RutTextBox.CustomButton.TabIndex = 1;
            this.RutTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RutTextBox.CustomButton.UseSelectable = true;
            this.RutTextBox.CustomButton.Visible = false;
            this.RutTextBox.Lines = new string[0];
            this.RutTextBox.Location = new System.Drawing.Point(350, 151);
            this.RutTextBox.MaxLength = 10;
            this.RutTextBox.Name = "RutTextBox";
            this.RutTextBox.PasswordChar = '\0';
            this.RutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RutTextBox.SelectedText = "";
            this.RutTextBox.SelectionLength = 0;
            this.RutTextBox.SelectionStart = 0;
            this.RutTextBox.ShortcutsEnabled = true;
            this.RutTextBox.ShowClearButton = true;
            this.RutTextBox.Size = new System.Drawing.Size(250, 23);
            this.RutTextBox.TabIndex = 27;
            this.RutTextBox.UseSelectable = true;
            this.RutTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RutTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RutLabel
            // 
            this.RutLabel.AutoSize = true;
            this.RutLabel.Location = new System.Drawing.Point(200, 151);
            this.RutLabel.Name = "RutLabel";
            this.RutLabel.Size = new System.Drawing.Size(31, 19);
            this.RutLabel.TabIndex = 26;
            this.RutLabel.Text = "Rut:";
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.LastnameTextBox.CustomButton.Image = null;
            this.LastnameTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.LastnameTextBox.CustomButton.Name = "";
            this.LastnameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LastnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LastnameTextBox.CustomButton.TabIndex = 1;
            this.LastnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LastnameTextBox.CustomButton.UseSelectable = true;
            this.LastnameTextBox.CustomButton.Visible = false;
            this.LastnameTextBox.Lines = new string[0];
            this.LastnameTextBox.Location = new System.Drawing.Point(350, 126);
            this.LastnameTextBox.MaxLength = 50;
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.PasswordChar = '\0';
            this.LastnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LastnameTextBox.SelectedText = "";
            this.LastnameTextBox.SelectionLength = 0;
            this.LastnameTextBox.SelectionStart = 0;
            this.LastnameTextBox.ShortcutsEnabled = true;
            this.LastnameTextBox.ShowClearButton = true;
            this.LastnameTextBox.Size = new System.Drawing.Size(250, 23);
            this.LastnameTextBox.TabIndex = 25;
            this.LastnameTextBox.UseSelectable = true;
            this.LastnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LastnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Location = new System.Drawing.Point(200, 126);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(66, 19);
            this.LastnameLabel.TabIndex = 24;
            this.LastnameLabel.Text = "Apellidos:";
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.FirstnameTextBox.CustomButton.Image = null;
            this.FirstnameTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.FirstnameTextBox.CustomButton.Name = "";
            this.FirstnameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FirstnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FirstnameTextBox.CustomButton.TabIndex = 1;
            this.FirstnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FirstnameTextBox.CustomButton.UseSelectable = true;
            this.FirstnameTextBox.CustomButton.Visible = false;
            this.FirstnameTextBox.Lines = new string[0];
            this.FirstnameTextBox.Location = new System.Drawing.Point(350, 101);
            this.FirstnameTextBox.MaxLength = 50;
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.PasswordChar = '\0';
            this.FirstnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FirstnameTextBox.SelectedText = "";
            this.FirstnameTextBox.SelectionLength = 0;
            this.FirstnameTextBox.SelectionStart = 0;
            this.FirstnameTextBox.ShortcutsEnabled = true;
            this.FirstnameTextBox.ShowClearButton = true;
            this.FirstnameTextBox.Size = new System.Drawing.Size(250, 23);
            this.FirstnameTextBox.TabIndex = 23;
            this.FirstnameTextBox.UseSelectable = true;
            this.FirstnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FirstnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Location = new System.Drawing.Point(200, 101);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(62, 19);
            this.FirstnameLabel.TabIndex = 22;
            this.FirstnameLabel.Text = "Nombre:";
            // 
            // PersonalDataTitleLabel
            // 
            this.PersonalDataTitleLabel.AutoSize = true;
            this.PersonalDataTitleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PersonalDataTitleLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PersonalDataTitleLabel.Location = new System.Drawing.Point(200, 76);
            this.PersonalDataTitleLabel.Name = "PersonalDataTitleLabel";
            this.PersonalDataTitleLabel.Size = new System.Drawing.Size(157, 25);
            this.PersonalDataTitleLabel.TabIndex = 21;
            this.PersonalDataTitleLabel.Text = "Datos personales";
            // 
            // FormPictureBox
            // 
            this.FormPictureBox.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.employee_form;
            this.FormPictureBox.Location = new System.Drawing.Point(50, 76);
            this.FormPictureBox.Name = "FormPictureBox";
            this.FormPictureBox.Size = new System.Drawing.Size(100, 100);
            this.FormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormPictureBox.TabIndex = 20;
            this.FormPictureBox.TabStop = false;
            // 
            // EmployeeUpdateForm
            // 
            this.AcceptButton = this.UpdateFormButton;
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.CancelFormButton;
            this.ClientSize = new System.Drawing.Size(644, 388);
            this.ControlBox = false;
            this.Controls.Add(this.CancelFormButton);
            this.Controls.Add(this.UpdateFormButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ProfileComboBox);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.CredentialDataTitleLabel);
            this.Controls.Add(this.RutTextBox);
            this.Controls.Add(this.RutLabel);
            this.Controls.Add(this.LastnameTextBox);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.FirstnameTextBox);
            this.Controls.Add(this.FirstnameLabel);
            this.Controls.Add(this.PersonalDataTitleLabel);
            this.Controls.Add(this.FormPictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeUpdateForm";
            this.Padding = new System.Windows.Forms.Padding(26, 60, 26, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Actualizar datos de empleado";
            this.Load += new System.EventHandler(this.EmployeeUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton CancelFormButton;
        private MetroFramework.Controls.MetroButton UpdateFormButton;
        private MetroFramework.Controls.MetroTextBox UsernameTextBox;
        private MetroFramework.Controls.MetroLabel UsernameLabel;
        private MetroFramework.Controls.MetroTextBox EmailTextBox;
        private MetroFramework.Controls.MetroLabel EmailLabel;
        private MetroFramework.Controls.MetroComboBox ProfileComboBox;
        private MetroFramework.Controls.MetroLabel ProfileLabel;
        private MetroFramework.Controls.MetroLabel CredentialDataTitleLabel;
        private MetroFramework.Controls.MetroTextBox RutTextBox;
        private MetroFramework.Controls.MetroLabel RutLabel;
        private MetroFramework.Controls.MetroTextBox LastnameTextBox;
        private MetroFramework.Controls.MetroLabel LastnameLabel;
        private MetroFramework.Controls.MetroTextBox FirstnameTextBox;
        private MetroFramework.Controls.MetroLabel FirstnameLabel;
        private MetroFramework.Controls.MetroLabel PersonalDataTitleLabel;
        private System.Windows.Forms.PictureBox FormPictureBox;
    }
}
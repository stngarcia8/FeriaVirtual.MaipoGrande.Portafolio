
namespace FeriaVirtual.App.Desktop.Forms.Utils
{
    partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.FormPictureBox = new System.Windows.Forms.PictureBox();
            this.ListTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.RowsPerPageLabel = new MetroFramework.Controls.MetroLabel();
            this.RowsPerPageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ThemeLabel = new MetroFramework.Controls.MetroLabel();
            this.ThemeStyleLabel = new MetroFramework.Controls.MetroLabel();
            this.ThemeStyleComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ThemeTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.ThemeLightRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.ThemeDarkRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.FormSaveButton = new MetroFramework.Controls.MetroButton();
            this.FormCancelButton = new MetroFramework.Controls.MetroButton();
            this.FormApplyButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPictureBox
            // 
            this.FormPictureBox.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.option_preferences;
            this.FormPictureBox.Location = new System.Drawing.Point(25, 75);
            this.FormPictureBox.Name = "FormPictureBox";
            this.FormPictureBox.Size = new System.Drawing.Size(125, 125);
            this.FormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormPictureBox.TabIndex = 0;
            this.FormPictureBox.TabStop = false;
            // 
            // ListTitleLabel
            // 
            this.ListTitleLabel.AutoSize = true;
            this.ListTitleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ListTitleLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ListTitleLabel.Location = new System.Drawing.Point(175, 75);
            this.ListTitleLabel.Name = "ListTitleLabel";
            this.ListTitleLabel.Size = new System.Drawing.Size(252, 25);
            this.ListTitleLabel.TabIndex = 1;
            this.ListTitleLabel.Text = "Opciones para lista de datos";
            // 
            // RowsPerPageLabel
            // 
            this.RowsPerPageLabel.AutoSize = true;
            this.RowsPerPageLabel.Location = new System.Drawing.Point(175, 100);
            this.RowsPerPageLabel.Name = "RowsPerPageLabel";
            this.RowsPerPageLabel.Size = new System.Drawing.Size(134, 19);
            this.RowsPerPageLabel.TabIndex = 2;
            this.RowsPerPageLabel.Text = "Registros por página:";
            // 
            // RowsPerPageTextBox
            // 
            // 
            // 
            // 
            this.RowsPerPageTextBox.CustomButton.Image = null;
            this.RowsPerPageTextBox.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.RowsPerPageTextBox.CustomButton.Name = "";
            this.RowsPerPageTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RowsPerPageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RowsPerPageTextBox.CustomButton.TabIndex = 1;
            this.RowsPerPageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RowsPerPageTextBox.CustomButton.UseSelectable = true;
            this.RowsPerPageTextBox.CustomButton.Visible = false;
            this.RowsPerPageTextBox.Lines = new string[0];
            this.RowsPerPageTextBox.Location = new System.Drawing.Point(350, 100);
            this.RowsPerPageTextBox.MaxLength = 2;
            this.RowsPerPageTextBox.Name = "RowsPerPageTextBox";
            this.RowsPerPageTextBox.PasswordChar = '\0';
            this.RowsPerPageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RowsPerPageTextBox.SelectedText = "";
            this.RowsPerPageTextBox.SelectionLength = 0;
            this.RowsPerPageTextBox.SelectionStart = 0;
            this.RowsPerPageTextBox.ShortcutsEnabled = true;
            this.RowsPerPageTextBox.Size = new System.Drawing.Size(150, 23);
            this.RowsPerPageTextBox.TabIndex = 3;
            this.RowsPerPageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RowsPerPageTextBox.UseSelectable = true;
            this.RowsPerPageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RowsPerPageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ThemeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ThemeLabel.Location = new System.Drawing.Point(175, 150);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(210, 25);
            this.ThemeLabel.TabIndex = 4;
            this.ThemeLabel.Text = "Thema y estilo de color";
            // 
            // ThemeStyleLabel
            // 
            this.ThemeStyleLabel.AutoSize = true;
            this.ThemeStyleLabel.Location = new System.Drawing.Point(175, 175);
            this.ThemeStyleLabel.Name = "ThemeStyleLabel";
            this.ThemeStyleLabel.Size = new System.Drawing.Size(119, 19);
            this.ThemeStyleLabel.TabIndex = 5;
            this.ThemeStyleLabel.Text = "Esquema de color:";
            // 
            // ThemeStyleComboBox
            // 
            this.ThemeStyleComboBox.FormattingEnabled = true;
            this.ThemeStyleComboBox.ItemHeight = 23;
            this.ThemeStyleComboBox.Location = new System.Drawing.Point(325, 175);
            this.ThemeStyleComboBox.Name = "ThemeStyleComboBox";
            this.ThemeStyleComboBox.Size = new System.Drawing.Size(175, 29);
            this.ThemeStyleComboBox.TabIndex = 6;
            this.ThemeStyleComboBox.UseSelectable = true;
            this.ThemeStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeStyleComboBox_SelectedIndexChanged);
            // 
            // ThemeTypeLabel
            // 
            this.ThemeTypeLabel.AutoSize = true;
            this.ThemeTypeLabel.Location = new System.Drawing.Point(175, 225);
            this.ThemeTypeLabel.Name = "ThemeTypeLabel";
            this.ThemeTypeLabel.Size = new System.Drawing.Size(106, 19);
            this.ThemeTypeLabel.TabIndex = 7;
            this.ThemeTypeLabel.Text = "Thema a utilizar:";
            // 
            // ThemeLightRadioButton
            // 
            this.ThemeLightRadioButton.AutoSize = true;
            this.ThemeLightRadioButton.Location = new System.Drawing.Point(325, 225);
            this.ThemeLightRadioButton.Name = "ThemeLightRadioButton";
            this.ThemeLightRadioButton.Size = new System.Drawing.Size(80, 15);
            this.ThemeLightRadioButton.TabIndex = 8;
            this.ThemeLightRadioButton.Text = "Tema claro";
            this.ThemeLightRadioButton.UseSelectable = true;
            this.ThemeLightRadioButton.Click += new System.EventHandler(this.ThemeLightRadioButton_Click);
            // 
            // ThemeDarkRadioButton
            // 
            this.ThemeDarkRadioButton.AutoSize = true;
            this.ThemeDarkRadioButton.Location = new System.Drawing.Point(325, 250);
            this.ThemeDarkRadioButton.Name = "ThemeDarkRadioButton";
            this.ThemeDarkRadioButton.Size = new System.Drawing.Size(90, 15);
            this.ThemeDarkRadioButton.TabIndex = 9;
            this.ThemeDarkRadioButton.Text = "Tema oscuro";
            this.ThemeDarkRadioButton.UseSelectable = true;
            this.ThemeDarkRadioButton.Click += new System.EventHandler(this.ThemeDarkRadioButton_Click);
            // 
            // FormSaveButton
            // 
            this.FormSaveButton.Location = new System.Drawing.Point(175, 300);
            this.FormSaveButton.Name = "FormSaveButton";
            this.FormSaveButton.Size = new System.Drawing.Size(125, 23);
            this.FormSaveButton.TabIndex = 10;
            this.FormSaveButton.Text = "Grabar cambios";
            this.FormSaveButton.UseSelectable = true;
            this.FormSaveButton.Click += new System.EventHandler(this.FormSaveButton_Click);
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.Location = new System.Drawing.Point(325, 300);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.FormCancelButton.TabIndex = 11;
            this.FormCancelButton.Text = "Cancelar";
            this.FormCancelButton.UseSelectable = true;
            this.FormCancelButton.Click += new System.EventHandler(this.FormCancelButton_Click);
            // 
            // FormApplyButton
            // 
            this.FormApplyButton.Location = new System.Drawing.Point(425, 300);
            this.FormApplyButton.Name = "FormApplyButton";
            this.FormApplyButton.Size = new System.Drawing.Size(75, 23);
            this.FormApplyButton.TabIndex = 12;
            this.FormApplyButton.Text = "Aplicar";
            this.FormApplyButton.UseSelectable = true;
            this.FormApplyButton.Click += new System.EventHandler(this.FormApplyButton_Click);
            // 
            // PreferencesForm
            // 
            this.AcceptButton = this.FormSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.FormCancelButton;
            this.ClientSize = new System.Drawing.Size(544, 352);
            this.ControlBox = false;
            this.Controls.Add(this.FormApplyButton);
            this.Controls.Add(this.FormCancelButton);
            this.Controls.Add(this.FormSaveButton);
            this.Controls.Add(this.ThemeDarkRadioButton);
            this.Controls.Add(this.ThemeLightRadioButton);
            this.Controls.Add(this.ThemeTypeLabel);
            this.Controls.Add(this.ThemeStyleComboBox);
            this.Controls.Add(this.ThemeStyleLabel);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.RowsPerPageTextBox);
            this.Controls.Add(this.RowsPerPageLabel);
            this.Controls.Add(this.ListTitleLabel);
            this.Controls.Add(this.FormPictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
            this.Padding = new System.Windows.Forms.Padding(26, 60, 26, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Preferencias";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FormPictureBox;
        private MetroFramework.Controls.MetroLabel ListTitleLabel;
        private MetroFramework.Controls.MetroLabel RowsPerPageLabel;
        private MetroFramework.Controls.MetroTextBox RowsPerPageTextBox;
        private MetroFramework.Controls.MetroLabel ThemeLabel;
        private MetroFramework.Controls.MetroLabel ThemeStyleLabel;
        private MetroFramework.Controls.MetroComboBox ThemeStyleComboBox;
        private MetroFramework.Controls.MetroLabel ThemeTypeLabel;
        private MetroFramework.Controls.MetroRadioButton ThemeLightRadioButton;
        private MetroFramework.Controls.MetroRadioButton ThemeDarkRadioButton;
        private MetroFramework.Controls.MetroButton FormSaveButton;
        private MetroFramework.Controls.MetroButton FormCancelButton;
        private MetroFramework.Controls.MetroButton FormApplyButton;
    }
}
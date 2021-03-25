
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.FormPictureBox = new System.Windows.Forms.PictureBox();
            this.PaginationTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PaginationLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PaginationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VisualizationTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.VisualizationSchemaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AceptFormButton = new MaterialSkin.Controls.MaterialButton();
            this.CancelFormButton = new MaterialSkin.Controls.MaterialButton();
            this.ApplyFormButton = new MaterialSkin.Controls.MaterialButton();
            this.VisualizationSchemaComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.VisualizationDarkModeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaginationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPictureBox
            // 
            this.FormPictureBox.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.form_preferences;
            this.FormPictureBox.Location = new System.Drawing.Point(25, 75);
            this.FormPictureBox.Name = "FormPictureBox";
            this.FormPictureBox.Size = new System.Drawing.Size(100, 100);
            this.FormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormPictureBox.TabIndex = 0;
            this.FormPictureBox.TabStop = false;
            // 
            // PaginationTitleLabel
            // 
            this.PaginationTitleLabel.AutoSize = true;
            this.PaginationTitleLabel.Depth = 0;
            this.PaginationTitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PaginationTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PaginationTitleLabel.Location = new System.Drawing.Point(150, 75);
            this.PaginationTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PaginationTitleLabel.Name = "PaginationTitleLabel";
            this.PaginationTitleLabel.Size = new System.Drawing.Size(85, 20);
            this.PaginationTitleLabel.TabIndex = 1;
            this.PaginationTitleLabel.Text = "Paginación.";
            // 
            // PaginationLabel
            // 
            this.PaginationLabel.Depth = 0;
            this.PaginationLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PaginationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PaginationLabel.Location = new System.Drawing.Point(150, 100);
            this.PaginationLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PaginationLabel.Name = "PaginationLabel";
            this.PaginationLabel.Size = new System.Drawing.Size(200, 50);
            this.PaginationLabel.TabIndex = 2;
            this.PaginationLabel.Text = "Cantidad de registros por página:";
            // 
            // PaginationNumericUpDown
            // 
            this.PaginationNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaginationNumericUpDown.Location = new System.Drawing.Point(350, 100);
            this.PaginationNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PaginationNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PaginationNumericUpDown.Name = "PaginationNumericUpDown";
            this.PaginationNumericUpDown.Size = new System.Drawing.Size(75, 27);
            this.PaginationNumericUpDown.TabIndex = 3;
            this.PaginationNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaginationNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // VisualizationTitleLabel
            // 
            this.VisualizationTitleLabel.AutoSize = true;
            this.VisualizationTitleLabel.Depth = 0;
            this.VisualizationTitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VisualizationTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VisualizationTitleLabel.Location = new System.Drawing.Point(150, 150);
            this.VisualizationTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.VisualizationTitleLabel.Name = "VisualizationTitleLabel";
            this.VisualizationTitleLabel.Size = new System.Drawing.Size(100, 20);
            this.VisualizationTitleLabel.TabIndex = 4;
            this.VisualizationTitleLabel.Text = "Visualización.";
            // 
            // VisualizationSchemaLabel
            // 
            this.VisualizationSchemaLabel.Depth = 0;
            this.VisualizationSchemaLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VisualizationSchemaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VisualizationSchemaLabel.Location = new System.Drawing.Point(150, 225);
            this.VisualizationSchemaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.VisualizationSchemaLabel.Name = "VisualizationSchemaLabel";
            this.VisualizationSchemaLabel.Size = new System.Drawing.Size(375, 21);
            this.VisualizationSchemaLabel.TabIndex = 6;
            this.VisualizationSchemaLabel.Text = "Esquema de color:";
            // 
            // AceptFormButton
            // 
            this.AceptFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AceptFormButton.Depth = 0;
            this.AceptFormButton.DrawShadows = true;
            this.AceptFormButton.HighEmphasis = true;
            this.AceptFormButton.Icon = null;
            this.AceptFormButton.Location = new System.Drawing.Point(200, 325);
            this.AceptFormButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AceptFormButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AceptFormButton.Name = "AceptFormButton";
            this.AceptFormButton.Size = new System.Drawing.Size(86, 36);
            this.AceptFormButton.TabIndex = 8;
            this.AceptFormButton.Text = "Aceptar";
            this.AceptFormButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AceptFormButton.UseAccentColor = false;
            this.AceptFormButton.UseVisualStyleBackColor = true;
            this.AceptFormButton.Click += new System.EventHandler(this.AceptFormButton_Click);
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelFormButton.Depth = 0;
            this.CancelFormButton.DrawShadows = true;
            this.CancelFormButton.HighEmphasis = true;
            this.CancelFormButton.Icon = null;
            this.CancelFormButton.Location = new System.Drawing.Point(295, 325);
            this.CancelFormButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelFormButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(96, 36);
            this.CancelFormButton.TabIndex = 9;
            this.CancelFormButton.Text = "Cancelar";
            this.CancelFormButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelFormButton.UseAccentColor = false;
            this.CancelFormButton.UseVisualStyleBackColor = true;
            this.CancelFormButton.Click += new System.EventHandler(this.CancelFormButton_Click);
            // 
            // ApplyFormButton
            // 
            this.ApplyFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ApplyFormButton.Depth = 0;
            this.ApplyFormButton.DrawShadows = true;
            this.ApplyFormButton.HighEmphasis = true;
            this.ApplyFormButton.Icon = null;
            this.ApplyFormButton.Location = new System.Drawing.Point(400, 325);
            this.ApplyFormButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ApplyFormButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ApplyFormButton.Name = "ApplyFormButton";
            this.ApplyFormButton.Size = new System.Drawing.Size(81, 36);
            this.ApplyFormButton.TabIndex = 10;
            this.ApplyFormButton.Text = "Aplicar";
            this.ApplyFormButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ApplyFormButton.UseAccentColor = false;
            this.ApplyFormButton.UseVisualStyleBackColor = true;
            this.ApplyFormButton.Click += new System.EventHandler(this.ApplyFormButton_Click);
            // 
            // VisualizationSchemaComboBox
            // 
            this.VisualizationSchemaComboBox.AutoResize = false;
            this.VisualizationSchemaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VisualizationSchemaComboBox.Depth = 0;
            this.VisualizationSchemaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.VisualizationSchemaComboBox.DropDownHeight = 89;
            this.VisualizationSchemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisualizationSchemaComboBox.DropDownWidth = 121;
            this.VisualizationSchemaComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.VisualizationSchemaComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VisualizationSchemaComboBox.FormattingEnabled = true;
            this.VisualizationSchemaComboBox.IntegralHeight = false;
            this.VisualizationSchemaComboBox.ItemHeight = 29;
            this.VisualizationSchemaComboBox.Items.AddRange(new object[] {
            "Indigo",
            "Azul",
            "Verde",
            "Rojo",
            "Purpura",
            "Gris"});
            this.VisualizationSchemaComboBox.Location = new System.Drawing.Point(350, 225);
            this.VisualizationSchemaComboBox.MaxDropDownItems = 3;
            this.VisualizationSchemaComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.VisualizationSchemaComboBox.Name = "VisualizationSchemaComboBox";
            this.VisualizationSchemaComboBox.Size = new System.Drawing.Size(125, 35);
            this.VisualizationSchemaComboBox.StartIndex = 0;
            this.VisualizationSchemaComboBox.TabIndex = 17;
            this.VisualizationSchemaComboBox.UseTallSize = false;
            // 
            // VisualizationDarkModeSwitch
            // 
            this.VisualizationDarkModeSwitch.AutoSize = true;
            this.VisualizationDarkModeSwitch.Depth = 0;
            this.VisualizationDarkModeSwitch.Location = new System.Drawing.Point(150, 175);
            this.VisualizationDarkModeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.VisualizationDarkModeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.VisualizationDarkModeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.VisualizationDarkModeSwitch.Name = "VisualizationDarkModeSwitch";
            this.VisualizationDarkModeSwitch.Ripple = true;
            this.VisualizationDarkModeSwitch.Size = new System.Drawing.Size(151, 37);
            this.VisualizationDarkModeSwitch.TabIndex = 5;
            this.VisualizationDarkModeSwitch.Text = "Modo oscuro";
            this.VisualizationDarkModeSwitch.UseVisualStyleBackColor = true;
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(496, 381);
            this.Controls.Add(this.VisualizationDarkModeSwitch);
            this.Controls.Add(this.VisualizationSchemaComboBox);
            this.Controls.Add(this.ApplyFormButton);
            this.Controls.Add(this.CancelFormButton);
            this.Controls.Add(this.AceptFormButton);
            this.Controls.Add(this.VisualizationSchemaLabel);
            this.Controls.Add(this.VisualizationTitleLabel);
            this.Controls.Add(this.PaginationNumericUpDown);
            this.Controls.Add(this.PaginationLabel);
            this.Controls.Add(this.PaginationTitleLabel);
            this.Controls.Add(this.FormPictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PreferencesForm";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferencias.";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaginationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FormPictureBox;
        private MaterialSkin.Controls.MaterialLabel PaginationTitleLabel;
        private MaterialSkin.Controls.MaterialLabel PaginationLabel;
        private System.Windows.Forms.NumericUpDown PaginationNumericUpDown;
        private MaterialSkin.Controls.MaterialLabel VisualizationTitleLabel;
        private MaterialSkin.Controls.MaterialLabel VisualizationSchemaLabel;
        private MaterialSkin.Controls.MaterialButton AceptFormButton;
        private MaterialSkin.Controls.MaterialButton CancelFormButton;
        private MaterialSkin.Controls.MaterialButton ApplyFormButton;
        private MaterialSkin.Controls.MaterialComboBox VisualizationSchemaComboBox;
        private MaterialSkin.Controls.MaterialSwitch VisualizationDarkModeSwitch;
    }
}
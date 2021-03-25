
namespace FeriaVirtual.App.Desktop.Forms.Users
{
    partial class SigninForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigninForm));
            this.FormPictureBox = new System.Windows.Forms.PictureBox();
            this.UsernameMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AceptFormMaterialButton = new MaterialSkin.Controls.MaterialButton();
            this.CancelFormMaterialButton = new MaterialSkin.Controls.MaterialButton();
            this.UsernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.PasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPictureBox
            // 
            this.FormPictureBox.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.login;
            this.FormPictureBox.Location = new System.Drawing.Point(25, 75);
            this.FormPictureBox.Name = "FormPictureBox";
            this.FormPictureBox.Size = new System.Drawing.Size(100, 125);
            this.FormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormPictureBox.TabIndex = 1;
            this.FormPictureBox.TabStop = false;
            // 
            // UsernameMaterialLabel
            // 
            this.UsernameMaterialLabel.AutoSize = true;
            this.UsernameMaterialLabel.Depth = 0;
            this.UsernameMaterialLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameMaterialLabel.Location = new System.Drawing.Point(150, 75);
            this.UsernameMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsernameMaterialLabel.Name = "UsernameMaterialLabel";
            this.UsernameMaterialLabel.Size = new System.Drawing.Size(139, 20);
            this.UsernameMaterialLabel.TabIndex = 1;
            this.UsernameMaterialLabel.Text = "Nombre de usuario:";
            // 
            // PasswordMaterialLabel
            // 
            this.PasswordMaterialLabel.AutoSize = true;
            this.PasswordMaterialLabel.Depth = 0;
            this.PasswordMaterialLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordMaterialLabel.Location = new System.Drawing.Point(150, 125);
            this.PasswordMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordMaterialLabel.Name = "PasswordMaterialLabel";
            this.PasswordMaterialLabel.Size = new System.Drawing.Size(86, 20);
            this.PasswordMaterialLabel.TabIndex = 3;
            this.PasswordMaterialLabel.Text = "Contraseña:";
            // 
            // AceptFormMaterialButton
            // 
            this.AceptFormMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AceptFormMaterialButton.Depth = 0;
            this.AceptFormMaterialButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AceptFormMaterialButton.DrawShadows = true;
            this.AceptFormMaterialButton.HighEmphasis = true;
            this.AceptFormMaterialButton.Icon = null;
            this.AceptFormMaterialButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptFormMaterialButton.ImageKey = "button-acept.png";
            this.AceptFormMaterialButton.Location = new System.Drawing.Point(300, 200);
            this.AceptFormMaterialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AceptFormMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AceptFormMaterialButton.Name = "AceptFormMaterialButton";
            this.AceptFormMaterialButton.Size = new System.Drawing.Size(86, 36);
            this.AceptFormMaterialButton.TabIndex = 7;
            this.AceptFormMaterialButton.Text = "Aceptar";
            this.AceptFormMaterialButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AceptFormMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AceptFormMaterialButton.UseAccentColor = false;
            this.AceptFormMaterialButton.UseVisualStyleBackColor = true;
            this.AceptFormMaterialButton.Click += new System.EventHandler(this.AceptFormMaterialFlatButton_Click);
            // 
            // CancelFormMaterialButton
            // 
            this.CancelFormMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelFormMaterialButton.Depth = 0;
            this.CancelFormMaterialButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelFormMaterialButton.DrawShadows = true;
            this.CancelFormMaterialButton.HighEmphasis = true;
            this.CancelFormMaterialButton.Icon = null;
            this.CancelFormMaterialButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelFormMaterialButton.ImageKey = "button-cancel.png";
            this.CancelFormMaterialButton.Location = new System.Drawing.Point(400, 200);
            this.CancelFormMaterialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelFormMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelFormMaterialButton.Name = "CancelFormMaterialButton";
            this.CancelFormMaterialButton.Size = new System.Drawing.Size(96, 36);
            this.CancelFormMaterialButton.TabIndex = 8;
            this.CancelFormMaterialButton.Text = "Cancelar";
            this.CancelFormMaterialButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelFormMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelFormMaterialButton.UseAccentColor = false;
            this.CancelFormMaterialButton.UseVisualStyleBackColor = true;
            this.CancelFormMaterialButton.Click += new System.EventHandler(this.CancelFormMaterialFlatButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Depth = 0;
            this.UsernameTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.UsernameTextBox.Location = new System.Drawing.Point(300, 75);
            this.UsernameTextBox.MaxLength = 50;
            this.UsernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UsernameTextBox.Multiline = false;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.UsernameTextBox.Size = new System.Drawing.Size(175, 36);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Text = "";
            this.UsernameTextBox.UseTallSize = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Depth = 0;
            this.PasswordTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(300, 125);
            this.PasswordTextBox.MaxLength = 50;
            this.PasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Password = true;
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PasswordTextBox.Size = new System.Drawing.Size(175, 36);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.Text = "";
            this.PasswordTextBox.UseTallSize = false;
            // 
            // SigninForm
            // 
            this.AcceptButton = this.AceptFormMaterialButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CancelFormMaterialButton;
            this.ClientSize = new System.Drawing.Size(522, 257);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.CancelFormMaterialButton);
            this.Controls.Add(this.AceptFormMaterialButton);
            this.Controls.Add(this.PasswordMaterialLabel);
            this.Controls.Add(this.UsernameMaterialLabel);
            this.Controls.Add(this.FormPictureBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SigninForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maipo Grande - Feria virtual.";
            this.Load += new System.EventHandler(this.SigninForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox FormPictureBox;
        private MaterialSkin.Controls.MaterialLabel UsernameMaterialLabel;
        private MaterialSkin.Controls.MaterialLabel PasswordMaterialLabel;
        private MaterialSkin.Controls.MaterialButton AceptFormMaterialButton;
        private MaterialSkin.Controls.MaterialButton CancelFormMaterialButton;
        private MaterialSkin.Controls.MaterialTextBox UsernameTextBox;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextBox;
    }
}
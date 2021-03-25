
namespace FeriaVirtual.App.Desktop.Forms.Utils
{
    partial class MainAdminForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminForm));
            this.FormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TitleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TypeUserLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.UserToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProfileToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FormImageList = new System.Windows.Forms.ImageList(this.components);
            this.CompanyToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FormPictureBox = new System.Windows.Forms.PictureBox();
            this.FileToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.FilePreferencesToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.FileToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.FileExitToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.MaintenanceToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.CustomersToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.MaintenanceToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EmployeesToolStripMenuItem1 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.FormTableLayoutPanel.SuspendLayout();
            this.TitleTableLayoutPanel.SuspendLayout();
            this.FormMenuStrip.SuspendLayout();
            this.FormStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTableLayoutPanel
            // 
            this.FormTableLayoutPanel.BackColor = System.Drawing.Color.Green;
            this.FormTableLayoutPanel.ColumnCount = 2;
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.FormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.FormTableLayoutPanel.Controls.Add(this.FormPictureBox, 0, 0);
            this.FormTableLayoutPanel.Controls.Add(this.TitleTableLayoutPanel, 1, 0);
            this.FormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormTableLayoutPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FormTableLayoutPanel.Name = "FormTableLayoutPanel";
            this.FormTableLayoutPanel.RowCount = 1;
            this.FormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormTableLayoutPanel.Size = new System.Drawing.Size(824, 100);
            this.FormTableLayoutPanel.TabIndex = 0;
            // 
            // TitleTableLayoutPanel
            // 
            this.TitleTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.TitleTableLayoutPanel.ColumnCount = 1;
            this.TitleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TitleTableLayoutPanel.Controls.Add(this.TypeUserLabel, 0, 2);
            this.TitleTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.TitleTableLayoutPanel.Controls.Add(this.FormMenuStrip, 0, 1);
            this.TitleTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleTableLayoutPanel.Location = new System.Drawing.Point(126, 3);
            this.TitleTableLayoutPanel.Name = "TitleTableLayoutPanel";
            this.TitleTableLayoutPanel.RowCount = 3;
            this.TitleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TitleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TitleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TitleTableLayoutPanel.Size = new System.Drawing.Size(695, 94);
            this.TitleTableLayoutPanel.TabIndex = 1;
            // 
            // TypeUserLabel
            // 
            this.TypeUserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeUserLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeUserLabel.ForeColor = System.Drawing.Color.White;
            this.TypeUserLabel.Location = new System.Drawing.Point(3, 70);
            this.TypeUserLabel.Name = "TypeUserLabel";
            this.TypeUserLabel.Size = new System.Drawing.Size(689, 24);
            this.TypeUserLabel.TabIndex = 0;
            this.TypeUserLabel.Text = "Formulario de administrador";
            this.TypeUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(689, 47);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Maipo Grande - Feria virtual.";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMenuStrip
            // 
            this.FormMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.FormMenuStrip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.MaintenanceToolStripMenuItem});
            this.FormMenuStrip.Location = new System.Drawing.Point(0, 47);
            this.FormMenuStrip.Name = "FormMenuStrip";
            this.FormMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.FormMenuStrip.Size = new System.Drawing.Size(695, 23);
            this.FormMenuStrip.TabIndex = 2;
            // 
            // FormStatusStrip
            // 
            this.FormStatusStrip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserToolStripStatusLabel,
            this.ProfileToolStripStatusLabel,
            this.CompanyToolStripStatusLabel});
            this.FormStatusStrip.Location = new System.Drawing.Point(0, 358);
            this.FormStatusStrip.Name = "FormStatusStrip";
            this.FormStatusStrip.Size = new System.Drawing.Size(824, 24);
            this.FormStatusStrip.TabIndex = 1;
            this.FormStatusStrip.Text = "statusStrip1";
            // 
            // UserToolStripStatusLabel
            // 
            this.UserToolStripStatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserToolStripStatusLabel.Name = "UserToolStripStatusLabel";
            this.UserToolStripStatusLabel.Size = new System.Drawing.Size(615, 19);
            this.UserToolStripStatusLabel.Spring = true;
            this.UserToolStripStatusLabel.Text = "Username";
            this.UserToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProfileToolStripStatusLabel
            // 
            this.ProfileToolStripStatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileToolStripStatusLabel.Name = "ProfileToolStripStatusLabel";
            this.ProfileToolStripStatusLabel.Size = new System.Drawing.Size(55, 19);
            this.ProfileToolStripStatusLabel.Text = "Profile";
            // 
            // FormImageList
            // 
            this.FormImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.FormImageList.ImageSize = new System.Drawing.Size(20, 20);
            this.FormImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CompanyToolStripStatusLabel
            // 
            this.CompanyToolStripStatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyToolStripStatusLabel.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.mg_logo;
            this.CompanyToolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CompanyToolStripStatusLabel.Name = "CompanyToolStripStatusLabel";
            this.CompanyToolStripStatusLabel.Size = new System.Drawing.Size(139, 19);
            this.CompanyToolStripStatusLabel.Text = "Maipo Grande";
            this.CompanyToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormPictureBox
            // 
            this.FormPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormPictureBox.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.mg_logo;
            this.FormPictureBox.Location = new System.Drawing.Point(20, 3);
            this.FormPictureBox.Name = "FormPictureBox";
            this.FormPictureBox.Size = new System.Drawing.Size(100, 94);
            this.FormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormPictureBox.TabIndex = 0;
            this.FormPictureBox.TabStop = false;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.AutoSize = false;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilePreferencesToolStripMenuItem,
            this.FileToolStripSeparator,
            this.FileExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.FileToolStripMenuItem.Text = "&Archivo";
            // 
            // FilePreferencesToolStripMenuItem
            // 
            this.FilePreferencesToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.menu_preferences2;
            this.FilePreferencesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilePreferencesToolStripMenuItem.Name = "FilePreferencesToolStripMenuItem";
            this.FilePreferencesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.FilePreferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.FilePreferencesToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.FilePreferencesToolStripMenuItem.Text = "&Preferencias";
            this.FilePreferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItem_Click);
            // 
            // FileToolStripSeparator
            // 
            this.FileToolStripSeparator.Name = "FileToolStripSeparator";
            this.FileToolStripSeparator.Size = new System.Drawing.Size(227, 6);
            // 
            // FileExitToolStripMenuItem
            // 
            this.FileExitToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.menu_exit;
            this.FileExitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileExitToolStripMenuItem.Name = "FileExitToolStripMenuItem";
            this.FileExitToolStripMenuItem.ShowShortcutKeys = false;
            this.FileExitToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.FileExitToolStripMenuItem.Text = "Cerrar sesión";
            this.FileExitToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // MaintenanceToolStripMenuItem
            // 
            this.MaintenanceToolStripMenuItem.AutoSize = false;
            this.MaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomersToolStripMenuItem,
            this.MaintenanceToolStripSeparator1,
            this.EmployeesToolStripMenuItem1});
            this.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem";
            this.MaintenanceToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.MaintenanceToolStripMenuItem.Text = "Mantenimiento";
            // 
            // CustomersToolStripMenuItem
            // 
            this.CustomersToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.menu_customer;
            this.CustomersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem";
            this.CustomersToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.CustomersToolStripMenuItem.Text = "Maestro de clientes";
            this.CustomersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // MaintenanceToolStripSeparator1
            // 
            this.MaintenanceToolStripSeparator1.Name = "MaintenanceToolStripSeparator1";
            this.MaintenanceToolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // EmployeesToolStripMenuItem1
            // 
            this.EmployeesToolStripMenuItem1.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.menu_employees;
            this.EmployeesToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeesToolStripMenuItem1.Name = "EmployeesToolStripMenuItem1";
            this.EmployeesToolStripMenuItem1.Size = new System.Drawing.Size(260, 26);
            this.EmployeesToolStripMenuItem1.Text = "Maestro de empleados";
            this.EmployeesToolStripMenuItem1.Click += new System.EventHandler(this.EmployeesToolStripMenuItem_Click);
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 382);
            this.Controls.Add(this.FormStatusStrip);
            this.Controls.Add(this.FormTableLayoutPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.FormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainAdminForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feria virtual - Formulario de administración.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainAdminForm_FormClosing);
            this.Load += new System.EventHandler(this.MainAdminForm_Load);
            this.FormTableLayoutPanel.ResumeLayout(false);
            this.TitleTableLayoutPanel.ResumeLayout(false);
            this.TitleTableLayoutPanel.PerformLayout();
            this.FormMenuStrip.ResumeLayout(false);
            this.FormMenuStrip.PerformLayout();
            this.FormStatusStrip.ResumeLayout(false);
            this.FormStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FormTableLayoutPanel;
        private System.Windows.Forms.PictureBox FormPictureBox;
        private System.Windows.Forms.TableLayoutPanel TitleTableLayoutPanel;
        private System.Windows.Forms.Label TypeUserLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.MenuStrip FormMenuStrip;
        private System.Windows.Forms.StatusStrip FormStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel UserToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel CompanyToolStripStatusLabel;
        private System.Windows.Forms.ImageList FormImageList;
        private System.Windows.Forms.ToolStripStatusLabel ProfileToolStripStatusLabel;
        private MaterialSkin.Controls.MaterialToolStripMenuItem FileToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem FilePreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileToolStripSeparator;
        private MaterialSkin.Controls.MaterialToolStripMenuItem FileExitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MaintenanceToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem CustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator MaintenanceToolStripSeparator1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem EmployeesToolStripMenuItem1;
    }
}
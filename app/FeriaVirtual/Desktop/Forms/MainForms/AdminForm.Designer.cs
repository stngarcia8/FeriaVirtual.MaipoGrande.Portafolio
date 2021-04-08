
namespace FeriaVirtual.App.Desktop.Forms.MainForms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.MenuOptionPanel = new MetroFramework.Controls.MetroPanel();
            this.FormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusinessTtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptionPanel.SuspendLayout();
            this.FormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOptionPanel
            // 
            this.MenuOptionPanel.BackColor = System.Drawing.Color.DarkGray;
            this.MenuOptionPanel.Controls.Add(this.FormMenuStrip);
            this.MenuOptionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuOptionPanel.HorizontalScrollbarBarColor = true;
            this.MenuOptionPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MenuOptionPanel.HorizontalScrollbarSize = 10;
            this.MenuOptionPanel.Location = new System.Drawing.Point(0, 66);
            this.MenuOptionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuOptionPanel.Name = "MenuOptionPanel";
            this.MenuOptionPanel.Size = new System.Drawing.Size(271, 431);
            this.MenuOptionPanel.TabIndex = 1;
            this.MenuOptionPanel.UseCustomBackColor = true;
            this.MenuOptionPanel.UseCustomForeColor = true;
            this.MenuOptionPanel.VerticalScrollbarBarColor = true;
            this.MenuOptionPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MenuOptionPanel.VerticalScrollbarSize = 10;
            // 
            // FormMenuStrip
            // 
            this.FormMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.FormMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormMenuStrip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.FormMenuStrip.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.FormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaintenanceToolStripMenuItem,
            this.BusinessTtoolStripMenuItem,
            this.reportToolStripMenuItem,
            this.PreferencesToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FormMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.FormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FormMenuStrip.Name = "FormMenuStrip";
            this.FormMenuStrip.Size = new System.Drawing.Size(271, 431);
            this.FormMenuStrip.TabIndex = 2;
            // 
            // MaintenanceToolStripMenuItem
            // 
            this.MaintenanceToolStripMenuItem.AutoSize = false;
            this.MaintenanceToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaintenanceToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintenanceToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.option_maintenance;
            this.MaintenanceToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MaintenanceToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem";
            this.MaintenanceToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.MaintenanceToolStripMenuItem.Size = new System.Drawing.Size(271, 60);
            this.MaintenanceToolStripMenuItem.Text = "Mantenimiento";
            this.MaintenanceToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.MaintenanceToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // BusinessTtoolStripMenuItem
            // 
            this.BusinessTtoolStripMenuItem.AutoSize = false;
            this.BusinessTtoolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessTtoolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.option_business;
            this.BusinessTtoolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BusinessTtoolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.BusinessTtoolStripMenuItem.Name = "BusinessTtoolStripMenuItem";
            this.BusinessTtoolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.BusinessTtoolStripMenuItem.Size = new System.Drawing.Size(271, 60);
            this.BusinessTtoolStripMenuItem.Text = "Procesos de negocio";
            this.BusinessTtoolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.BusinessTtoolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.AutoSize = false;
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.option_reports;
            this.reportToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(271, 60);
            this.reportToolStripMenuItem.Text = "Reportes";
            this.reportToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.reportToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // PreferencesToolStripMenuItem
            // 
            this.PreferencesToolStripMenuItem.AutoSize = false;
            this.PreferencesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreferencesToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.option_preferences;
            this.PreferencesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreferencesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem";
            this.PreferencesToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.PreferencesToolStripMenuItem.Size = new System.Drawing.Size(271, 60);
            this.PreferencesToolStripMenuItem.Text = "Preferencias";
            this.PreferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItem_Click);
            this.PreferencesToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.PreferencesToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.AutoSize = false;
            this.ExitToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.option_exit;
            this.ExitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(271, 60);
            this.ExitToolStripMenuItem.Text = "Salir de la aplicación";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            this.ExitToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.ExitToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 497);
            this.Controls.Add(this.MenuOptionPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.FormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminForm";
            this.Padding = new System.Windows.Forms.Padding(0, 66, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Feria virtual - Administración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MenuOptionPanel.ResumeLayout(false);
            this.MenuOptionPanel.PerformLayout();
            this.FormMenuStrip.ResumeLayout(false);
            this.FormMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel MenuOptionPanel;
        private System.Windows.Forms.MenuStrip FormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusinessTtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}
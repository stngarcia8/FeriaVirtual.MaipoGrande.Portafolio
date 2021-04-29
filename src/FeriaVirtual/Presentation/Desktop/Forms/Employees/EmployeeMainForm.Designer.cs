
namespace FeriaVirtual.App.Desktop.Forms.Employees
{
    partial class EmployeeMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMainForm));
            this.MenuPanel = new MetroFramework.Controls.MetroPanel();
            this.FormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.NewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListPanel = new MetroFramework.Controls.MetroPanel();
            this.ListLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ListTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.FilterLabel = new MetroFramework.Controls.MetroLabel();
            this.FilterComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FilterTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FilterButton = new MetroFramework.Controls.MetroButton();
            this.EmployeeGrid = new MetroFramework.Controls.MetroGrid();
            this.GridContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ContextRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextEnableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextDisableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextChangePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListPageLabel = new MetroFramework.Controls.MetroLabel();
            this.ListPageComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ListResultLabel = new MetroFramework.Controls.MetroLabel();
            this.DataPanel = new MetroFramework.Controls.MetroPanel();
            this.MenuPanel.SuspendLayout();
            this.FormMenuStrip.SuspendLayout();
            this.ListPanel.SuspendLayout();
            this.ListLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.GridContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.DarkGray;
            this.MenuPanel.Controls.Add(this.FormMenuStrip);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.HorizontalScrollbarBarColor = true;
            this.MenuPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MenuPanel.HorizontalScrollbarSize = 10;
            this.MenuPanel.Location = new System.Drawing.Point(0, 66);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(271, 431);
            this.MenuPanel.TabIndex = 2;
            this.MenuPanel.UseCustomBackColor = true;
            this.MenuPanel.UseCustomForeColor = true;
            this.MenuPanel.VerticalScrollbarBarColor = true;
            this.MenuPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MenuPanel.VerticalScrollbarSize = 10;
            // 
            // FormMenuStrip
            // 
            this.FormMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.FormMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormMenuStrip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.FormMenuStrip.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.FormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEmployeeToolStripMenuItem,
            this.RefreshToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FormMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.FormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FormMenuStrip.Name = "FormMenuStrip";
            this.FormMenuStrip.Size = new System.Drawing.Size(271, 431);
            this.FormMenuStrip.TabIndex = 2;
            // 
            // NewEmployeeToolStripMenuItem
            // 
            this.NewEmployeeToolStripMenuItem.AutoSize = false;
            this.NewEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEmployeeToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.button_add;
            this.NewEmployeeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewEmployeeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.NewEmployeeToolStripMenuItem.Name = "NewEmployeeToolStripMenuItem";
            this.NewEmployeeToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.NewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(271, 60);
            this.NewEmployeeToolStripMenuItem.Text = "&Crear empleado";
            this.NewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.NewEmployeeToolStripMenuItem_Click);
            this.NewEmployeeToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.NewEmployeeToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.AutoSize = false;
            this.RefreshToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.button_refresh;
            this.RefreshToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(271, 60);
            this.RefreshToolStripMenuItem.Text = "&Actualizar resultados";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            this.RefreshToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.RefreshToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
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
            this.ExitToolStripMenuItem.Text = "Cerrar formulario";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            this.ExitToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.ExitToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ListPanel.Controls.Add(this.ListLayoutPanel);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.HorizontalScrollbar = true;
            this.ListPanel.HorizontalScrollbarBarColor = true;
            this.ListPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ListPanel.HorizontalScrollbarSize = 10;
            this.ListPanel.Location = new System.Drawing.Point(271, 66);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Padding = new System.Windows.Forms.Padding(10);
            this.ListPanel.Size = new System.Drawing.Size(872, 431);
            this.ListPanel.TabIndex = 3;
            this.ListPanel.VerticalScrollbar = true;
            this.ListPanel.VerticalScrollbarBarColor = true;
            this.ListPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ListPanel.VerticalScrollbarSize = 10;
            // 
            // ListLayoutPanel
            // 
            this.ListLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListLayoutPanel.ColumnCount = 5;
            this.ListLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ListLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ListLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ListLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ListLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ListLayoutPanel.Controls.Add(this.ListTitleLabel, 0, 0);
            this.ListLayoutPanel.Controls.Add(this.FilterLabel, 0, 1);
            this.ListLayoutPanel.Controls.Add(this.FilterComboBox, 1, 1);
            this.ListLayoutPanel.Controls.Add(this.FilterTextBox, 3, 1);
            this.ListLayoutPanel.Controls.Add(this.FilterButton, 4, 1);
            this.ListLayoutPanel.Controls.Add(this.EmployeeGrid, 0, 2);
            this.ListLayoutPanel.Controls.Add(this.ListPageLabel, 0, 3);
            this.ListLayoutPanel.Controls.Add(this.ListPageComboBox, 1, 3);
            this.ListLayoutPanel.Controls.Add(this.ListResultLabel, 2, 3);
            this.ListLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.ListLayoutPanel.Name = "ListLayoutPanel";
            this.ListLayoutPanel.RowCount = 4;
            this.ListLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ListLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ListLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.ListLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ListLayoutPanel.Size = new System.Drawing.Size(852, 411);
            this.ListLayoutPanel.TabIndex = 2;
            // 
            // ListTitleLabel
            // 
            this.ListTitleLabel.AutoSize = true;
            this.ListLayoutPanel.SetColumnSpan(this.ListTitleLabel, 4);
            this.ListTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListTitleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ListTitleLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ListTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.ListTitleLabel.Name = "ListTitleLabel";
            this.ListTitleLabel.Size = new System.Drawing.Size(760, 41);
            this.ListTitleLabel.TabIndex = 0;
            this.ListTitleLabel.Text = "Lista de empleados disponibles";
            this.ListTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListTitleLabel.WrapToLine = true;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.FilterLabel.Location = new System.Drawing.Point(3, 41);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(79, 41);
            this.FilterLabel.TabIndex = 1;
            this.FilterLabel.Text = "Filtros:";
            this.FilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterComboBox
            // 
            this.ListLayoutPanel.SetColumnSpan(this.FilterComboBox, 2);
            this.FilterComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.ItemHeight = 23;
            this.FilterComboBox.Location = new System.Drawing.Point(88, 44);
            this.FilterComboBox.MaxDropDownItems = 4;
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(377, 29);
            this.FilterComboBox.TabIndex = 2;
            this.FilterComboBox.UseSelectable = true;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.FilterTextBox.CustomButton.Image = null;
            this.FilterTextBox.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.FilterTextBox.CustomButton.Name = "";
            this.FilterTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.FilterTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FilterTextBox.CustomButton.TabIndex = 1;
            this.FilterTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FilterTextBox.CustomButton.UseSelectable = true;
            this.FilterTextBox.CustomButton.Visible = false;
            this.FilterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.FilterTextBox.Lines = new string[0];
            this.FilterTextBox.Location = new System.Drawing.Point(471, 44);
            this.FilterTextBox.MaxLength = 32767;
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.PasswordChar = '\0';
            this.FilterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilterTextBox.SelectedText = "";
            this.FilterTextBox.SelectionLength = 0;
            this.FilterTextBox.SelectionStart = 0;
            this.FilterTextBox.ShortcutsEnabled = true;
            this.FilterTextBox.ShowClearButton = true;
            this.FilterTextBox.Size = new System.Drawing.Size(292, 35);
            this.FilterTextBox.TabIndex = 3;
            this.FilterTextBox.UseSelectable = true;
            this.FilterTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FilterTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FilterButton
            // 
            this.FilterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.FilterButton.Location = new System.Drawing.Point(769, 44);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(80, 35);
            this.FilterButton.TabIndex = 4;
            this.FilterButton.Text = "&Buscar";
            this.FilterButton.UseSelectable = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AllowUserToAddRows = false;
            this.EmployeeGrid.AllowUserToDeleteRows = false;
            this.EmployeeGrid.AllowUserToResizeRows = false;
            this.EmployeeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EmployeeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmployeeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListLayoutPanel.SetColumnSpan(this.EmployeeGrid, 5);
            this.EmployeeGrid.ContextMenuStrip = this.GridContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGrid.EnableHeadersVisualStyles = false;
            this.EmployeeGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmployeeGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EmployeeGrid.Location = new System.Drawing.Point(3, 85);
            this.EmployeeGrid.MultiSelect = false;
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.ReadOnly = true;
            this.EmployeeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeGrid.RowHeadersVisible = false;
            this.EmployeeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmployeeGrid.RowTemplate.Height = 26;
            this.EmployeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGrid.ShowCellErrors = false;
            this.EmployeeGrid.ShowCellToolTips = false;
            this.EmployeeGrid.ShowEditingIcon = false;
            this.EmployeeGrid.ShowRowErrors = false;
            this.EmployeeGrid.Size = new System.Drawing.Size(846, 281);
            this.EmployeeGrid.StandardTab = true;
            this.EmployeeGrid.TabIndex = 5;
            this.EmployeeGrid.SelectionChanged += new System.EventHandler(this.EmployeeGrid_SelectionChanged);
            // 
            // GridContextMenu
            // 
            this.GridContextMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextRefreshToolStripMenuItem,
            this.ContextToolStripSeparator1,
            this.ContextEditToolStripMenuItem,
            this.ContextEnableToolStripMenuItem,
            this.ContextDisableToolStripMenuItem,
            this.ContextToolStripSeparator2,
            this.ContextChangePasswordToolStripMenuItem1});
            this.GridContextMenu.Name = "GridContextMenu";
            this.GridContextMenu.Size = new System.Drawing.Size(248, 168);
            this.GridContextMenu.Text = "Opciones";
            // 
            // ContextRefreshToolStripMenuItem
            // 
            this.ContextRefreshToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.button_refresh1;
            this.ContextRefreshToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContextRefreshToolStripMenuItem.Name = "ContextRefreshToolStripMenuItem";
            this.ContextRefreshToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.ContextRefreshToolStripMenuItem.Text = "Actualizar lista";
            this.ContextRefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // ContextToolStripSeparator1
            // 
            this.ContextToolStripSeparator1.Name = "ContextToolStripSeparator1";
            this.ContextToolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // ContextEditToolStripMenuItem
            // 
            this.ContextEditToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.button_edit;
            this.ContextEditToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContextEditToolStripMenuItem.Name = "ContextEditToolStripMenuItem";
            this.ContextEditToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.ContextEditToolStripMenuItem.Text = "Editar";
            this.ContextEditToolStripMenuItem.Click += new System.EventHandler(this.ContextEditToolStripMenuItem_Click);
            // 
            // ContextEnableToolStripMenuItem
            // 
            this.ContextEnableToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.button_enable_user;
            this.ContextEnableToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContextEnableToolStripMenuItem.Name = "ContextEnableToolStripMenuItem";
            this.ContextEnableToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.ContextEnableToolStripMenuItem.Text = "Habilitar";
            // 
            // ContextDisableToolStripMenuItem
            // 
            this.ContextDisableToolStripMenuItem.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.button_disable_user;
            this.ContextDisableToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContextDisableToolStripMenuItem.Name = "ContextDisableToolStripMenuItem";
            this.ContextDisableToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.ContextDisableToolStripMenuItem.Text = "Inhabilitar";
            // 
            // ContextToolStripSeparator2
            // 
            this.ContextToolStripSeparator2.Name = "ContextToolStripSeparator2";
            this.ContextToolStripSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // ContextChangePasswordToolStripMenuItem1
            // 
            this.ContextChangePasswordToolStripMenuItem1.Image = global::FeriaVirtual.App.Desktop.Properties.Resources.button_change_password;
            this.ContextChangePasswordToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContextChangePasswordToolStripMenuItem1.Name = "ContextChangePasswordToolStripMenuItem1";
            this.ContextChangePasswordToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.ContextChangePasswordToolStripMenuItem1.Text = "Cambiar contraseña";
            // 
            // ListPageLabel
            // 
            this.ListPageLabel.AutoSize = true;
            this.ListPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPageLabel.Location = new System.Drawing.Point(3, 369);
            this.ListPageLabel.Name = "ListPageLabel";
            this.ListPageLabel.Size = new System.Drawing.Size(79, 42);
            this.ListPageLabel.TabIndex = 6;
            this.ListPageLabel.Text = "Páginas:";
            this.ListPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListPageComboBox
            // 
            this.ListPageComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListPageComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.ListPageComboBox.FormattingEnabled = true;
            this.ListPageComboBox.ItemHeight = 23;
            this.ListPageComboBox.Location = new System.Drawing.Point(88, 372);
            this.ListPageComboBox.Name = "ListPageComboBox";
            this.ListPageComboBox.Size = new System.Drawing.Size(79, 29);
            this.ListPageComboBox.TabIndex = 7;
            this.ListPageComboBox.UseSelectable = true;
            this.ListPageComboBox.SelectedIndexChanged += new System.EventHandler(this.ListPageComboBox_SelectedIndexChanged);
            // 
            // ListResultLabel
            // 
            this.ListResultLabel.AutoSize = true;
            this.ListLayoutPanel.SetColumnSpan(this.ListResultLabel, 3);
            this.ListResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListResultLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ListResultLabel.Location = new System.Drawing.Point(173, 369);
            this.ListResultLabel.Name = "ListResultLabel";
            this.ListResultLabel.Size = new System.Drawing.Size(676, 42);
            this.ListResultLabel.TabIndex = 8;
            this.ListResultLabel.Text = "x/y registros encontrados.";
            this.ListResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataPanel
            // 
            this.DataPanel.AutoScroll = true;
            this.DataPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.HorizontalScrollbar = true;
            this.DataPanel.HorizontalScrollbarBarColor = true;
            this.DataPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.DataPanel.HorizontalScrollbarSize = 10;
            this.DataPanel.Location = new System.Drawing.Point(0, 66);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(1143, 431);
            this.DataPanel.TabIndex = 4;
            this.DataPanel.VerticalScrollbar = true;
            this.DataPanel.VerticalScrollbarBarColor = true;
            this.DataPanel.VerticalScrollbarHighlightOnWheel = false;
            this.DataPanel.VerticalScrollbarSize = 10;
            // 
            // EmployeeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 497);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.DataPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EmployeeMainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 66, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Maestro de empleados";
            this.Load += new System.EventHandler(this.EmployeeMainForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.FormMenuStrip.ResumeLayout(false);
            this.FormMenuStrip.PerformLayout();
            this.ListPanel.ResumeLayout(false);
            this.ListLayoutPanel.ResumeLayout(false);
            this.ListLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.GridContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MenuPanel;
        private System.Windows.Forms.MenuStrip FormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel ListPanel;
        private System.Windows.Forms.TableLayoutPanel ListLayoutPanel;
        private MetroFramework.Controls.MetroLabel ListTitleLabel;
        private MetroFramework.Controls.MetroPanel DataPanel;
        private MetroFramework.Controls.MetroLabel FilterLabel;
        private MetroFramework.Controls.MetroComboBox FilterComboBox;
        private MetroFramework.Controls.MetroTextBox FilterTextBox;
        private MetroFramework.Controls.MetroButton FilterButton;
        private MetroFramework.Controls.MetroGrid EmployeeGrid;
        private MetroFramework.Controls.MetroLabel ListPageLabel;
        private MetroFramework.Controls.MetroComboBox ListPageComboBox;
        private MetroFramework.Controls.MetroLabel ListResultLabel;
        private MetroFramework.Controls.MetroContextMenu GridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ContextRefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ContextToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextEnableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextDisableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextChangePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator ContextToolStripSeparator2;
    }
}
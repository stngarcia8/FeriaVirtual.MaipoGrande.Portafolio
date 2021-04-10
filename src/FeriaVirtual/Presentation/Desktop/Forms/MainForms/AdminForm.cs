using FeriaVirtual.App.Desktop.Forms.Employees;
using FeriaVirtual.App.Desktop.SeedWork.FormControls;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.MainForms
{
    public partial class AdminForm : MetroForm
    {
        private readonly ThemeManager _themeManager;
        private bool _menuIsOpened = false;


        public AdminForm()
        {
            InitializeComponent();
            _themeManager = ThemeManager.SuscribeForm(this);
            _themeManager.DarkMode();
        }


        private void AdminForm_Load
            (object sender, EventArgs e) =>
            ConfigureForm();


        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MsgBox.Show(this, "¿Abandonar aplicación de Feria Virtual?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = !result.Equals(DialogResult.Yes);
            if (!e.Cancel) Environment.Exit(0);
        }


        private void ConfigureForm()
        {
            MenuOptionPanel.BackColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.DarkSlateGray : Color.DarkGray;
            MaintenanceToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
            BusinessTtoolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
            reportToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
            StadisticToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
            PreferencesToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
            ExitToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
        }


        private void ToolStripMenuItem_MouseEnter
            (object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.ForeColor = Color.Black;
        }


        private void ToolStripMenuItem_MouseLeave
            (object sender, EventArgs e)
        {
            if (_menuIsOpened) return;
            var item = (ToolStripMenuItem)sender;
            item.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
        }


        private void ToolStripMenuItem_DropDownOpened
    (object sender, EventArgs e)
        {
            _menuIsOpened = true;
            var item = (ToolStripMenuItem)sender;
            item.ForeColor = Color.Black;
        }


        private void ToolStripMenuItem_DropDownClosed
            (object sender, EventArgs e)
        {
            _menuIsOpened = false;
            var item = (ToolStripMenuItem)sender;
            item.ForeColor = Color.Black;
        }




        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click
            (object sender, EventArgs e) =>
            Close();

        private void EmployeeMaintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeeMainForm());
        }




        private void OpenForm(MetroForm form)
        {
            if (form is null) return;
            Hide();
            form.ShowDialog();
            Show();
        }

    }
}

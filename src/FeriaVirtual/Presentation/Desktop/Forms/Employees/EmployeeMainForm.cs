using FeriaVirtual.App.Desktop.Extensions.DependencyInjection;
using FeriaVirtual.App.Desktop.SeedWork.FormControls;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Utils;
using FeriaVirtual.App.Desktop.Services.Employees;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.Employees
{
    public partial class EmployeeMainForm : MetroForm
    {
        private readonly IEmployeeService _employeeService;
        private EmployeeFilter _filters;
        private readonly ThemeManager _themeManager;
        private bool _menuIsOpened;


        public EmployeeMainForm()
        {
            InitializeComponent();
            _themeManager = ThemeManager.SuscribeForm(this);
            _themeManager.DarkMode();
            var serviceProvider = DependencyContainer.GetProvider;
            _employeeService = serviceProvider.GetService<IEmployeeService>();
        }


        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {
            ConfigureForm();
            ConfigureFilters();
            ConfigurePaginator();
        }


        private void ConfigureForm()
        {
            MenuPanel.BackColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.DarkSlateGray : Color.DarkGray;
            RefreshToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
            NewEmployeeToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
            ExitToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroThemeStyle.Dark) ? Color.White : Color.Black;
        }


        private void ConfigureFilters()
        {
            _filters = EmployeeFilter.CreateFilter();
            var configurator = ComboboxConfigurator.Configure(this.FilterComboBox);
            configurator.AddStringList(_filters.GetFilters);
            FilterTextBox.Text = string.Empty;
        }


        private async void ConfigurePaginator()
        {
            var employeeCounter = await _employeeService.GetNumberOfEmployees();
            var pages = employeeCounter.Total / PreferenceData.RowsPerPage;
            if ((employeeCounter.Total % PreferenceData.RowsPerPage) != 0) pages++;
            var configurator = ComboboxConfigurator.Configure(ListPageComboBox);
            configurator.AddNumbers(1, pages);
            ListResultLabel.Text = $"{employeeCounter.Total} registros encontrados.";
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


        private void ExitToolStripMenuItem_Click
            (object sender, EventArgs e) =>
            Close();


        private void FilterComboBox_SelectedIndexChanged
            (object sender, EventArgs e) =>
            FilterTextBox.Visible = FilterComboBox.SelectedIndex.Equals(FilterComboBox.Items.Count - 1);


        private void FilterButton_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }


        private async void LoadRecords()
        {
            try {
                var e = await _employeeService.GetAllEmployees(int.Parse(ListPageComboBox.Text));
                EmployeeGrid.DataSource = null;
                EmployeeGrid.DataSource = e;
            } catch (Exception ex) {
                MsgBox.Show(this, ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

using FeriaVirtual.App.Desktop.Extensions.DependencyInjection;
using FeriaVirtual.App.Desktop.SeedWork.Filters;
using FeriaVirtual.App.Desktop.SeedWork.FormControls;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Utils;
using FeriaVirtual.App.Desktop.Services.Employees;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.Employees
{
    public partial class EmployeeMainForm : MetroFramework.Forms.MetroForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly ThemeManager _themeManager;
        private EmployeeFilter _filters;
        private Criteria _actualCriteria;


        public EmployeeMainForm()
        {
            InitializeComponent();
            _themeManager = ThemeManager.SuscribeForm(this);
            _themeManager.DarkMode();
            var serviceProvider = DependencyContainer.GetProvider;
            _employeeService = serviceProvider.GetService<IEmployeeService>();
        }


        private void EmployeeMainForm_Load(object sender, System.EventArgs e)
        {
            ConfigureForm();
            ConfigureFilters();
            //Task<int> numberOfRecords = CountRecords();
            //ConfigurePaginator(numberOfRecords.Result);
            LoadRecords();
        }


        private void ConfigureForm()
        {
            MenuPanel.BackColor = _themeManager.Style.Equals(MetroFramework.MetroThemeStyle.Dark) ? System.Drawing.Color.DarkSlateGray : System.Drawing.Color.DarkGray;
            RefreshToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroFramework.MetroThemeStyle.Dark) ? System.Drawing.Color.White : System.Drawing.Color.Black;
            NewEmployeeToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroFramework.MetroThemeStyle.Dark) ? System.Drawing.Color.White : System.Drawing.Color.Black;
            ExitToolStripMenuItem.ForeColor = _themeManager.Style.Equals(MetroFramework.MetroThemeStyle.Dark) ? System.Drawing.Color.White : System.Drawing.Color.Black;
        }


        private void ConfigureFilters()
        {
            _filters = EmployeeFilter.CreateFilter();
            var configurator = ComboboxConfigurator.Configure(FilterComboBox);
            configurator.AddStringList(_filters.GetFilters);
            FilterTextBox.Text = string.Empty;
            _actualCriteria = _filters.GetCriteriaByIndex(0);
        }


        private void ConfigurePaginator(int numberOfRecords)
        {
            var pages = 0;
            pages = numberOfRecords / PreferenceData.RowsPerPage;
            if((numberOfRecords % PreferenceData.RowsPerPage) != 0)
                pages++;
            var configurator = ComboboxConfigurator.Configure(ListPageComboBox);
            configurator.AddNumbers(1, pages);
            ListResultLabel.Text = $"{numberOfRecords} registros encontrados.";
        }

        private async Task<int> CountRecords()
        {
            var employeeCounter = new EmployeeCounterViewModel();
            int numberOfRecords = 0;
            try {
                employeeCounter = await _employeeService.GetNumberOfEmployees();
                numberOfRecords= employeeCounter.Total;
                return numberOfRecords;
            } catch {
                return numberOfRecords;
            }
        }










        #region "Toolstripmenu events"

        private void ToolStripMenuItem_MouseEnter
            (object sender, System.EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.ForeColor = System.Drawing.Color.Black;
        }


        private void ToolStripMenuItem_MouseLeave
            (object sender, System.EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.ForeColor = _themeManager.Style.Equals(MetroFramework.MetroThemeStyle.Dark) ? System.Drawing.Color.White : System.Drawing.Color.Black;
        }


        private void ToolStripMenuItem_DropDownOpened
    (object sender, System.EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.ForeColor = System.Drawing.Color.Black;
        }


        private void ToolStripMenuItem_DropDownClosed
            (object sender, System.EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.ForeColor = System.Drawing.Color.Black;
        }

        #endregion


        private void ExitToolStripMenuItem_Click
            (object sender, System.EventArgs e) =>
            Close();


        private void ListPageComboBox_SelectedIndexChanged
            (object sender, System.EventArgs e)
        {
            if(_actualCriteria is null)
                return;
            _actualCriteria.PageNumber = int.Parse(ListPageComboBox.Text);
        }


        private void FilterComboBox_SelectedIndexChanged
            (object sender, System.EventArgs e)
        {
            _actualCriteria = _filters.GetCriteriaByIndex(FilterComboBox.SelectedIndex);
            FilterTextBox.Visible = _actualCriteria.RequireInput;
        }


        private void FilterButton_Click
            (object sender, System.EventArgs e)
        {
            VerifyCriteriaValues();
            LoadRecords();
        }


        private void VerifyCriteriaValues()
        {
            if(!_actualCriteria.RequireInput)
                return;
            _actualCriteria.ChangeCriteriaValue(FilterTextBox.Text);
        }


        private async void LoadRecords()
        {
            try {
                IList < EmployeesViewModel > employeesFound;
                if(_actualCriteria.CriteriaType.Equals("search_all"))
                    employeesFound = await _employeeService.GetAllEmployees(_actualCriteria.PageNumber);
                else
                    employeesFound = await _employeeService.GetEmployeesByCriteria(_actualCriteria);
                ConfigureDataGridView(employeesFound);
                ConfigurePaginator(employeesFound.Count);
            } catch(System.Exception ex) {
                MsgBox.Show(this, ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView(IList<EmployeesViewModel> employeesFound)
        {
            var configurator = DataGridViewConfigurator.Configure(EmployeeGrid);
            EmployeeGrid.DataSource = employeesFound;
            configurator.HideColumn("UserId");
        }


    }
}

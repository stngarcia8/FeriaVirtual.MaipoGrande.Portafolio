using FeriaVirtual.App.Desktop.Extensions.DependencyInjection;
using FeriaVirtual.App.Desktop.SeedWork.FiltersByCriteria;
using FeriaVirtual.App.Desktop.SeedWork.FormControls;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Utils;
using FeriaVirtual.App.Desktop.Services.Employees;
using FeriaVirtual.App.Desktop.Services.Employees.ViewModels;
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
        private DataGridViewRow _currentRow ;
        private int _offset;


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
            ConfigureContextMenu();
            ConfigurePaginator();
            _currentRow = null;
            LoadRecords();
            FilterTextBox.Visible = _actualCriteria.RequireInput;
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
            this.FilterComboBox.SelectedIndexChanged -= this.FilterComboBox_SelectedIndexChanged;
            _filters = EmployeeFilter.CreateFilter();
            var configurator = ComboboxConfigurator.Configure(FilterComboBox);
            configurator.DefineDatasource<Filter>(_filters.Filters, "FilterName", "FilterCriteria");
            FilterTextBox.Text = string.Empty;
            _actualCriteria = (Criteria)FilterComboBox.SelectedValue;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
        }


        private async void ConfigurePaginator()
        {
            var pages = 0;
            int numberOfRecords = await CountRecords();

            pages = numberOfRecords / PreferenceData.RowsPerPage;
            if((numberOfRecords % PreferenceData.RowsPerPage) != 0)
                pages++;
            _offset= (int)((pages * PreferenceData.RowsPerPage)-PreferenceData.RowsPerPage);

            var configurator = ComboboxConfigurator.Configure(ListPageComboBox);
            configurator.AddNumbers(1, pages);
            ListResultLabel.Text = $"{numberOfRecords} registros encontrados.";
        }


        private async Task<int> CountRecords()
        {
            var employeeCounter = new EmployeeCounterViewModel();
            int numberOfRecords = 0;
            try {
                employeeCounter = await _employeeService.GetNumberOfEmployees(_actualCriteria);
                numberOfRecords = employeeCounter.Total;
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


        private void NewEmployeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new EmployeeCreateForm(_employeeService);
            form.ShowDialog();
            if(form.IsSaved) {
                RefreshResults();
            }
        }


        private void RefreshToolStripMenuItem_Click
            (object sender, System.EventArgs e) =>
            RefreshResults();


        private void RefreshResults()
        {
            VerifyCriteriaValues();
            LoadRecords();
        }


        private void ExitToolStripMenuItem_Click
            (object sender, System.EventArgs e) =>
            Close();


        private void FilterComboBox_SelectedIndexChanged
            (object sender, System.EventArgs e)
        {
            _actualCriteria = (Criteria)FilterComboBox.SelectedValue;
            FilterTextBox.Visible = _actualCriteria.RequireInput;
        }


        private void FilterButton_Click
            (object sender, System.EventArgs e) =>
            RefreshResults();


        private void VerifyCriteriaValues()
        {
            if(!_actualCriteria.RequireInput)
                return;
            _actualCriteria.ChangeFieldValue(FilterTextBox.Text);
        }

        private async void LoadRecords()
        {
            try {
                ConfigureDataGridView(
                    (IList<EmployeesViewModel>)await _employeeService.GetEmployeesByCriteria
                        (_actualCriteria, 
                        PreferenceData.RowsPerPage, _offset)
                    );
                ConfigureContextMenu();
                ConfigurePaginator();

            } catch(System.Exception ex) {
                ConfigureContextMenu();
                MsgBox.Show(this, ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigureDataGridView(IList<EmployeesViewModel> employeesFound)
        {
            var configurator = DataGridViewConfigurator.Configure(EmployeeGrid);
            EmployeeGrid.DataSource = employeesFound;
            configurator.HideColumn("UserId");
        }


        private void ListPageComboBox_SelectedIndexChanged
    (object sender, System.EventArgs e)
        {
        }


        private void ConfigureContextMenu()
        {
            GridContextMenu.Enabled = !EmployeeGrid.Rows.Count.Equals(0);
        }


        private void EmployeeGrid_SelectionChanged(object sender, System.EventArgs e)
        {
            if(EmployeeGrid.Rows.Count.Equals(0))
                return;
            _currentRow = EmployeeGrid.CurrentRow;
            if(_currentRow is null)
                return;
            ContextEnableToolStripMenuItem.Visible = !_currentRow.Cells[6].Value.Equals("Activo");
            ContextDisableToolStripMenuItem.Visible = !_currentRow.Cells[6].Value.Equals("Inactivo");
        }


        private void ContextEditToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if(_currentRow is null)
                return;
            var form = new EmployeeUpdateForm(_employeeService) {
                EmployeeId = _currentRow.Cells[0].Value.ToString()
            };
            form.ShowDialog();
            if(form.IsSaved)
                RefreshResults();
        }


    }
}

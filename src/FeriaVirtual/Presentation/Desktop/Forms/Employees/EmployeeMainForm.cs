using FeriaVirtual.App.Desktop.Extensions.DependencyInjection;
using FeriaVirtual.App.Desktop.Forms.Utils;
using FeriaVirtual.App.Desktop.SeedWork.FiltersByCriteria;
using FeriaVirtual.App.Desktop.SeedWork.FormControls;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.Themes;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Preferences;
using FeriaVirtual.App.Desktop.Services.Employees;
using FeriaVirtual.App.Desktop.Services.Employees.Dto;
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
        private int _offset=0;
        private int _pages =0;


        public EmployeeMainForm()
        {
            InitializeComponent();
            _themeManager = ThemeManager.SuscribeForm(this);
            _themeManager.Initialize(PreferenceData.ColorSchema, PreferenceData.DarkMode);
            var serviceProvider = DependencyContainer.GetProvider;
            _employeeService = serviceProvider.GetService<IEmployeeService>();
        }


        private void EmployeeMainForm_Load
            (object sender, System.EventArgs e)
        {
            ListResultLabel.Text = string.Empty;
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
            ListResultLabel.Text = "Cargando registros...";
            int pages =0;
            int numberOfRecords = await CountRecords();
            pages = numberOfRecords / PreferenceData.RowsPerPage;
            if((numberOfRecords % PreferenceData.RowsPerPage) != 0)
                pages++;

            if(pages > _pages) {
                _pages = pages;
                this.ListPageComboBox.SelectedIndexChanged -= this.ListPageComboBox_SelectedIndexChanged;
                var configurator = ComboboxConfigurator.Configure(ListPageComboBox);
                configurator.AddNumbers(1, pages);
                this.ListPageComboBox.SelectedIndexChanged += new System.EventHandler(this.ListPageComboBox_SelectedIndexChanged);
            }
            ListResultLabel.Text = $"{numberOfRecords} registros encontrados.";

            CalculateOffset();
        }


        private void CalculateOffset()
        {
            int pages = int.Parse(ListPageComboBox.Text);
            _offset = (int)((pages * PreferenceData.RowsPerPage) - PreferenceData.RowsPerPage);
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
            CalculateOffset();
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
            (object sender, System.EventArgs e)
            => RefreshResults();


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
            => RefreshResults();


        private void ConfigureContextMenu()
        {
            GridContextMenu.Enabled = !EmployeeGrid.Rows.Count.Equals(0);
        }


        private void EmployeeGrid_SelectionChanged
            (object sender, System.EventArgs e)
        {
            if(EmployeeGrid.Rows.Count.Equals(0))
                return;
            _currentRow = EmployeeGrid.CurrentRow;
        }


        private void ContextEditToolStripMenuItem_Click
            (object sender, System.EventArgs e)
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

        private void ContextEnableToolStripMenuItem_Click
            (object sender, System.EventArgs e)
        {
            if(_currentRow == null)
                return;

            var id = _currentRow.Cells[0].Value.ToString();
            ChangeStatus(id, 1);
        }

        private void ContextDisableToolStripMenuItem_Click
            (object sender, System.EventArgs e)
        {
            if(_currentRow == null)
                return;

            var id = _currentRow.Cells[0].Value.ToString();
            ChangeStatus(id, 0);
        }


        private async void ChangeStatus
            (string userId, int status)
        {
            var result = new DialogResult();
            var action = status.Equals(1)?"habilitar":"inhabilitar";
            var name = _currentRow.Cells[1].Value.ToString();
            result = MsgBox.Show(this, $"¿Esta seguro(a) de {action} empleado {name}?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result.Equals(DialogResult.No))
                return;

            try {
                var changeStatusDto = new ChangeStatusDto {
                    UserId = _currentRow.Cells[0].Value.ToString(),
                    Status= status
                };
                string response = await _employeeService.ChangeEmployeeStatus(changeStatusDto);
                MsgBox.Show(this, response, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _currentRow.Cells[6].Value = status.Equals(1) ? "Activo" : "Inactivo";

            } catch(System.Exception ex) {
                MsgBox.Show(this, ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GridContextMenu_Opening
            (object sender, System.ComponentModel.CancelEventArgs e)
        {
            ConfigureContextMenu();
            if(_currentRow is null) {
                return;
            }

            ContextEnableToolStripMenuItem.Visible = !_currentRow.Cells[6].Value.Equals("Activo");
            ContextDisableToolStripMenuItem.Visible = !_currentRow.Cells[6].Value.Equals("Inactivo");

        }

        private void ContextChangePasswordToolStripMenuItem1_Click
            (object sender, System.EventArgs e)
        {
            if(_currentRow is null)
                return;
            var form = new ChangePasswordForm(_employeeService) {
                UserId = _currentRow.Cells[0].Value.ToString()
            };
            form.ShowDialog();
        }


    }
}

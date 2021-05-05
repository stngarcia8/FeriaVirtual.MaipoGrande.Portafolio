using FeriaVirtual.App.Desktop.SeedWork.FormControls;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox;
using FeriaVirtual.App.Desktop.Services.Employees;
using FeriaVirtual.App.Desktop.Services.Employees.Dto;
using FeriaVirtual.App.Desktop.Services.Employees.ViewModels;
using MetroFramework.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.Employees
{
    public partial class EmployeeUpdateForm : MetroForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly ThemeManager _themeManager;
        private EmployeeViewModel _actualEmployee;

        public string EmployeeId { get; set; }
        public bool IsSaved { get; protected set; }


        public EmployeeUpdateForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _themeManager = ThemeManager.SuscribeForm(this);
            _themeManager.DarkMode();
            _actualEmployee = null;
        }


        private void EmployeeUpdateForm_Load
            (object sender, EventArgs e)
        {
            IsSaved = false;
            LoadEmployeeData().GetAwaiter();
            FirstnameTextBox.Focus();
        }


        private async Task LoadEmployeeData()
        {
            _actualEmployee = await _employeeService.GetEmployeeById(EmployeeId);
            if(_actualEmployee is null) {
                MsgBox.Show(this, "Imposible cargar datos de usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UpdateFormButton.Enabled = false;
                return;
            }
            FillControlsWithEmployeeData();
        }


        private void FillControlsWithEmployeeData()
        {
            FirstnameTextBox.Text = _actualEmployee.FirstName;
            LastnameTextBox.Text = _actualEmployee.LastName;
            RutTextBox.Text = _actualEmployee.Dni;
            ProfileComboBox.Text = _actualEmployee.ProfileName;
            UsernameTextBox.Text = _actualEmployee.Username;
            EmailTextBox.Text = _actualEmployee.Email;
        }

        private async void UpdateFormButton_Click
            (object sender, EventArgs e)
        {
            await UpdateEmployee();
            if(!IsSaved)
                return;
            Close();
        }

        private void CancelFormButton_Click
            (object sender, EventArgs e)
            => Close();


        private async Task UpdateEmployee()
        {
            try {
                var employeeDto = GenerateDto();
                var result = await _employeeService.UpdateEmployee(employeeDto);
                IsSaved = true;
                MsgBox.Show(this, result, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex) {
                IsSaved = false;
                MsgBox.Show(this, ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private UpdateUserDto GenerateDto()
            => new UpdateUserDto {
                UserId = _actualEmployee.UserId,
                Firstname = FirstnameTextBox.Text,
                Lastname = LastnameTextBox.Text,
                Dni = RutTextBox.Text,
                ProfileId = ProfileComboBox.SelectedIndex + 1,
                Username = UsernameTextBox.Text,
                Email = EmailTextBox.Text,
                IsActive = _actualEmployee.IsActive
            };



    }
}

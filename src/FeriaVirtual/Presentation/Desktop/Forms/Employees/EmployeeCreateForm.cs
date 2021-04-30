using FeriaVirtual.App.Desktop.SeedWork.FormControls;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox;
using FeriaVirtual.App.Desktop.Services.Employees;
using FeriaVirtual.App.Desktop.Services.Employees.Dto;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.Employees
{
    public partial class EmployeeCreateForm : MetroForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly ThemeManager _themeManager;

        public bool IsSaved { get; protected set; }


        public EmployeeCreateForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _themeManager = ThemeManager.SuscribeForm(this);
            _themeManager.DarkMode();
        }

        private void EmployeeCreateForm_Load(object sender, EventArgs e)
        {
            IsSaved = false;
            CleanControls();
            FirstnameTextBox.Focus();
        }


        private void CleanControls()
        {
            FirstnameTextBox.Text = string.Empty;
            LastnameTextBox.Text = string.Empty;
            RutTextBox.Text = string.Empty;
            ProfileComboBox.SelectedIndex = 0;
            EmailTextBox.Text = string.Empty;
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        private void CleanFormButton_Click
            (object sender, EventArgs e) =>
            CleanControls();


        private async void CreateFormButton_Click
            (object sender, EventArgs e)
        {
            await CreateEmployee();
            if(!IsSaved)
                return;
            Close();
        }

        
        private void CancelFormButton_Click
            (object sender, EventArgs e) =>
            Close();


        private async  Task CreateEmployee()
        {
            try {
                var employeeDto = GenerateDto();
                var result = await _employeeService.CreateEmployee(employeeDto);
                IsSaved = true;
                MsgBox.Show(this, result, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex) {
                IsSaved = false;
                MsgBox.Show(this, ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private CreateUserDto GenerateDto() =>
            new CreateUserDto {
                Firstname = FirstnameTextBox.Text,
                Lastname = LastnameTextBox.Text,
                Dni = RutTextBox.Text,
                ProfileId = ProfileComboBox.SelectedIndex + 1,
                Email = EmailTextBox.Text,
                Username = UsernameTextBox.Text,
                Password = PasswordTextBox.Text
            };

    }
}

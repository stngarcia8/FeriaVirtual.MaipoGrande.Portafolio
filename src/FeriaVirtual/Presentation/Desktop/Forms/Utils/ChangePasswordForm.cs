using FeriaVirtual.App.Desktop.SeedWork.FormControls;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox;
using FeriaVirtual.App.Desktop.Services.Employees;
using FeriaVirtual.App.Desktop.Services.Employees.Dto;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.Utils
{
    public partial class ChangePasswordForm : MetroFramework.Forms.MetroForm
    {
        private readonly  IEmployeeService _employeeService;
        private readonly ThemeManager _themeManager;
        private bool _isSaved;

        public string UserId { get; set; }


        public ChangePasswordForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _themeManager = ThemeManager.SuscribeForm(this);
            _themeManager.DarkMode();
        }


        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            _isSaved = false;
            NewPasswordTextBox.Text = string.Empty;
            ReNewPasswordTextBox.Text = string.Empty;
            NewPasswordTextBox.Focus();
        }

        private async void FormChangePasswordButton_Click(object sender, EventArgs e)
        {
            if(!NewPasswordTextBox.Text.Equals(ReNewPasswordTextBox.Text)) {
                MsgBox.Show(this, "Las contraseñas no coinciden", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NewPasswordTextBox.Focus();
                return;
            }

            await ChangePassword();
            if(!_isSaved)
                return;
            Close();
        }

        private void FormCancelButton_Click
            (object sender, EventArgs e)
            => Close();


        private async Task ChangePassword()
        {
            try {
                var changePasswordDto = new ChangePasswordDto {
                    Userid = UserId,
                    Password= NewPasswordTextBox.Text
                };
                string response = await _employeeService.ChangeEmployeePassword(changePasswordDto);
                MsgBox.Show(this, response, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _isSaved = true;

            } catch(System.Exception ex) {
                _isSaved = false;
                MsgBox.Show(this, ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}

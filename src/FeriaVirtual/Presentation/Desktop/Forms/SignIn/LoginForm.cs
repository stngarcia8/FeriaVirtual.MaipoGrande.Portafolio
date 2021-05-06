using FeriaVirtual.App.Desktop.Extensions.DependencyInjection;
using FeriaVirtual.App.Desktop.Forms.MainForms;
using FeriaVirtual.App.Desktop.SeedWork.FormControls.Themes;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Preferences;
using FeriaVirtual.App.Desktop.Services.SignIn;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.SignIn
{
    public partial class LoginForm : MetroForm
    {
        private readonly ThemeManager _themeManager;


        public LoginForm()
        {
            InitializeComponent();
            _themeManager = ThemeManager.SuscribeForm(this);
            _themeManager.Initialize(PreferenceData.ColorSchema, PreferenceData.DarkMode);
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            UsernameTextBox.Focus();
        }


        private async void AceptFormButton_Click
            (object sender, EventArgs e)
        {
            try {
                var serviceProvider = DependencyContainer.GetProvider;
                ISigninService s = serviceProvider.GetService<ISigninService>();
                await s.SigninAsync(this.UsernameTextBox.Text, this.PasswordTextBox.Text);
                OpenForm();
            } catch(Exception ex) {
                MetroMessageBox.Show(this, ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CancelFormButton_Click
            (object sender, EventArgs e) =>
            Environment.Exit(0);



        private void OpenForm()
        {
            Hide();
            using(var form = new AdminForm()) {
                form.ShowDialog();
            }
        }

    }
}

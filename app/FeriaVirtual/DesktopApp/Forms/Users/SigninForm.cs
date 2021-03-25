using FeriaVirtual.App.Desktop.Dtos.Users;
using FeriaVirtual.App.Desktop.Exceptions;
using FeriaVirtual.App.Desktop.Forms.Utils;
using FeriaVirtual.App.Desktop.SeedWork.FormsControls;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Security;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Utils;
using FeriaVirtual.App.Desktop.SeedWork.Protocols;
using FeriaVirtual.App.Desktop.ViewModels.Users;
using MaterialSkin.Controls;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.Forms.Users
{
    public partial class SigninForm : MaterialForm
    {
        private readonly ThemeManager _themeManager;


        public SigninForm()
        {
            InitializeComponent();
            _themeManager = ThemeManager.SubscribeForm(this);
        }

        private void SigninForm_Load(object sender, EventArgs e)
        {
            this.UsernameTextBox.Text = string.Empty;
            this.PasswordTextBox.Text = string.Empty;
            this.UsernameTextBox.Focus();
        }


        private void AceptFormMaterialFlatButton_Click(object sender, EventArgs e)
        {
            IEncriptor encriptor = EncriptSha1.CreateEncriptor(this.PasswordTextBox.Text.Trim());
            var dto = new SignInUserDto(
                this.UsernameTextBox.Text.Trim(),
                encriptor.GetEncriptedPassword());
            SignIn(dto).GetAwaiter();
        }


        private void CancelFormMaterialFlatButton_Click(object sender, EventArgs e)
        {
            _themeManager.UnsubscribeForm(this);
            Application.Exit();
        }


        private async Task SignIn(SignInUserDto userDto)
        {
            try {
                HttpResponseMessage response = await GetDataFromApi(userDto);
                var result = await response.Content.ReadAsAsync<UserSignInViewModel>();
                VerifyUserProfile(result);
                this.Hide();
                Form form = new MainAdminForm();
                form.ShowDialog();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private async Task<HttpResponseMessage> GetDataFromApi(SignInUserDto userDto)
        {
            var clientHttp = ClientHttp.GetHttpClient();
            HttpResponseMessage response = await clientHttp.PostAsJsonAsync("api/sign_in", userDto);
            if (!response.IsSuccessStatusCode) {
                throw new InvalidAccessException("El usuario no tiene acceso a Feria virtual.");
            }
            return response;
        }


        private void VerifyUserProfile(UserSignInViewModel result)
        {
            if (result.ProfileId < 1 || result.ProfileId > 2) {
                throw new InvalidAccessException("El usuario no tiene permisos para ingresar a la aplicación.");
            }
            SessionData.AssignUserData(result);
        }




    }
}

using FeriaVirtual.App.Desktop.SeedWork.Helpers.Security;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Utils;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FeriaVirtual.App.Desktop.Services.SignIn
{
    public class SigninService
        : ISigninService
    {
        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl = "https://localhost:44315";


        public SigninService(HttpClient httpClient) =>
            _httpClient = httpClient;


        public async Task SigninAsync(string username, string password)
        {
            var userDto = BuildDto(username, password);
            var stringResponse = await GetDataFromApi(userDto);
            var result = JsonConvert.DeserializeObject<SignInViewModel>(stringResponse);
            VerifyUserProfile(result);
        }


        private SignInDto BuildDto
            (string username, string password)
        {
            IEncriptor encriptor = EncriptSha1.CreateEncriptor(password);
            var userDto = new SignInDto {
                Username = username,
                Password = encriptor.GetEncriptedPassword()
            };
            return userDto;
        }


        private async Task<string> GetDataFromApi(SignInDto userDto)
        {
            var uri = new Uri(_remoteServiceBaseUrl);
            _httpClient.BaseAddress = uri;
            var request = new HttpRequestMessage {
                Content = new StringContent(JsonConvert.SerializeObject(userDto)),
            };
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("api/sign_in", request.Content);
            if (!response.IsSuccessStatusCode) {
                throw new InvalidAccessException("El usuario no tiene acceso a Feria virtual.");
            }
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);

        }


        private void VerifyUserProfile(SignInViewModel result)
        {
            if (result.ProfileId < 1 || result.ProfileId > 2) {
                throw new InvalidAccessException("El usuario no tiene permisos para ingresar a la aplicación.");
            }
            SessionData.AssignUserData(result);
        }


    }
}

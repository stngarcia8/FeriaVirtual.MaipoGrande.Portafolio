using Newtonsoft.Json;

namespace FeriaVirtual.App.Desktop.Services.SignIn
{
    public class SignInDto
    {
        [JsonProperty(Required = Required.Always)]
        public string Username { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Password { get; set; }


    }
}

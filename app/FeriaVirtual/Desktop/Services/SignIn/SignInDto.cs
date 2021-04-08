using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.App.Desktop.Services.SignIn
{
    public class SignInDto
    {
        [JsonProperty(Required=Required.Always)]
        public string Username { get; set; }

        [JsonProperty(Required= Required.Always)]
        public string Password { get; set; }


    }
}

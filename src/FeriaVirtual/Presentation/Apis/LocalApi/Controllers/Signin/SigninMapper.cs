using FeriaVirtual.Application.Services.Signin.Queries;

namespace FeriaVirtual.Api.Local.Controllers.Signin
{
    public class SigninMapper
    {
        private readonly SigninRequest _request;


        private SigninMapper(SigninRequest request)
            => _request = request;


        public static SigninMapper BuildMapper(SigninRequest request)
            => new(request);


        public SigninQuery Map()
            => new(_request.Username, _request.Password);


    }
}

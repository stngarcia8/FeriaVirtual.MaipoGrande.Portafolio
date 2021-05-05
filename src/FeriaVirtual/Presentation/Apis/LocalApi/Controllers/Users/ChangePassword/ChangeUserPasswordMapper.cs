using FeriaVirtual.Application.Services.Users.Commands.ChangePassword;

namespace FeriaVirtual.Api.Local.Controllers.Users.ChangePassword
{
    public class ChangeUserPasswordMapper
    {
        private readonly ChangeUserPasswordRequest _request;


        public ChangeUserPasswordMapper(ChangeUserPasswordRequest request)
            => _request = request;


        public static ChangeUserPasswordMapper BuildMapper(ChangeUserPasswordRequest request)
            => new(request);


        public ChangeUserPasswordCommand Map()
            => new(_request.UserId, _request.Password);



    }
}

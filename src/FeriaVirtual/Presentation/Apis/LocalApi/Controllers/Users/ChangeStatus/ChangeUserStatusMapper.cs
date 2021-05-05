using FeriaVirtual.Application.Users.Commands.ChangeStatus;

namespace FeriaVirtual.Api.Local.Controllers.Users.ChangeStatus
{
    public class ChangeUserStatusMapper
    {
        private readonly ChangeUserStatusRequest _request;


        public ChangeUserStatusMapper(ChangeUserStatusRequest request)
            => _request = request;


        public static ChangeUserStatusMapper BuildMapper(ChangeUserStatusRequest request)
            => new(request);


        public ChangeUserStatusCommand Map()
            => new(_request.UserId, _request.Status);


    }
}

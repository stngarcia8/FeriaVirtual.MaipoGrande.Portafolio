using FeriaVirtual.Api.Local.SeedWork;

namespace FeriaVirtual.Api.Local.Controllers.Users.ChangeStatus
{
    public class ChangeUserStatusRequest
        : IRequest
    {
        public System.Guid UserId { get; set; }
        public int Status { get; set; }


        public ChangeUserStatusRequest() { }


    }
}

using FeriaVirtual.Application.Services.Users.Create;

namespace FeriaVirtual.Api.Local.Controllers.Users.Create
{
    public class CreateUserMapper
    {
        private readonly CreateUserRequest _request;


        private CreateUserMapper(CreateUserRequest request) =>
            _request = request;


        public static CreateUserMapper BuildMapper(CreateUserRequest request) =>
            new(request);


        public CreateUserCommand Map() =>
            CreateUserCommandBuilder.GetInstance()
                    .Firstname(_request.Firstname)
                    .Lastname(_request.Lastname)
                    .Dni(_request.Dni)
                    .ProfileId(_request.ProfileId)
                    .Username(_request.Username)
                    .Password(_request.Password)
                    .Email(_request.Email)
                    .Build();


    }
}

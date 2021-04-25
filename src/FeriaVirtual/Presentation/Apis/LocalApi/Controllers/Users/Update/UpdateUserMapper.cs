using FeriaVirtual.Application.Services.Users.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeriaVirtual.Api.Local.Controllers.Users.Update
{
    public class UpdateUserMapper
    {
        private readonly UpdateUserRequest _request;


        private UpdateUserMapper(UpdateUserRequest request) 
            => _request = request;


        public static UpdateUserMapper BuildMapper(UpdateUserRequest request) 
            => new(request);


        public UpdateUserCommand Map() 
            => UpdateUserCommandBuilder.GetInstance()
                    .UserId(_request.UserId.ToString())
                    .Firstname(_request.Firstname)
                    .Lastname(_request.Lastname)
                    .Dni(_request.Dni)
                    .ProfileId(_request.ProfileId)
                    .CredentialId(_request.CredentialId.ToString())
                    .Username(_request.Username)
                    .Email(_request.Email)
                    .IsActive(_request.IsActive)
                    .Build();


    }
}

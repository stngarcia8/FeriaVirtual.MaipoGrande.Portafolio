using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Application.Users.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Users
{

    [ApiController]
    public class UpdateUserController
        : ControllerBase
    {
        private readonly IUpdateUserService _updateService;


        public UpdateUserController(IUpdateUserService updateService) =>
            _updateService = updateService;


        [HttpPut]
        [Route("api/users/update")]
        public IActionResult Put([FromBody] UpdateUserDto userDto)
        {
            try {
                _updateService.Update(userDto);
                return StatusCode(200, $"El usuario {userDto.Firstname} {userDto.Lastname} fue actualizado correctamente");
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}

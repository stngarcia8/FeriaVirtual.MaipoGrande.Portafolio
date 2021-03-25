using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Application.Users.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Users
{
    [ApiController]
    public class ChangeUserStatusController
        : ControllerBase
    {
        private readonly IEnableOrDisableUserService _userService;


        public ChangeUserStatusController(IEnableOrDisableUserService userService) =>
            _userService = userService;


        [HttpPatch]
        [Route("api/users/enable/{userid}")]
        public IActionResult Patch(string userid)
        {
            try {
                _userService.EnableUser(userid);
                return StatusCode(201, "El usuario fue habilitado.");
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpPatch]
        [Route("api/users/disable/{userid}")]
        public IActionResult DisableUser(string userid)
        {
            try {
                _userService.DisableUser(userid);
                return StatusCode(201, "El usuario fue inhabilitado.");
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}

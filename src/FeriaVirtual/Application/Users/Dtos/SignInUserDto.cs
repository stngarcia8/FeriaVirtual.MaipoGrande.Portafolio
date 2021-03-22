﻿namespace FeriaVirtual.Application.Users.Dtos
{
    public class SignInUserDto
    {
        public string Username { get; protected set; }
        public string Password { get; protected set; }


        public SignInUserDto(string username, string password)
        {
            Username = username;
            Password = password;
        }


    }
}

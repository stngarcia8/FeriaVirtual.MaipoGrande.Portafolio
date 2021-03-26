using System;

namespace FeriaVirtual.Domain.SeedWork.Commands
{
    public class CommandNotRegisteredException
        : Exception
    {
        public CommandNotRegisteredException(Command command)
            : base($"Comando {command} no registrado.") { }


    }
}

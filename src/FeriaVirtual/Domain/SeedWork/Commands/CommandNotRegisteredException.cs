namespace FeriaVirtual.Domain.SeedWork.Commands
{
    public class CommandNotRegisteredException
        : System.Exception
    {
        public CommandNotRegisteredException(Command command)
            : base($"Comando {command} no registrado.") { }


    }
}

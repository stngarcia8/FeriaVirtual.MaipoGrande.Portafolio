namespace FeriaVirtual.App.Desktop.Services.Employees.Exceptions
{
    public class InvalidCreateEmployeeException
        : System.Exception
    {
        public InvalidCreateEmployeeException(string message)
            : base(
                  $"Problemas al crear usuario:{System.Environment.NewLine}{message}"
                  ){ }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext
{
    public class DBContextFailedException
        :Exception
    {
        public DBContextFailedException(string message)
            :base(message) { }


    }
}

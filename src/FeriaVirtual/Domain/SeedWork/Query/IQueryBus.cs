using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Query
{
    public interface IQueryBus
    {
        Task<TResponse> Ask<TResponse>(Query request);


    }
}

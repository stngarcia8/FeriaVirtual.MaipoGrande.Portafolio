﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Query
{
    public interface IQueryHandler<TQuery, TResponse>
        where TQuery:Query
    {
        Task<TResponse> Handle(TQuery query);


    }
}

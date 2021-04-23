using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace FeriaVirtual.Api.Local.Extensions
{
    public static class ModelStateExtensions
    {
        public static string ToJson(this ModelStateDictionary modelstate)
        {
            List<string> errors = modelstate.Values
                .SelectMany(x => x.Errors)
                .Select(x => x.ErrorMessage)
                .ToList();
            return JsonConvert.SerializeObject(errors);
        }


    }
}

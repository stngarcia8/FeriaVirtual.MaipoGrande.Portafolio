using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles
{
    public interface IProfileInfo
    {
        int ProfileId { get; }
        string ProfileName { get; }
        string SingleProfileName { get; }

        string ToString();


    }
}

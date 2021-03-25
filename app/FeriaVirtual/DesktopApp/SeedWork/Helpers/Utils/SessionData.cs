using FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles;
using FeriaVirtual.App.Desktop.ViewModels.Users;

namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Utils
{
    public static class SessionData
    {

        public static string FullName { get; set; }
        public static string Dni { get; set; }
        public static string Email { get; set; }
        public static IProfileInfo Profile { get; set; }


        public static void AssignUserData(UserSignInViewModel data)
        {
            FullName = data.FullName;
            Dni = data.Dni;
            Email = data.Email;
            Profile = ProfileInfo.CreateProfile((ProfileType)data.ProfileId).GetProfile;
        }


    }
}

namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles
{
    class AdministratorProfile
    : IProfileInfo
    {

        public int ProfileId => (int)ProfileType.Administrator;
        public string ProfileName => "Administradores";
        public string SingleProfileName => "Administrador";


        private AdministratorProfile() { }

        public static AdministratorProfile CreateProfile() =>
            new AdministratorProfile();

        public override string ToString() =>
            ProfileName;


    }
}

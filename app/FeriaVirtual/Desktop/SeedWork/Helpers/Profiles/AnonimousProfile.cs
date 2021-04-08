namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles
{
    class AnonimousProfile
        : IProfileInfo
    {

        public int ProfileId => (int)ProfileType.Anonimous;
        public string ProfileName => "Usuarios anonimos";
        public string SingleProfileName => "Usuario anonimo";


        private AnonimousProfile() { }


        public static AnonimousProfile CreateProfile() =>
            new AnonimousProfile();


        public override string ToString() =>
            ProfileName;


    }
}

namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles
{
    class ConsultantProfile
        : IProfileInfo
    {

        public int ProfileId => (int)ProfileType.Consultant;
        public string ProfileName => "Consultores";
        public string SingleProfileName => "Consultor";


        private ConsultantProfile() { }


        public static ConsultantProfile CreateProfile() =>
            new ConsultantProfile();


        public override string ToString() =>
            ProfileName;


    }
}

namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles
{
    class CarrierProfile
        : IProfileInfo
    {

        public int ProfileId => (int)ProfileType.Carrier;
        public string ProfileName => "Transportistas";
        public string SingleProfileName => "Transportista";


        private CarrierProfile() { }


        public static CarrierProfile CreateProfile() =>
            new CarrierProfile();


        public override string ToString() =>
            ProfileName;


    }
}

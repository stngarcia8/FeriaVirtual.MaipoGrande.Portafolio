namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles
{
    class ProducerProfile
        : IProfileInfo
    {

        public int ProfileId => (int)ProfileType.Producer;
        public string ProfileName => "Productores";
        public string SingleProfileName => "Productor";


        private ProducerProfile() { }


        public static ProducerProfile CreateProfile() =>
            new ProducerProfile();


        public override string ToString() =>
            ProfileName;


    }
}

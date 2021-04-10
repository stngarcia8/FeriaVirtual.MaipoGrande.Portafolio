namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles
{
    class ExternalCustomerProfile
        : IProfileInfo
    {

        public int ProfileId => (int)ProfileType.ExternalCustomer;
        public string ProfileName => "Clientes externos";
        public string SingleProfileName => "Cliente externo";


        private ExternalCustomerProfile() { }


        public static ExternalCustomerProfile CreateProfile() =>
            new ExternalCustomerProfile();


        public override string ToString() =>
            ProfileName;


    }
}

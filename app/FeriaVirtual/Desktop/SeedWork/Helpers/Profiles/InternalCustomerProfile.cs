namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles
{
    class InternalCustomerProfile
        : IProfileInfo
    {

        public int ProfileId => (int)ProfileType.InternalCustomer;
        public string ProfileName => "Clientes internos";
        public string SingleProfileName => "Cliente interno";


        private InternalCustomerProfile() { }


        public static InternalCustomerProfile CreateProfile() =>
            new InternalCustomerProfile();


        public override string ToString() =>
            ProfileName;


    }
}

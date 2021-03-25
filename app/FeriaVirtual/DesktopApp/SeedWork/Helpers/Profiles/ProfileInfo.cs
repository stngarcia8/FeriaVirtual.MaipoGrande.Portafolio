namespace FeriaVirtual.App.Desktop.SeedWork.Helpers.Profiles
{
    public class ProfileInfo
    {

        private readonly ProfileType _profileType;
        public IProfileInfo GetProfile { get; protected set; }


        private ProfileInfo(ProfileType profileType)
        {
            _profileType = profileType;
            GetProfile = CheckProfile();
        }


        public static ProfileInfo CreateProfile(ProfileType profileType) =>
            new ProfileInfo(profileType);


        private IProfileInfo CheckProfile()
        {
            switch (_profileType) {
                case ProfileType.Administrator:
                    return AdministratorProfile.CreateProfile();
                case ProfileType.Consultant:
                    return ConsultantProfile.CreateProfile();
                case ProfileType.ExternalCustomer:
                    return ExternalCustomerProfile.CreateProfile();
                case ProfileType.InternalCustomer:
                    return InternalCustomerProfile.CreateProfile();
                case ProfileType.Producer:
                    return ProducerProfile.CreateProfile();
                case ProfileType.Carrier:
                    return CarrierProfile.CreateProfile();
                default:
                    return AnonimousProfile.CreateProfile();
            }
        }




    }
}

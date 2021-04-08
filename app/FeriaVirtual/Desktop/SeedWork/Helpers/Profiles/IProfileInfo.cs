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

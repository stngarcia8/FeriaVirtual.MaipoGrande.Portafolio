namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        void DisableUser(User user);
        void EnableUser(User user);
        void Update(User user);
    }
}
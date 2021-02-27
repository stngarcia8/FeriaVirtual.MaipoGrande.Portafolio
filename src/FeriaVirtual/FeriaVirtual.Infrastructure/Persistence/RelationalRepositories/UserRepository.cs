using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;

namespace FeriaVirtual.Infrastructure.Persistence.RelationalRepositories
{
    public class UserRepository
        : RepositoryBase, IUserRepository
    {
        private readonly IUserRepository _repository;

        public UserRepository(IUserRepository repository)
        {
            _dbConfig = RelationalConfig.Build()
            _repository = repository;
        }

        public void Create(User user)
        {
            _sqlStatement = "sp_add_credential";
            this.Execute<Credential>(user.GetCredential);
            _sqlStatement = "sp_add_user";
            this.Execute<User>(user);
        }

        public void Update(User user)
        {
            _sqlStatement = "sp_update_credential";
            this.Execute<Credential>(user.GetCredential);
            _sqlStatement = "sp_update_user";
            this.Execute<User>(user);
        }

        public void EnableUser(User user)
        {
            _sqlStatement = "sp_enable_user";
            this.Execute<Credential>(user.GetCredential);
        }

        public void DisableUser(User user)
        {
            _sqlStatement = "sp_disable_user";
            this.Execute<Credential>(user.GetCredential);
        }


    }
}

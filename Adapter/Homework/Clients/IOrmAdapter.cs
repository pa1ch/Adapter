using Adapter.Homework.Models;

namespace Adapter.Homework.Clients
{
    public interface IOrmAdapter// ITarget
    {
        DbUserEntity GetUserBy(int userId);
        DbUserInfoEntity GetUserInfoBy(int infoId);

        void CreateUser(DbUserEntity userEntity, DbUserInfoEntity userInfoEntity);

        void RemoveUserById(int userId);
    }
}

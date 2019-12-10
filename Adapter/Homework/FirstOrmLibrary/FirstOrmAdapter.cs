using Adapter.Homework.Clients;
using Adapter.Homework.Models;

namespace Adapter.Homework.FirstOrmLibrary
{
    public class FirstOrmAdapter : IOrmAdapter
    {
        private IFirstOrm<DbUserEntity> _firstOrm1;
        private IFirstOrm<DbUserInfoEntity> _firstOrm2;

        public FirstOrmAdapter(IFirstOrm<DbUserEntity> firstOrm1, IFirstOrm<DbUserInfoEntity> firstOrm2)
        {
            _firstOrm1 = firstOrm1;
            _firstOrm2 = firstOrm2;
        }


        public DbUserEntity GetUserBy(int userId)
        {
            return _firstOrm1.Read(userId);
        }

        public DbUserInfoEntity GetUserInfoBy(int infoId)
        {
            return _firstOrm2.Read(infoId);
        }

        public void CreateUser(DbUserEntity userEntity, DbUserInfoEntity userInfoEntity)
        {
            _firstOrm1.Add(userEntity);
            _firstOrm2.Add(userInfoEntity);
        }

        public void RemoveUserById(int userId)
        {
            var user = GetUserBy(userId);
            var userInfo = GetUserInfoBy(user.InfoId);

            _firstOrm1.Delete(user);
            _firstOrm2.Delete(userInfo);
        }
    }
}
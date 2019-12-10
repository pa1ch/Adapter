using System.Linq;
using Adapter.Homework.Clients;
using Adapter.Homework.Models;

namespace Adapter.Homework.SecondOrmLibrary
{
    public class SecondOrmAdapter : IOrmAdapter
    {
        private ISecondOrm _secondOrm;

        public SecondOrmAdapter(ISecondOrm secondOrm)
        {
            _secondOrm = secondOrm;
        }

        public DbUserEntity GetUserBy(int userId)
        {
            return _secondOrm.Context.Users.First(user => user.Id == userId);
        }

        public DbUserInfoEntity GetUserInfoBy(int infoId)
        {
            return _secondOrm.Context.UserInfos.First(info => info.Id == infoId);
        }

        public void CreateUser(DbUserEntity userEntity, DbUserInfoEntity userInfoEntity)
        {
            _secondOrm.Context.Users.Add(userEntity);
            _secondOrm.Context.UserInfos.Add(userInfoEntity);
        }

        public void RemoveUserById(int userId)
        {
            var user = GetUserBy(userId);
            _secondOrm.Context.Users.RemoveWhere(x => x.Id == userId);
            _secondOrm.Context.UserInfos.RemoveWhere(x => x.Id == user.InfoId);
        }
    }
}
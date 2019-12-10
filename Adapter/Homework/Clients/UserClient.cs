using Adapter.Homework.Models;

namespace Adapter.Homework.Clients
{
    public class UserClient
    {
        private IOrmAdapter _ormAdapter;

        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
            var user = _ormAdapter.GetUserBy(userId);
            var userInfo = _ormAdapter.GetUserInfoBy(user.InfoId);

            return (user, userInfo);
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            _ormAdapter.CreateUser(user, userInfo);
        }

        public void Remove(int userId)
        {
            _ormAdapter.RemoveUserById(userId);
        }

        public UserClient(IOrmAdapter ormAdapter)
        {
            _ormAdapter = ormAdapter;
        }
    }
}

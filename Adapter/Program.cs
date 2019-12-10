using Adapter.Homework.Clients;
using Adapter.Homework.FirstOrmLibrary;
using Adapter.Homework.Models;
using Adapter.Homework.SecondOrmLibrary;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbUserEntity = new DbUserEntity();
            var dbUserInfoEntity = new DbUserInfoEntity();

            var firstUserOrm = new ConcreteFirstOrm<DbUserEntity>();
            var firstUserInfoOrm = new ConcreteFirstOrm<DbUserInfoEntity>();
            
            var firstOrmAdapter = new FirstOrmAdapter(firstUserOrm, firstUserInfoOrm);
            var firstClient = new UserClient(firstOrmAdapter);
            firstClient.Add(dbUserEntity, dbUserInfoEntity);

            var secondOrm = new ConcreteSecondOrm();
            var secondOrmAdapter = new SecondOrmAdapter(secondOrm);
            var secondClient = new UserClient(secondOrmAdapter);
            secondClient.Add(dbUserEntity, dbUserInfoEntity);
        }
    }
}
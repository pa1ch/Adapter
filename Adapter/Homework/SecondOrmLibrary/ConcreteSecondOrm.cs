using System.Collections.Generic;
using Adapter.Homework.FirstOrmLibrary;
using Adapter.Homework.Models;

namespace Adapter.Homework.SecondOrmLibrary
{
    public class ConcreteSecondOrm : ISecondOrm
    {
        public ISecondOrmContext Context { get; }

        public ConcreteSecondOrm()
        {
            Context = new ConcreteSecondOrmContext();
        }
    }
    
    public class ConcreteSecondOrmContext : ISecondOrmContext
    {
        public HashSet<DbUserEntity> Users { get; } = new HashSet<DbUserEntity>();
        public HashSet<DbUserInfoEntity> UserInfos { get; } = new HashSet<DbUserInfoEntity>();
    }
}
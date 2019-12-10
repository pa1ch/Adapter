using Adapter.Homework.Models.Interfaces;

namespace Adapter.Homework.FirstOrmLibrary
{
    public interface IFirstOrm<TDbEntity> 
        where TDbEntity : IDbEntity
    {
        void Add(TDbEntity entity);
        TDbEntity Read(int id);
        void Delete(TDbEntity entity);
    }
}

using System.Collections.Generic;
using Adapter.Homework.Models;
using Adapter.Homework.Models.Interfaces;

namespace Adapter.Homework.FirstOrmLibrary
{
    public class ConcreteFirstOrm<TDbEntity> : IFirstOrm<TDbEntity> 
        where TDbEntity : IDbEntity
    {
        private List<TDbEntity> _entities = new List<TDbEntity>();
        
        public void Add(TDbEntity entity)
        {
            _entities.Add(entity);
        }

        public TDbEntity Read(int id)
        {
            return _entities[id];
        }

        public void Delete(TDbEntity entity)
        {
            _entities.Remove(entity);
        }
    }
}
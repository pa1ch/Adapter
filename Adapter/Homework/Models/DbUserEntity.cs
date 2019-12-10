using Adapter.Homework.Models.Interfaces;

namespace Adapter.Homework.Models
{
    public class DbUserEntity : IDbEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public int InfoId { get; set; }
    }
}
